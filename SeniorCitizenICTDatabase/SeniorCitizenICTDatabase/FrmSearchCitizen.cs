using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SeniorCitizenICTDatabase
{
    public partial class FrmSearchCitizen : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbCitizen.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\SeniorCitizenICTDatabase\SeniorCitizenICTDatabase\dbCitizen.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        string picture = "";
        public FrmSearchCitizen()
        {
            InitializeComponent();
        }

        private void FrmSearchCitizen_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Always ensure that upload the recent passport of the present senior Citizen", "Upload Picture");
                OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Bitmap uploadImage = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = resizeImage(uploadImage, 162, 162);
                    pictureBox1.Size = pictureBox1.Image.Size;
                    picture = openFileDialog.FileName;
                    //MessageBox.Show(picture);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
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
        private bool verifyCitizenId(string citizenId)
        {
            bool foundMatchId = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblSeniorCitizen where UniqueCitizenId = '" + citizenId + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    foundMatchId = true;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Senior Citizens App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatchId;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (optSearchByCitizenId.Checked)   //Search by using Citizen Id
            {
                if (txtUniqueCitizenId.Text == "")
                {
                    MessageBox.Show("Please enter the unique senior citizen id to verify");
                }
                else
                {
                    if(verifyCitizenId(txtUniqueCitizenId.Text))
                    {
                        //to display the result of search operation 
                        MessageBox.Show("Senior Citizen's Id Verified and Validated!!!", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmSearchCitizenResult frmSearchResult = new FrmSearchCitizenResult(txtUniqueCitizenId.Text);
                        frmSearchResult.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No Senior Citizen information stored for this Citizen's id !!!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (optSearchByCitizenBiometricId.Checked)     //Search by using Citizen Biometric Id
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Please upload the current senior citizen's recent passport to verify", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((pictureBox1.Image != null))
                {

                    bool foundMatch = false;
                        string[] imgFiles = Directory.GetFiles(Application.StartupPath + "\\Pictures", "*.jpg");
                        foreach (var imgFile in imgFiles)
                        {
                            //Image  bmp = null;
                            Bitmap uploadImage = null;
                            try
                            {
                                //MessageBox.Show("Picture:" + imgFile);
                                uploadImage = new Bitmap(imgFile);
                                // bmp = resizeImage(uploadImage, 162, 162);
                                if (imageCompare((Bitmap)pictureBox1.Image, uploadImage))
                                {
                                    MessageBox.Show("Picture Verified!!! Biometric (Face) Id matched for this senior citizen ", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    foundMatch = true;
                                    string citizenId = "SCW/OS/" + getLastFourIDString((string)imgFile);
                                    //break;
                                    FrmSearchCitizenResult frmSearchResult = new FrmSearchCitizenResult(citizenId);
                                    frmSearchResult.Show();
                                    this.Hide();
                                }
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show(er.Message);
                            }
                        }
                        if (!foundMatch) MessageBox.Show("No Match Picture Found for this Senior Citizen!!!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                        
                }
            }
        }
        private string getLastFourString(string txtPensionerId)
        {
            string lastFourString = txtPensionerId.Substring(7, 4);
            MessageBox.Show(lastFourString);
            return lastFourString;
        }
        private string getLastFourIDString(string pictureId)
        {
            string lastFourIDString = pictureId.Substring(pictureId.LastIndexOf("\\")+1, 4);
            MessageBox.Show(lastFourIDString);
            return lastFourIDString;
        }
        //This imageCompare() method compares two images on a pixel-by-pixel basis and return false if there is any mismatch
        private bool imageCompare(Bitmap firstImage, Bitmap secondImage)
        {
            bool flag = true;
            string firstPixel;
            string secondPixel;

            if ((firstImage.Width == secondImage.Width) && (firstImage.Height == secondImage.Height))
            {
                for (int i = 0; i < firstImage.Width; i++)
                {
                    for (int j = 0; j < firstImage.Height; j++)
                    {
                        firstPixel = firstImage.GetPixel(i, j).ToString();
                        secondPixel = secondImage.GetPixel(i, j).ToString();
                        if (firstPixel != secondPixel)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void optSearchByCitizenId_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void optSearchByCitizenBiometricId_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

       
    }
}
