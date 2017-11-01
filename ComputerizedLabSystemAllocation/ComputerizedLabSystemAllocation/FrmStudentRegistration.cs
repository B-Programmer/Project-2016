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

namespace ComputerizedLabSystemAllocation
{
    public partial class FrmStudentRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbSystemLab.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedLabSystemAllocation\ComputerizedLabSystemAllocation\dbSystemLab.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private string picture;

        public FrmStudentRegistration()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmStudentRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            cboStudentSchool.Items.Clear();
            cboStudentSchool.Items.Add("Business and Management Studies");
            cboStudentSchool.Items.Add("Engineering Technology");
            cboStudentSchool.Items.Add("Environmental Science");
            cboStudentSchool.Items.Add("General Studies");
            cboStudentSchool.Items.Add("Communication and Information Technology");
            cboStudentSchool.Items.Add("Applied Science");
            cboStudentSchool.Text = "Applied Science";
            txtStudentMatricNo.Focus();
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string StudentMatricNo = txtStudentMatricNo.Text;
                    string StudentName = txtStudentName.Text;
                    string StudentSex = cboStudentSex.Text;
                    string StudentLevel = cboStudentLevel.Text;
                    string StudentSchool = cboStudentSchool.Text;
                    string StudentDepartment = cboStudentDepartment.Text;
                    string ProgrammeOfStudy = cboProgrammeOfStudy.Text;
                    
                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblStudentReg values('" + StudentMatricNo + "','" + StudentName + "','" + StudentSex + "','" + StudentLevel + "','" + StudentSchool + "','" + StudentDepartment + "','" + ProgrammeOfStudy + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Student Registration Details Successfully Saved!!!", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        SavePicture();//then save picture
                        btnRefresh();
                    }
                    
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtStudentMatricNo.Text == ""))
            {
                MessageBox.Show("Please type the Student Matric No", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStudentMatricNo.Focus();
                return isEntryFilled;
            }
            else if ((txtStudentName.Text == ""))
            {
                MessageBox.Show("Please type the Student Name", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStudentName.Focus();
                return isEntryFilled;
            }
            else if ((cboStudentSex.Text == ""))
            {
                MessageBox.Show("Please set the Student Sex", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStudentSex.Focus();
                return isEntryFilled;
            }
            else if ((cboStudentLevel.Text == ""))
            {
                MessageBox.Show("Please set the Student Level", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStudentLevel.Focus();
                return isEntryFilled;
            }
            else if ((cboStudentSchool.Text == ""))
            {
                MessageBox.Show("Please set the Student School/Faculty", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStudentSchool.Focus();
                return isEntryFilled;
            }
            else if ((cboStudentDepartment.Text == ""))
            {
                MessageBox.Show("Please type the Student Department ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStudentDepartment.Focus();
                return isEntryFilled;
            }
            else if ((cboProgrammeOfStudy.Text == ""))
            {
                MessageBox.Show("Please type the Student Programme of Study ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProgrammeOfStudy.Focus();
                return isEntryFilled;
            }    
            else
                return true;
        }
        
        private void SavePicture()
        {
            //bool isSaved = false;
            if ((picture != "") && (pictureBox1.Image != null))
            {
                if (txtStudentMatricNo.Text != "")
                {
                    string pictureFileName = txtStudentMatricNo.Text.Replace("/", "_");
                    if (File.Exists(Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg"))
                    {
                        MessageBox.Show("Picture Cannot be Saved!!!, Duplicate Found", "Filename Already Exists");
                    }
                    else
                    {
                        pictureBox1.Image.Save(Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg");
                        MessageBox.Show("Picture Saved!!!");
                        picture = Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg";
                       // isSaved = true;
                    }
                }
            }
            //return isSaved;
        }

        private void btnRefresh()
        {
            txtStudentMatricNo.Clear();
            txtStudentName.Clear();
            cboStudentSex.ResetText();
            cboStudentLevel.ResetText();
            cboStudentSchool.ResetText();
            cboStudentDepartment.ResetText();
            cboProgrammeOfStudy.ResetText();
            txtStudentMatricNo.Focus();
            picture = "";
            pictureBox1.Image = null;
        }

        private void cboStudentSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStudentDepartment.Items.Clear();
            if (cboStudentSchool.Text == "Business and Management Studies")
            {
                cboStudentDepartment.Items.Add("Business Administration");
                cboStudentDepartment.Items.Add("Accountancy");
                cboStudentDepartment.Items.Add("Marketing");
                cboStudentDepartment.Items.Add("Insurance");
                cboStudentDepartment.Items.Add("Banking and Finance");
            }
            else if (cboStudentSchool.Text == "Engineering Technology")
            {
                cboStudentDepartment.Items.Add("Civil Engineering Technology");
                cboStudentDepartment.Items.Add("Electrical Electronic Engineering Technology");
                cboStudentDepartment.Items.Add("Mechanical Engineering Technology");
                cboStudentDepartment.Items.Add("Computer Engineering Technology");
            }
            else if (cboStudentSchool.Text == "Environmental Science")
            {
                cboStudentDepartment.Items.Add("Building Technology");
                cboStudentDepartment.Items.Add("Architectural Technology");
                cboStudentDepartment.Items.Add("Urban and Regional Planning");
                cboStudentDepartment.Items.Add("Estate Management");
                cboStudentDepartment.Items.Add("Surveying and Geo-Informatics");
                cboStudentDepartment.Items.Add("Quantity Surveying");
            }
            else if (cboStudentSchool.Text == "General Studies")
            {
                cboStudentDepartment.Items.Add("Humanities and Social Studies");
                cboStudentDepartment.Items.Add("Languages");
            }
            else if (cboStudentSchool.Text == "Communication and Information Technology")
            {
                cboStudentDepartment.Items.Add("Library and Information Science");
                cboStudentDepartment.Items.Add("Mass Communication");
                cboStudentDepartment.Items.Add("Office Technology Management");
            }
            else if (cboStudentSchool.Text == "Applied Science")
            {
                cboStudentDepartment.Items.Add("Computer Science");
                cboStudentDepartment.Items.Add("Mathematics and Statistics");
                cboStudentDepartment.Items.Add("Food Technology");
                cboStudentDepartment.Items.Add("Science Laboratory Technology");
                cboStudentDepartment.Items.Add("Hotel Management and Hospitality");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Always ensure that upload the recent passport of the present student");
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
    }
}
