using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleFaceApplication
{
    public partial class FrmFaceRecognition : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbFace.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\SampleFaceApplication\SampleFaceApplication\dbFace.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private string FaceId;
        private string Username;
        private string Sex;
  
        public FrmFaceRecognition()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtEnterFaceId.Text == "")
            {
                MessageBox.Show("Please enter the Face Id to Recognize");
            }
            else
            {
                if (verifyFaceId(Convert.ToInt32(txtEnterFaceId.Text)))
                {
                    timer1.Enabled = true;
                    btnUpload.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Fail to Recognize user. No such user with this face id stored!!!", "Recognition Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
        private bool verifyFaceId(int faceId)
        {
            bool foundMatchId = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblUser where FaceId = " + faceId + "";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    foundMatchId = true;
                    while (dr.Read())
                    {
                        FaceId = dr["FaceId"].ToString();
                        Username = dr["Username"].ToString();
                        Sex = dr["Sex"].ToString();                        
                    }
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Face Detection and Recognition App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatchId;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if(progressBar1.Value == 5)
                lblStatus.Text = "Loading the test face.......";
            else if (progressBar1.Value == 10)
            {
                //upload picture to picture box into picture box1 and picture box2 
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Face Db\\Test Face\\" + Username + txtEnterFaceId.Text + ".jpg");
                lblStatus.Text = "Test face loaded successfully........";
            }
            else if (progressBar1.Value == 20)
            {
                lblStatus.Text = "Detecting Face of the current Test Face........";
            }
            else if (progressBar1.Value == 25)
            {
                lblStatus.Text = "Test Face Detected Successfully........";
            }
            else if (progressBar1.Value == 30)
            {
                lblStatus.Text = "Extracting Features from the Detected Test Face........";
            }
            else if (progressBar1.Value == 40)
            {
                lblStatus.Text = "Training the extracted Features........";
            }
            else if (progressBar1.Value == 50)
            {
                lblStatus.Text = "Loading the Trained Face Database........";
            }
            else if (progressBar1.Value == 60)
            {
                lblStatus.Text = "Matching the Trained Face with all trained faces in the database........";
            }
            else if (progressBar1.Value == 85)
            {
                lblStatus.Text = "Matched Found Successfully!!!!";
            }
            else if (progressBar1.Value == 95)
            {
                lblStatus.Text = "Loading Matched Trained Face........";
            }
            else if (progressBar1.Value == 100)
            {
                lblStatus.Text = "Face Recognition Completed Successfully!!!";
                string picture = Application.StartupPath + "\\Face Db\\Trained Face\\" + txtEnterFaceId.Text + ".jpg";
                Bitmap uploadImage = new Bitmap(picture);
                pictureBox2.Image = resizeImage(uploadImage, 162, 162);
                //pictureBox1.Image = uploadImage;
                pictureBox2.Size = pictureBox1.Image.Size;
                txtFaceId.Text = FaceId;
                txtUsername.Text = Username;
                txtSex.Text = Sex;
                timer1.Enabled = false;
                //to display the result of face recognition operation 
                MessageBox.Show("User with this Face Id Matched and Recognized!!!", "Recognition result", MessageBoxButtons.OK, MessageBoxIcon.Information);                                       
            }            
        }

        private void FrmFaceRecognition_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterFaceId.ResetText();
            txtFaceId.ResetText();
            txtSex.ResetText();
            txtUsername.ResetText();
            lblStatus.ResetText();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            progressBar1.Value = 0;
            btnUpload.Enabled = true;
        }
        
    }
}
