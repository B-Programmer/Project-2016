using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using Accord.Imaging.Filters;
using AForge.Vision;

namespace SampleFaceApplication
{
    public partial class FrmEnrollUser : Form
    {
        private string picture;
        private HaarObjectDetector detector;
        private Accord.Vision.Detection.HaarCascade cascade;
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbFace.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\SampleFaceApplication\SampleFaceApplication\dbFace.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmEnrollUser()
        {
            try
            {
                InitializeComponent();
                cascade = new FaceHaarCascade();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Face Detection and Recognition Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Always ensure that load  ");
                OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                //openFileDialog.InitialDirectory = Application.StartupPath + "\\TrainDatabase";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    //Bitmap uploadImage = new Bitmap(openFileDialog.FileName);
                    //pictureBox1.Image = resizeImage(uploadImage, 300, 300);
                    //pictureBox1.Size = pictureBox1.Image.Size;
                    picture = openFileDialog.FileName;
                    //MessageBox.Show(picture);
                    pictureBox2.Image = null;
                }
                btnUpload.Enabled = false;
                btnTrainFace.Enabled = true;
                btnSave.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Face Detection and Recognition Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private static Image resizeImage(Image image, int imgWidth, int imgHeight)
        {
            Bitmap newImage = new Bitmap(imgWidth, imgHeight);
            Graphics g = Graphics.FromImage((Image)newImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.DrawImage(image, 0, 0, imgWidth, imgHeight);
            return newImage;
        }

        private void btnTrainFace_Click(object sender, EventArgs e)
        {
            try
            {
                detector = new HaarObjectDetector(cascade, 30);
                detector.SearchMode = ObjectDetectorSearchMode.Single;//.NoOverlap;//.Default; //.Average;
                detector.ScalingFactor = 1.5f;
                detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller;
                detector.UseParallelProcessing = true;
                detector.Suppression = 3;

                Bitmap picture = new Bitmap(pictureBox1.Image);
                Image<Bgr, byte> Frame = new Image<Bgr, byte>(picture);

                Stopwatch sw = Stopwatch.StartNew();
                Rectangle[] faceObjects = detector.ProcessFrame(picture);
                sw.Stop();

                if (faceObjects.Length > 0)
                {
                    RectanglesMarker marker = new RectanglesMarker(faceObjects, Color.Fuchsia);
                    pictureBox1.Image = marker.Apply(picture);

                    //Graphics g = Graphics.FromImage(pictureBox1.Image);
                    foreach (var face in faceObjects)
                    {
                        //g.DrawRectangle(Pens.DeepSkyBlue, face);
                        Frame.Draw(face, new Bgr(Color.Red), 3);
                        Bitmap c = Frame.ToBitmap();
                        Bitmap bmp = new Bitmap(face.Width, face.Height);
                        Graphics gg = Graphics.FromImage(bmp);
                        gg.DrawImage(c, 0, 0, face, GraphicsUnit.Pixel);
                        pictureBox2.Image = bmp;
                        //bmp.Save("myface(accord) " + DateTime.Now.Second.ToString());
                        gg.Dispose();
                    }
                    //g.Dispose();
                    //label1.Text = "Completed operation!! " + faceObjects.Length.ToString() + " Face detected";
                    MessageBox.Show("Train Face operation successful!!! " + faceObjects.Length.ToString() + " Face detected", "Train face", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFaceId.Text = genFaceId();
                    txtUsername.Text = "User" + txtFaceId.Text;
                    btnUpload.Enabled = false;
                    btnTrainFace.Enabled = false;
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Image cannot be trained!!! No face detected in the current image", "Fail to Train face", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Face Detection and Recognition Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private string genFaceId()
        {
            string FaceId = "";
            try
            {
                int rowCount = 0;
                cn.Open();
                cmd.CommandText = "select count(*) as RowCount from tblUser";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    rowCount = (int)(dr["RowCount"]);
                rowCount++;
                FaceId = FaceId + rowCount;                
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Face Detection and Recognition App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return FaceId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            txtFaceId.ResetText();
            txtUsername.ResetText();
            cboSex.ResetText();
            btnUpload.Enabled = true;
            btnTrainFace.Enabled = false;
            btnSave.Enabled = false;
        }

        private void FrmEnrollUser_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            txtFaceId.Enabled = false;
            btnReset_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (isAllEntryFilled())
                {
                    int FaceId = Convert.ToInt32(txtFaceId.Text);
                    string Username = txtUsername.Text;
                    string Sex = cboSex.Text;
                    if(picture != "") pictureBox1.Image = Image.FromFile(picture);
                    if (isSavePicture())
                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblUser values(" + FaceId + ", '" + Username + "','" + Sex + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Face Details successfully saved!!!", "Face Detection and Recognition App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        btnReset_Click(sender, e);
                    }
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Face Detection and Recognition App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtFaceId.Text == ""))
            {
                MessageBox.Show("Please click Reset or Load Image button to generate new User Image(Face)", "Face Detection and Recognition App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnUpload.Focus();
                return isEntryFilled;
            }
            else if ((txtUsername.Text == ""))
            {
                MessageBox.Show("Please enter the username", "Face Detection and Recognition App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return isEntryFilled;
            }
            else if ((cboSex.Text == ""))
            {
                MessageBox.Show("Please set the sex", "Face Detection and Recognition App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSex.Focus();
                return isEntryFilled;
            }            
            else
                return true;

        }
        private bool isSavePicture()
        {
            bool isSaved = false;
            try
            {
                
                if ((picture != "") && (pictureBox1.Image != null) && (pictureBox2.Image != null))
                {
                    if (txtFaceId.Text != "")
                    {
                        //Save the test face and trained face
                        string testPictureFileName = txtUsername.Text + txtFaceId.Text;
                        if (File.Exists(Application.StartupPath + "\\Face Db\\Test Face\\" + testPictureFileName + ".jpg"))
                        {
                            MessageBox.Show("Picture Cannot be Saved!!!, Duplicate Found", "Filename Already Exists");
                        }
                        else if (File.Exists(Application.StartupPath + "\\Face Db\\Trained Face\\" + txtFaceId.Text + ".jpg"))
                        {
                            MessageBox.Show("Picture Cannot be Saved!!!, Duplicate Found", "Filename Already Exists");
                        }
                        else
                        {
                            pictureBox1.Image.Save(Application.StartupPath + "\\Face Db\\Test Face\\" + testPictureFileName + ".jpg");
                            pictureBox2.Image.Save(Application.StartupPath + "\\Face Db\\Trained Face\\" + txtFaceId.Text + ".jpg");
                            MessageBox.Show("Trained Face Saved!!!");
                            //picture = Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg";
                            isSaved = true;
                        }
                    }
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Face Detection and Recognition Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSaved;
        }        
        
    }
}
