using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedLabSystemAllocation
{
    public partial class FrmStaffRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbSystemLab.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedLabSystemAllocation\ComputerizedLabSystemAllocation\dbSystemLab.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();

        public FrmStaffRegistration()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmStaffRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            cboStaffSchool.Items.Clear();
            cboStaffSchool.Items.Add("Business and Management Studies");
            cboStaffSchool.Items.Add("Engineering Technology");
            cboStaffSchool.Items.Add("Environmental Science");
            cboStaffSchool.Items.Add("General Studies");
            cboStaffSchool.Items.Add("Communication and Information Technology");
            cboStaffSchool.Items.Add("Applied Science");
            cboStaffSchool.Text = "Applied Science";
            txtStaffID.Focus();
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string StaffID = txtStaffID.Text;
                    string StaffName = txtStaffName.Text;
                    string StaffSex = cboStaffSex.Text;
                    string StaffSchool = cboStaffSchool.Text;
                    string StaffDepartment = cboStaffDepartment.Text;

                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblStaffReg values('" + StaffID + "','" + StaffName + "','" + StaffSex + "','" + StaffSchool + "','" + StaffDepartment + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Staff Registration Details Successfully Saved!!!", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
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

            if ((txtStaffID.Text == ""))
            {
                MessageBox.Show("Please type the Staff ID", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaffID.Focus();
                return isEntryFilled;
            }
            else if ((txtStaffName.Text == ""))
            {
                MessageBox.Show("Please type the Staff Name", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaffName.Focus();
                return isEntryFilled;
            }
            else if ((cboStaffSex.Text == ""))
            {
                MessageBox.Show("Please set the Staff Sex", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStaffSex.Focus();
                return isEntryFilled;
            }
            else if ((cboStaffSchool.Text == ""))
            {
                MessageBox.Show("Please set the Staff School/Faculty", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStaffSchool.Focus();
                return isEntryFilled;
            }
            else if ((cboStaffDepartment.Text == ""))
            {
                MessageBox.Show("Please type the Staff Department ", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStaffDepartment.Focus();
                return isEntryFilled;
            }
            else
                return true;
        }

        private void btnRefresh()
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            cboStaffSex.ResetText();
            cboStaffSchool.ResetText();
            cboStaffDepartment.ResetText();
            txtStaffID.Focus();
        }

        private void cboStaffSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStaffDepartment.Items.Clear();
            if (cboStaffSchool.Text == "Business and Management Studies")
            {
                cboStaffDepartment.Items.Add("Business Administration");
                cboStaffDepartment.Items.Add("Accountancy");
                cboStaffDepartment.Items.Add("Marketing");
                cboStaffDepartment.Items.Add("Insurance");
                cboStaffDepartment.Items.Add("Banking and Finance");
            }
            else if (cboStaffSchool.Text == "Engineering Technology")
            {
                cboStaffDepartment.Items.Add("Civil Engineering Technology");
                cboStaffDepartment.Items.Add("Electrical Electronic Engineering Technology");
                cboStaffDepartment.Items.Add("Mechanical Engineering Technology");
                cboStaffDepartment.Items.Add("Computer Engineering Technology");
            }
            else if (cboStaffSchool.Text == "Environmental Science")
            {
                cboStaffDepartment.Items.Add("Building Technology");
                cboStaffDepartment.Items.Add("Architectural Technology");
                cboStaffDepartment.Items.Add("Urban and Regional Planning");
                cboStaffDepartment.Items.Add("Estate Management");
                cboStaffDepartment.Items.Add("Surveying and Geo-Informatics");
                cboStaffDepartment.Items.Add("Quantity Surveying");
            }
            else if (cboStaffSchool.Text == "General Studies")
            {
                cboStaffDepartment.Items.Add("Humanities and Social Studies");
                cboStaffDepartment.Items.Add("Languages");
            }
            else if (cboStaffSchool.Text == "Communication and Information Technology")
            {
                cboStaffDepartment.Items.Add("Library and Information Science");
                cboStaffDepartment.Items.Add("Mass Communication");
                cboStaffDepartment.Items.Add("Office Technology Management");
            }
            else if (cboStaffSchool.Text == "Applied Science")
            {
                cboStaffDepartment.Items.Add("Computer Science");
                cboStaffDepartment.Items.Add("Mathematics and Statistics");
                cboStaffDepartment.Items.Add("Food Technology");
                cboStaffDepartment.Items.Add("Science Laboratory Technology");
                cboStaffDepartment.Items.Add("Hotel Management and Hospitality");
            }
            
        }       
        
    }
}
