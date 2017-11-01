using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeniorCitizenICTDatabase
{
    public partial class FrmSearchCitizenResult : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbCitizen.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\SeniorCitizenICTDatabase\SeniorCitizenICTDatabase\dbCitizen.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        string picture = "";
        private string uniqueCitizenId;

        public FrmSearchCitizenResult(string citizenId)
        {
            InitializeComponent();
            uniqueCitizenId = citizenId;
        }
        private void FrmSearchCitizenResult_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            genCitizenInfor();
            txtUniqueCitizenId.Enabled = false;
            btnDelete.Visible = false;
        }
        private void genCitizenInfor()
        {
            //string citizenId = "SCW/OS/";
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblSeniorCitizen where UniqueCitizenId ='" + uniqueCitizenId +"'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtUniqueCitizenId.Text = dr["UniqueCitizenId"].ToString();
                    txtCitizenFullname.Text = dr["CitizenFullname"].ToString();
                    cboGender.Text = dr["Gender"].ToString();
                    dtpDateOfBirth.Text = dr["DateOfBirth"].ToString();
                    txtResidentialAddress.Text = dr["ResidentialAddress"].ToString();
                    txtPhoneNumber.Text = dr["PhoneNumber"].ToString();
                    cboStateOfOrigin.Text = dr["StateOfOrigin"].ToString();
                    txtLGAOfOrigin.Text = dr["LGAOfOrigin"].ToString();
                    txtNationality.Text = dr["Nationality"].ToString();
                    txtReligion.Text = dr["Religion"].ToString();
                    if(dr["OccupationType"].ToString() == "Government Worker")
                        optGovernmentWorker.Checked = true;
                    else
                        optNonGovernmentWorker.Checked = true;
                    txtGovOrganizationName.Text = dr["GovOrganizationName"].ToString();
                    txtGovOrganizationAddress.Text = dr["GovOrganizationAddress"].ToString();
                    txtGovMinistry.Text = dr["GovMinistry"].ToString();
                    cboGovLGA.Text = dr["GovLGA"].ToString();
                    cboGovGradeLevel.Text = dr["GovGradeLevel"].ToString();
                    txtGovOccupation.Text = dr["GovOccupation"].ToString();
                    txtNonGovOrganizationName.Text = dr["NonGovOrganizationName"].ToString();
                    txtNonGovOrganizationAddress.Text = dr["NonGovOrganizationAddress"].ToString();
                    cboNonGovLGA.Text = dr["NonGovLGA"].ToString();
                    txtNonGovOccupation.Text = dr["NonGovOccupation"].ToString();
                    //upload picture to picture box
                    picture = Application.StartupPath + "\\Pictures\\" + getLastFourString(uniqueCitizenId) + ".jpg";
                    Bitmap uploadImage = new Bitmap(picture);
                    //pictureBox1.Image = resizeImage(uploadImage, 162, 162);
                    pictureBox1.Image = uploadImage;
                    pictureBox1.Size = pictureBox1.Image.Size;
                    
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Senior Citizen's App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private string getLastFourString(string txtCitizenId)
        {
            string lastFourString = txtCitizenId.Substring(7, 4);
            MessageBox.Show(lastFourString);
            return lastFourString;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to upload the recent passport of the current senior citizen", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Always ensure that you upload the recent passport of the currrent senior citizen");
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

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                string occupationType = "";
                if (isAllEntryFilled())
                {
                    string UniqueCitizenId = txtUniqueCitizenId.Text;
                    string CitizenFullname = txtCitizenFullname.Text;
                    string Gender = cboGender.Text;
                    string DateOfBirth = dtpDateOfBirth.Text;
                    string ResidentialAddress = txtResidentialAddress.Text;
                    string PhoneNumber = txtPhoneNumber.Text;
                    string StateOfOrigin = cboStateOfOrigin.Text;
                    string LGAOfOrigin = txtLGAOfOrigin.Text;
                    string Nationality = txtNationality.Text;
                    string Religion = txtReligion.Text;
                    if (optGovernmentWorker.Checked)
                        occupationType = "Government Worker";
                    else if (optNonGovernmentWorker.Checked)
                        occupationType = "Non-Government Worker";
                    string GovOrganizationName = txtGovOrganizationName.Text;
                    string GovOrganizationAddress = txtGovOrganizationAddress.Text;
                    string GovMinistry = txtGovMinistry.Text;
                    string GovLGA = cboGovLGA.Text;
                    string GovGradeLevel = cboGovGradeLevel.Text;
                    string GovOccupation = txtGovOccupation.Text;
                    string NonGovOrganizationName = txtNonGovOrganizationName.Text;
                    string NonGovOrganizationAddress = txtNonGovOrganizationAddress.Text;
                    string NonGovLGA = cboNonGovLGA.Text;
                    string NonGovOccupation = txtNonGovOccupation.Text;

                    if (isSavePicture())
                    {
                        cn.Open();
                        if (occupationType == "Government Worker")
                            //cmd.CommandText = "UPDATE tblSeniorCitizen set UniqueCitizenId = '" + UniqueCitizenId + "', CitizenFullname ='" + CitizenFullname + "', Gender ='" + Gender + "', DateOfBirth ='" + DateOfBirth + "', ResidentialAddress ='" + ResidentialAddress + "', PhoneNumber ='" + PhoneNumber + "', StateOfOrigin ='" + StateOfOrigin + "', LGAOfOrigin ='" + LGAOfOrigin + "', Nationality ='" + Nationality + "', Religion ='" + Religion + "', OccupationType ='" + occupationType + "', GovOrganizationName ='" + GovOrganizationName + "', GovOrganizationAddress ='" + GovOrganizationAddress + "', GovMinistry ='" + GovMinistry + "', GovLGA ='" + GovLGA + "', GovGradeLevel ='" + GovGradeLevel + "', GovOccupation ='" + GovOccupation + "', NonGovOrganizationName =' ', NonGovOrganizationAddress =' ', NonGovLGA =' ', NonGovOccupation =' ', Passport ='" + picture + "' Where (UniqueCitizenId = '" + UniqueCitizenId + "') And (occupationType = 'Government Worker')";
                            cmd.CommandText = "UPDATE tblSeniorCitizen set [CitizenFullname] ='" + CitizenFullname + "', [Gender] ='" + Gender + "', [DateOfBirth] ='" + DateOfBirth + "', [ResidentialAddress] ='" + ResidentialAddress + "', [PhoneNumber] ='" + PhoneNumber + "', [StateOfOrigin] ='" + StateOfOrigin + "', [LGAOfOrigin] ='" + LGAOfOrigin + "', [Nationality] ='" + Nationality + "', [Religion] ='" + Religion + "', [OccupationType] ='" + occupationType + "', [GovOrganizationName] ='" + GovOrganizationName + "', [GovOrganizationAddress] ='" + GovOrganizationAddress + "', [GovMinistry] ='" + GovMinistry + "', [GovLGA] ='" + GovLGA + "', [GovGradeLevel] ='" + GovGradeLevel + "', [GovOccupation] ='" + GovOccupation + "', Passport ='" + picture + "' Where (UniqueCitizenId = '" + UniqueCitizenId + "') And (occupationType = 'Government Worker')";
                        else if (occupationType == "Non-Government Worker")
                            cmd.CommandText = "UPDATE tblSeniorCitizen set CitizenFullname ='" + CitizenFullname + "', Gender ='" + Gender + "', DateOfBirth ='" + DateOfBirth + "', ResidentialAddress ='" + ResidentialAddress + "', PhoneNumber ='" + PhoneNumber + "', StateOfOrigin ='" + StateOfOrigin + "', LGAOfOrigin ='" + LGAOfOrigin + "', Nationality ='" + Nationality + "', Religion ='" + Religion + "', OccupationType ='" + occupationType + "', NonGovOrganizationName ='" + NonGovOrganizationName + "', NonGovOrganizationAddress ='" + NonGovOrganizationAddress + "', NonGovLGA ='" + NonGovLGA + "', NonGovOccupation ='" + NonGovOccupation + "', Passport ='" + picture + "' Where (UniqueCitizenId = '" + UniqueCitizenId + "') And (occupationType = 'Non-Government Worker')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Current Senior Citizen Information successfully updated!!!", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        this.Hide();
                    }
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Senior Citizen App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtUniqueCitizenId.Text == "SCW/OS/"))
            {
                MessageBox.Show("Please click refresh button to regenerate the senior citizen's id", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCitizenFullname.Focus();
                return isEntryFilled;
            }
            else if ((txtCitizenFullname.Text == ""))
            {
                MessageBox.Show("Please enter the Senior Citizen's FullName", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCitizenFullname.Focus();
                return isEntryFilled;
            }
            else if ((dtpDateOfBirth.Text == ""))
            {
                MessageBox.Show("Please set the Senior Citizen's Date of Birth", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDateOfBirth.Focus();
                return isEntryFilled;
            }
            else if ((cboGender.Text == ""))
            {
                MessageBox.Show("Please set the Senior Citizen's Gender", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboGender.Focus();
                return isEntryFilled;
            }
            else if ((txtResidentialAddress.Text == ""))
            {
                MessageBox.Show("Please type the Senior Citizen's Residential Address ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResidentialAddress.Focus();
                return isEntryFilled;
            }
            else if ((txtPhoneNumber.Text == ""))
            {
                MessageBox.Show("Please type the Senior Citizen's Phone Number ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhoneNumber.Focus();
                return isEntryFilled;
            }
            else if ((cboStateOfOrigin.Text == ""))
            {
                MessageBox.Show("Please set the Senior Citizen's State of Origin ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStateOfOrigin.Focus();
                return isEntryFilled;
            }
            else if ((txtLGAOfOrigin.Text == ""))
            {
                MessageBox.Show("Please type the Senior Citizen's LGA of Origin ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLGAOfOrigin.Focus();
                return isEntryFilled;
            }
            else if ((txtNationality.Text == ""))
            {
                MessageBox.Show("Please type the Senior Citizen's Nationality ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNationality.Focus();
                return isEntryFilled;
            }
            else if ((picture == "") || (pictureBox1.Image == null))
            {
                MessageBox.Show("Please upload the Senior Citizen's recent passport", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return isEntryFilled;
            }
            else if (optGovernmentWorker.Checked)
            {
                if ((txtGovOrganizationName.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Organization Name ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtGovOrganizationName.Focus();
                    return isEntryFilled;
                }
                else if ((txtGovOrganizationAddress.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Organization Address ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtGovOrganizationAddress.Focus();
                    return isEntryFilled;
                }
                else if ((txtGovMinistry.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen s Ministry/Department", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtGovMinistry.Focus();
                    return isEntryFilled;
                }
                else if ((cboGovLGA.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's LGA(Osun) ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboGovLGA.Focus();
                    return isEntryFilled;
                }
                else if ((cboGovGradeLevel.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Grade level ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboGovGradeLevel.Focus();
                    return isEntryFilled;
                }
                else if ((txtGovOccupation.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Occupation ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtGovOccupation.Focus();
                    return isEntryFilled;
                }
                else
                    return true;
            }
            else if (optNonGovernmentWorker.Checked)
            {
                if ((txtNonGovOrganizationName.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Organization Name ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNonGovOrganizationName.Focus();
                    return isEntryFilled;
                }
                else if ((txtNonGovOrganizationAddress.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Organization Address ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNonGovOrganizationAddress.Focus();
                    return isEntryFilled;
                }
                else if ((cboNonGovLGA.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's LGA(Osun) ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboNonGovLGA.Focus();
                    return isEntryFilled;
                }
                else if ((txtNonGovOccupation.Text == ""))
                {
                    MessageBox.Show("Please type the Senior Citizen's Occupation ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNonGovOccupation.Focus();
                    return isEntryFilled;
                }
                else
                    return true;
            }
            else
                return true;

        }
        private bool isSavePicture()
        {
            bool isSaved = false;
            if ((picture != "") && (pictureBox1.Image != null))
            {
                if (txtUniqueCitizenId.Text != "SCW/OS/")
                {
                    string pictureFileName = getLastFourString(txtUniqueCitizenId.Text);
                    //if (File.Exists(Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg"))
                    {
                       // MessageBox.Show("Picture Cannot be Saved!!!, Duplicate Found", "Filename Already Exists");
                        
                    }
                    //else
                    {
                        //pictureBox1.Image.Save(Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg");
                        MessageBox.Show("Picture Saved!!!");
                        //picture = Application.StartupPath + "\\Pictures\\" + pictureFileName + ".jpg";
                        isSaved = true;
                    }
                }
            }
            return isSaved;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete all the information of the current senior citizen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd.CommandText = "DELETE from tblSeniorCitizen Where (UniqueCitizenId = '" + txtUniqueCitizenId.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Current Senior Citizen Information successfully Deleted!!!", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Delete Picture                    
                    //File.Delete(Application.StartupPath + "\\Pictures\\" + getLastFourString(txtUniqueCitizenId.Text) + ".jpg");
                    //MessageBox.Show("Picture Deleted!!!");
                    cn.Close();
                    this.Hide();
                }
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Senior Citizen's App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void optGovernmentWorker_CheckedChanged(object sender, EventArgs e)
        {
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = false;
            }
        }

        private void optNonGovernmentWorker_CheckedChanged(object sender, EventArgs e)
        {
            {
                groupBox4.Enabled = false;
                groupBox5.Enabled = true;
            }
        }

        private void txtUniqueCitizenId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
