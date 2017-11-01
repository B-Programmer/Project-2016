using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using Accord.Imaging.Filters;
using AForge.Vision;



namespace SampleFaceApplication
{
    public partial class FrmFaceDetection : Form
    {
        private Capture webcamVideo;
        private Emgu.CV.HaarCascade faceDetection;
        private HaarObjectDetector detector; 
        private Accord.Vision.Detection.HaarCascade cascade;
               
        public FrmFaceDetection()
        {
            try
            {
                InitializeComponent();
                webcamVideo = new Capture();
                //faceDetection = new HaarCascade(Application.StartupPath + "\\haarcascade_frontalface_default.xml");
                faceDetection = new Emgu.CV.HaarCascade("haarcascade_frontalface_default.xml");
                cascade = new FaceHaarCascade();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Face Detection and Recognition Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFaceDetection_Load(object sender, EventArgs e)
        {
            button3.Text = "&Stop";            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (Image<Bgr, byte> Frame = webcamVideo.QueryFrame().Resize(397, 292, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC))
                {
                    if (Frame != null)
                    {
                        Image<Gray, byte> grayFrame = Frame.Convert<Gray, byte>();
                        //var faces = grayFrame.DetectHaarCascade(faceDetection, 1.1, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20)new Size(Frame.Width / 8, Frame.Height / 8))[0];
                        var faces = grayFrame.DetectHaarCascade(faceDetection, 1.1, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20))[0];
                        foreach (var face in faces)
                        {
                            Frame.Draw(face.rect, new Bgr(Color.Red), 3);
                            Bitmap c = Frame.ToBitmap();
                            Bitmap bmp = new Bitmap(face.rect.Width, face.rect.Height);
                            Graphics g = Graphics.FromImage(bmp);
                            g.DrawImage(c, 0, 0, face.rect, GraphicsUnit.Pixel);
                            pictureBox2.Image = bmp;
                            bmp.Save("myface" + DateTime.Now.Second.ToString());
                            label1.Text = "Operation Completed!!! " + faces.Length.ToString() + " Face detected";
                            timer1.Enabled = false;
                            button3.Text = "&Play Again";
                        }
                        
                        pictureBox1.Image = Frame.ToBitmap();
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Face Detection and Recognition Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                detector = new HaarObjectDetector(cascade, 30);
                detector.SearchMode = ObjectDetectorSearchMode.Single;//.Default;//.NoOverlap;//
                detector.ScalingFactor = 2.5f;
                detector.ScalingMode = ObjectDetectorScalingMode.SmallerToGreater;//.GreaterToSmaller;
                detector.UseParallelProcessing = true;
                detector.Suppression = 3;

                Bitmap picture = new Bitmap(pictureBox2.Image);
                Image<Bgr, byte> Frame = new Image<Bgr, byte>(picture);

                Stopwatch sw = Stopwatch.StartNew();

                Rectangle[] faceObjects = detector.ProcessFrame(picture);

                sw.Stop();

                if (faceObjects.Length > 0)
                {
                    RectanglesMarker marker = new RectanglesMarker(faceObjects, Color.Fuchsia);
                    pictureBox2.Image = marker.Apply(picture);
                }
                label1.Text = "Operation Completed!!! " + faceObjects.Length.ToString() + " Face detected";

                Graphics g = Graphics.FromImage(pictureBox2.Image);
                foreach (var face in faceObjects)
                {
                    g.DrawRectangle(Pens.DeepSkyBlue, face);
                    Frame.Draw(face, new Bgr(Color.Red), 3);
                    Bitmap c = Frame.ToBitmap();
                    Bitmap bmp = new Bitmap(face.Width, face.Height);
                    Graphics gg = Graphics.FromImage(bmp);
                    gg.DrawImage(c, 0, 0, face, GraphicsUnit.Pixel);
                    //pictureBox2.Image = bmp;
                    bmp.Save("myface(accord) " + DateTime.Now.Second.ToString());
                    MessageBox.Show("Face Detected!!!, Face Save as:" + "myface(accord) " + DateTime.Now.Second.ToString(), "Face Detection Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                //g.Dispose()
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message,"Face Detection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
              pictureBox2.Image = pictureBox1.Image;
             //Bitmap uploadImage = new Bitmap(pictureBox1.Image);
             //pictureBox2.Image = resizeImage(uploadImage, 300, 300);
             //pictureBox2.Size = pictureBox2.Image.Size;
            //pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\test.jpg");
           // pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Lucky.jpg");
        }

        private static Image resizeImage(Image image, int imgWidth, int imgHeight)
        {
            Bitmap newImage = new Bitmap(imgWidth, imgHeight);
            Graphics g = Graphics.FromImage((Image)newImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.DrawImage(image, 0, 0, imgWidth, imgHeight);
            return newImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "&Stop")
            {
                timer1.Enabled = false;
                button3.Text = "&Play Again";
            }
            else if (button3.Text == "&Play Again")
            {
                timer1.Enabled = true;
                button3.Text = "&Stop";
            }
        }
    }
}
