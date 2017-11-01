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
    public partial class FrmSystemAllocation : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbSystemLab.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedLabSystemAllocation\ComputerizedLabSystemAllocation\dbSystemLab.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private bool nonNumberEntered = false;
        private string picture;

        public FrmSystemAllocation()
        {
            InitializeComponent();
        }

        private void FrmSystemAllocation_Load(object sender, EventArgs e)
        {
            int i;
            for(i = 1; i <= 500; i++) cboSystemType.Items.Add("System " + i.ToString());
            cmd.Connection = cn;
            refresh();
        }

        private void refresh()
        {
            //cboUserType.ResetText();
            cboUserID.Items.Clear(); cboUserID.Text = "";
            txtUserName.Clear(); txtUserName.ReadOnly = false;
            cboUserSchool.ResetText(); cboUserSchool.Enabled = true;
            cboUserDepartment.ResetText(); cboUserDepartment.Enabled = true;
            cboUserSemester.ResetText();
            cboUserSession.ResetText();
            cboSystemType.ResetText();
            dtpAllocationDate.ResetText();
            txtTimeSlot.Text = "00";
            //txtTimein.Text = DateTime.Now.ToShortTimeString(); MessageBox.Show(DateTime.Now.ToShortTimeString());
            dtpTimein.Text = DateTime.Now.ToShortTimeString();
            txtTimeout.Text = DateTime.Now.ToShortTimeString();
            chkPrinting.Checked = false;
            chkScanning.Checked = false;
            chkPhotocopy.Checked = false;
            txtAmountCharge.Text = "0.00";
            cboUserGender.ResetText(); cboUserGender.Enabled = true;
            cboProgrammeOfStudy.ResetText(); cboProgrammeOfStudy.Enabled = true;
            picture = "";
            pictureBox1.Image = null;
        }
        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
            if (cboUserType.Text == "Student")
            {
                label6.Text = "Student Matric No:";
                label7.Text = "Student Name:";
                loadStudentMatricNo();
            }
            else if (cboUserType.Text == "Staff")
            {
                label6.Text = "Staff ID:";
                label7.Text = "Staff Name:";
                loadStaffID();
            }
            
        }

        private void loadStudentMatricNo()
        {
            try
            {
                cboUserID.Items.Clear();
                cn.Open();
                cmd.CommandText = "select Student_Matric_No from tblStudentReg";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboUserID.Items.Add((dr["Student_Matric_No"]).ToString());
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadStaffID()
        {
            try
            {
                cboUserID.Items.Clear();
                cn.Open();
                cmd.CommandText = "select Staff_ID from tblStaffReg";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboUserID.Items.Add((dr["Staff_ID"]).ToString());
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cboUserType.Text == "Student") && (cboUserID.Text != ""))
            {
                loadStudentDetails(cboUserID.Text);
                if (File.Exists(picture))
                {
                    Bitmap uploadImage = new Bitmap(picture);
                    pictureBox1.Image = uploadImage;
                    pictureBox1.Size = pictureBox1.Image.Size;

                }
            }
            else if ((cboUserType.Text == "Staff") && (cboUserID.Text != ""))
            {
                loadStaffDetails(cboUserID.Text);
            }
        }

        private void loadStudentDetails(string uID)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select Student_Name, Student_Sex, Student_School, Student_Department, Programme_Of_Study from tblStudentReg Where Student_Matric_No = '" + uID + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtUserName.Text = dr["Student_Name"].ToString(); txtUserName.ReadOnly = true;
                    cboUserSchool.Text = dr["Student_School"].ToString(); cboUserSchool.Enabled = false;
                    cboUserDepartment.Text = dr["Student_Department"].ToString(); cboUserDepartment.Enabled = false;
                    cboUserGender.Text = dr["Student_Sex"].ToString(); cboUserGender.Enabled = false;
                    cboProgrammeOfStudy.Text = dr["Programme_Of_Study"].ToString(); cboProgrammeOfStudy.Enabled = false;
                    //upload picture to picture box
                    picture = Application.StartupPath + "\\Pictures\\" + uID.Replace("/", "_") + ".jpg";
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadStaffDetails(string user)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select Staff_Name, Staff_Sex, Staff_School, Staff_Department from tblStaffReg where Staff_ID = '" + user + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtUserName.Text = dr["Staff_Name"].ToString(); txtUserName.ReadOnly = true;
                    cboUserSchool.Text = dr["Staff_School"].ToString(); cboUserSchool.Enabled = false;
                    cboUserDepartment.Text = dr["Staff_Department"].ToString(); cboUserDepartment.Enabled = false;
                    cboUserGender.Text = dr["Staff_Sex"].ToString(); cboUserGender.Enabled = false;
                    picture = "";
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void txtTimeSlot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((dtpTimein.Text != "") && (txtTimeSlot.Text != ""))
                {
                    //MessageBox.Show(txtTimein.Text);
                    //DateTime timein = DateTime.ParseExact(dtpAllocationDate.Value.ToShortDateString() + " " + txtTimein.Text.ToString(), "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                    //string timeIn = txtTimein.Text;
                    //DateTime timein = Convert.ToDateTime(timeIn);
                    DateTime timein = dtpTimein.Value;
                    txtTimeout.Text = timein.AddMinutes(Convert.ToDouble(txtTimeSlot.Text)).ToString("hh:mm:ss tt");
                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtpTimein_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((dtpTimein.Text != "") && (txtTimeSlot.Text != ""))
                {
                    DateTime timein = dtpTimein.Value;
                    txtTimeout.Text = timein.AddMinutes(Convert.ToDouble(txtTimeSlot.Text)).ToString("hh:mm:ss tt");
                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string UserType = cboUserType.Text;
                    string UserID = cboUserID.Text;
                    string UserName = txtUserName.Text;
                    string UserGender = cboUserGender.Text;
                    string ProgrammeOfStudy = cboProgrammeOfStudy.Text;
                    string UserSchool = cboUserSchool.Text;
                    string UserDepartment = cboUserDepartment.Text;
                    string UserSemester = cboUserSemester.Text;
                    string UserSession = cboUserSession.Text;
                    string SystemType = cboSystemType.Text;
                    string AllocationDate = dtpAllocationDate.Text;
                    int TimeSlot = Convert.ToInt16(txtTimeSlot.Text);
                    string Timein = dtpTimein.Text;
                    string Timeout = txtTimeout.Text;
                    string otherServices = "";
                    if (chkPrinting.Checked) otherServices = otherServices + "Printing, ";
                    if (chkPhotocopy.Checked) otherServices = otherServices + "Photocopy, ";
                    if (chkScanning.Checked) otherServices = otherServices + "Scanning.";
                    double AmountCharges = Convert.ToDouble(txtAmountCharge.Text);
                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblSystemAllocation values('" + UserType + "','" + UserID + "','" + UserName + "','" + UserGender + "','" + UserSchool + "','" + UserDepartment + "','" + UserSemester + "','" + UserSession + "','" + SystemType + "','" + AllocationDate + "'," + TimeSlot + ",'" + Timein + "','" + Timeout + "','" + otherServices + "'," + AmountCharges + ",'" + ProgrammeOfStudy + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New System Allocation Details Successfully Saved!!!", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        Refresh();
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

            if ((cboUserType.Text == ""))
            {
                MessageBox.Show("Please type the User Type", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserType.Focus();
                return isEntryFilled;
            }
            else if ((cboUserID.Text == ""))
            {
                MessageBox.Show("Please type the Staff ID or Student Matric No", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserID.Focus();
                return isEntryFilled;
            }
            else if ((txtUserName.Text == ""))
            {
                MessageBox.Show("Please type the User Name", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return isEntryFilled;
            }
            else if ((cboUserGender.Text == ""))
            {
                MessageBox.Show("Please type the User Gender", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserGender.Focus();
                return isEntryFilled;
            }
            else if ((cboUserSchool.Text == ""))
            {
                MessageBox.Show("Please set the School/Faculty", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserSchool.Focus();
                return isEntryFilled;
            }
            else if ((cboUserDepartment.Text == ""))
            {
                MessageBox.Show("Please set the Department", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserDepartment.Focus();
                return isEntryFilled;
            }
            else if ((cboUserSession.Text == ""))
            {
                MessageBox.Show("Please type the Session ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserSession.Focus();
                return isEntryFilled;
            }
            else if ((cboUserSemester.Text == ""))
            {
                MessageBox.Show("Please type the Semester ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserSemester.Focus();
                return isEntryFilled;
            }
            else if ((cboSystemType.Text == ""))
            {
                MessageBox.Show("Please type the System Type ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSystemType.Focus();
                return isEntryFilled;
            }
            else if ((txtTimeSlot.Text == ""))
            {
                MessageBox.Show("Please type the Time Slot ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimeSlot.Focus();
                return isEntryFilled;
            }
            else if ((txtTimeout.Text == ""))
            {
                MessageBox.Show("Please type the Timeout ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimeout.Focus();
                return isEntryFilled;
            }
            else
                return true;
        }
        
        private void txtAmountCharge_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.OemPeriod))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtAmountCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtAmountCharge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
