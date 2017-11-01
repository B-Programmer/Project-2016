using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeniorCitizenICTDatabase
{
    public partial class FrmCreateUser : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbCitizen.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\SeniorCitizenICTDatabase\SeniorCitizenICTDatabase\dbCitizen.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmCreateUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmCreateUser_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if ((isAllEntryFilled()) && (!isRegistered(txtUsername.Text)))
                {
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;
                    string UserType = cboUserType.Text;

                    cn.Open();
                    cmd.CommandText = "insert into tblUser values('" + Username + "','" + Password + "','" + UserType + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Authorized User has been successfully Created!!!", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtUsername.Text == ""))
            {
                MessageBox.Show("Please enter the username", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return isEntryFilled;
            }
            else if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Please enter the User Password", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return isEntryFilled;
            }
            else if ((txtConfirmPassword.Text == ""))
            {
                MessageBox.Show("Please enter the user confirm password", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Focus();
                return isEntryFilled;
            }
            else if ((cboUserType.Text == ""))
            {
                MessageBox.Show("Please set the user type ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserType.Focus();
                return isEntryFilled;
            }
            else if ((txtPassword.Text != txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password mismatch. Please retype either password or confirm password", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }

        private bool isRegistered(string user)
        {
            bool isUserRegistered = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblUser where Username ='" + user + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Fail to create user, username already exists. Duplicate user found ", "Senior Citizens App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isUserRegistered = true;
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
            return isUserRegistered;

        }

        
    }
}
