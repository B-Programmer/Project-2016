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
    public partial class FrmEditStaffReg : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbSystemLab.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedLabSystemAllocation\ComputerizedLabSystemAllocation\dbSystemLab.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
  
        public FrmEditStaffReg()
        {
            InitializeComponent();
        }

        private void FrmEditStaffReg_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            loadStaffID();
            cboStaffSchool.Items.Clear();
            cboStaffSchool.Items.Add("Business and Management Studies");
            cboStaffSchool.Items.Add("Engineering Technology");
            cboStaffSchool.Items.Add("Environmental Science");
            cboStaffSchool.Items.Add("General Studies");
            cboStaffSchool.Items.Add("Communication and Information Technology");
            cboStaffSchool.Items.Add("Applied Science");
            //cboStaffSchool.Text = "Applied Science";
            btnRefresh();
            cboEditStaffID.Visible = true;
            txtEditStaffID.Visible = false;
            label5.Text = "Select Staff ID:";
            cboEditStaffID.Focus();
        }

        private void loadStaffID()
        {
            try
            {
                cboEditStaffID.Items.Clear();
                cn.Open();
                cmd.CommandText = "select Staff_ID from tblStaffReg";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboEditStaffID.Items.Add((dr["Staff_ID"]).ToString());
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

        private void btnRefresh()
        {
            txtStaffID.Clear(); txtStaffID.ReadOnly = true;
            txtStaffName.Clear(); txtStaffName.ReadOnly = true;
            cboStaffSex.ResetText(); cboStaffSex.Enabled = false;
            cboStaffSchool.ResetText(); cboStaffSchool.Enabled = false;
            cboStaffDepartment.ResetText(); cboStaffDepartment.Enabled = false;            
            CmdNext.Enabled = false;            
        }

        private void cboEditStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRefresh();
            if ((cboEditStaffID.Text != " "))
            {
                loadStaffDetails(cboEditStaffID.Text);
            }

        }

        private void loadStaffDetails(string uID)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblStaffReg Where Staff_ID = '" + uID + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtStaffID.Text = dr["Staff_ID"].ToString();
                    txtStaffName.Text = dr["Staff_Name"].ToString();
                    cboStaffSex.Text = dr["Staff_Sex"].ToString();
                    cboStaffSchool.Text = dr["Staff_School"].ToString();
                    cboStaffDepartment.Text = dr["Staff_Department"].ToString();
                    disableRefresh();
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

        private void loadStaffDetails1(string uID)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblStaffReg Where Staff_ID = '" + uID + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtStaffID.Text = dr["Staff_ID"].ToString();
                    txtStaffName.Text = dr["Staff_Name"].ToString();
                    cboStaffSex.Text = dr["Staff_Sex"].ToString();
                    cboStaffSchool.Text = dr["Staff_School"].ToString();
                    cboStaffDepartment.Text = dr["Staff_Department"].ToString();
                    disableRefresh();
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

        private void disableRefresh()
        {
            txtStaffID.ReadOnly = false;
            txtStaffName.ReadOnly = false;
            cboStaffSex.Enabled = true;
            cboStaffSchool.Enabled = true;
            cboStaffDepartment.Enabled = true;
            CmdNext.Enabled = true;
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
                        cmd.CommandText = "UPDATE tblStaffReg SET Staff_ID = '" + StaffID + "', Staff_Name ='" + StaffName + "', Staff_Sex ='" + StaffSex + "', Staff_School ='" + StaffSchool + "', Staff_Department = '" + StaffDepartment + "' WHERE (Staff_ID ='" + cboEditStaffID.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff Registration Details Successfully Updated!!!", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        loadStaffID(); //reload staff ID
                        btnRefresh(); //refresh all entry points
                        cboEditStaffID.Text = ""; txtEditStaffID.Text = ""; //Clear Text
                        if (optSelect.Checked == true) cboEditStaffID.Focus(); //Set Focus for another staff update
                        if (optType.Checked == true) txtEditStaffID.Focus();//Set Focus for another staff update
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

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void optSelect_CheckedChanged(object sender, EventArgs e)
        {
            btnRefresh();
            if (optSelect.Checked == true)
            {
                cboEditStaffID.Visible = true;
                txtEditStaffID.Visible = false;
                label5.Text = "Select Staff ID:";
            }
        }

        private void optType_CheckedChanged(object sender, EventArgs e)
        {
            btnRefresh();
            if (optType.Checked == true)
            {
                cboEditStaffID.Visible = false;
                txtEditStaffID.Visible = true;
                label5.Text = "Type Staff ID:";
            }
        }

        private void txtEditStaffID_TextChanged(object sender, EventArgs e)
        {
            btnRefresh();
            if ((txtEditStaffID.Text != ""))
            {
                loadStaffDetails1(txtEditStaffID.Text);
            }
        }

    }
}
