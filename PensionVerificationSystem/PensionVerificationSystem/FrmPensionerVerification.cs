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

namespace PensionVerificationSystem
{
    public partial class FrmPensionerVerification : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        string picture = "";
        public FrmPensionerVerification()
        {
            InitializeComponent();
            this.Height = 179;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Always ensure that upload the recent passport of the present pensioner", "Verification");
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
        private bool verifyPensionerId(string pensionerId)
        {
            bool foundMatchId = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblMonthlyVerification where PensionerId = '" + pensionerId + "'";
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
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatchId;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtUniquePensionerId.Text == "")
            {
                MessageBox.Show("Please enter the unique pensioner id to verify");
            }
           // else if (pictureBox1.Image == null)
            //{
             //   MessageBox.Show("Please upload the pensioner recent passport to verify");
            //} 
            else if ((txtUniquePensionerId.Text != "")) //(pictureBox1.Image != null) && (txtUniquePensionerId.Text != "")
            {
                if (verifyPensionerId(txtUniquePensionerId.Text))
                {
                    //string pictureFileName = getLastFourString(txtUniquePensionerId.Text);
                    //check if the picture with this filename as pensioner id exists
                    /*if (File.Exists(Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg"))
                    {
                        //to verify the picture found with the filename as the pensioner id with uploaded picture
                        string imgFile = Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg";
                        Bitmap uploadImage = new Bitmap(imgFile);
                        // bmp = resizeImage(uploadImage, 162, 162);
                        if (imageCompare((Bitmap)pictureBox1.Image, uploadImage))
                        {
                            MessageBox.Show("Pensioner's Id and Picture matched for this pensioner!!!", "Verification result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //create instance of frmPensionMonthlyVerification
                          */
                            FrmPensionMonthlyVerification frmPensionMonthlyVerification = new FrmPensionMonthlyVerification(txtUniquePensionerId.Text);
                            frmPensionMonthlyVerification.Show();
                            this.Hide();
                    /*}
                    else
                    {
                        MessageBox.Show("Pensioner id with the picture do not match!!!", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
                    }*/
                    /*}
                    else
                    {
                        MessageBox.Show("Pensioner id with the picture do not match!!!", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }*/
                }
                else
                {
                    MessageBox.Show("No pensioner payment information stored for this Pensioner id !!!", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }                
            }
        }
        private string getLastFourString(string txtPensionerId)
        {
            string lastFourString = txtPensionerId.Substring(8, 4);
            MessageBox.Show(lastFourString);
            return lastFourString;
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

        private void FrmPensionerVerification_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            
        }

    }
}
