using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SampleFaceApplication
{
    public partial class FrmSampleFace : Form
    {
        string picture = "";
        public FrmSampleFace()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (optPicture.Checked)
            {
                MessageBox.Show("Always ensure that upload the recent passport of the present user");
                OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.InitialDirectory = @"C:\Project 2016\SampleFaceApplication\SampleFaceApplication\Passport";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Bitmap uploadImage = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = resizeImage(uploadImage, 162, 162);
                    pictureBox1.Size = pictureBox1.Image.Size;
                    picture = openFileDialog.FileName;
                    MessageBox.Show(picture);
                }
            }
            else if (optCamera.Checked)
            {

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
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (picture != "")
            {
                if (File.Exists(Application.StartupPath + "\\Pictures\\0002.jpg"))
                {
                    MessageBox.Show("Picture Cannot be Saved!!!, Duplicate Found", "Filename Already Exists");
                }
                else
                {
                    pictureBox1.Image.Save(Application.StartupPath + "\\Pictures\\0002.jpg");
                    MessageBox.Show("Picture Saved!!!");
                }
            }
        }

        private void btnVerify1_Click(object sender, EventArgs e)
        {
            bool foundMatch = false;
            if (pictureBox1.Image  != null)
            {
                string[] imgFiles = Directory.GetFiles(Application.StartupPath + "\\Pictures", "*.jpg");
                foreach (var imgFile in imgFiles)
                {
                    //Image  bmp = null;
                    Bitmap uploadImage = null;
                    try
                    {
                        MessageBox.Show("Picture:" + imgFile);
                        uploadImage = new Bitmap(imgFile);
                       // bmp = resizeImage(uploadImage, 162, 162);
                        if (imageCompare((Bitmap)pictureBox1.Image, uploadImage))
                        {
                            MessageBox.Show("Picture Verified!!!");
                            foundMatch = true;
                            break;
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                if(!foundMatch) MessageBox.Show("No Match Picture Found!!!");
            }
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
        //This imageCompareString() method compares two images by first saving the images into the memory and 
        //then convert them a base 64 string for comparison. this method is faster than the pixel method but not reliable 
        private bool imageCompareString(Bitmap firstImage, Bitmap secondImage)
        {
            MemoryStream ms = new MemoryStream();
            firstImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            string firstBitmap = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;

            secondImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            string secondBitmap = Convert.ToBase64String(ms.ToArray());

            if (firstBitmap.Equals(secondBitmap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
