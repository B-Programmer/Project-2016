using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCarRentalSystem
{
    public partial class FrmChangeCustomerPassword : Form
    {
        private string UserId;
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmChangeCustomerPassword(string user)
        {
            InitializeComponent();
            UserId = user;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if ((isAllEntryFilled()) && (isRegistered(txtUsername.Text)))
                {
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;

                    /*cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE tblUser set Password = @Password  WHERE [Username] = @Username and [ID] = @Id";
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Id", id);
                    UPDATE tblUser SET  [Password] = 'admin' WHERE (Username = 'Administrator') AND (ID = 1)
                     */
                    cmd.CommandText = "UPDATE tblCustomer SET CustomerPassword = '" + Password + "' WHERE (CustomerId = '" + Username + "')";
                    cmd.Connection = cn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer's Password has been successfully Changed!!!", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtUsername.Text == ""))
            {
                MessageBox.Show("Please enter the username", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return isEntryFilled;
            }
            else if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Please enter the User Password", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return isEntryFilled;
            }
            else if ((txtConfirmPassword.Text == ""))
            {
                MessageBox.Show("Please enter the user confirm password", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Focus();
                return isEntryFilled;
            }
            else if ((txtPassword.Text != txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password mismatch. Please retype either password or confirm password", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }

        private bool isRegistered(string user)
        {
            bool isUserRegistered = true;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblCustomer where CustomerId ='" + user + "'";
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Fail to change password!!! Customer ID not exist. No user found ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isUserRegistered = false;
                }
                /* else
                 {
                     dr.Read();
                     id = Convert.ToInt16(dr["ID"].ToString());
                 }*/
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserRegistered;

        }

        private void FrmChangeCustomerPassword_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            txtUsername.Text = UserId;
            txtUsername.Enabled = false;
        }
    }
}
