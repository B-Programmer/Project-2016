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

namespace ComputerizedCarRentalSystem
{
    public partial class FrmCustomerRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmCustomerRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmCustomerRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            txtCustomerId.Text = genCustomerId();
            txtCustomerId.Enabled = false;

        }

        private string genCustomerId()
        {
            string CustomerId = "CAR/CUST/";
            try
            {
                int rowCount = 0;
                cn.Open();
                cmd.CommandText = "select count(*) as RowCount from tblCustomer";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    rowCount = (int)(dr["RowCount"]);
                rowCount++;
                if (rowCount < 10)
                {
                    CustomerId = CustomerId + "000" + rowCount;
                }
                else if (rowCount < 100)
                {
                    CustomerId = CustomerId + "00" + rowCount;
                }
                else if (rowCount < 1000)
                {
                    CustomerId = CustomerId + "0" + rowCount;
                }
                else if (rowCount < 10000)
                {
                    CustomerId = CustomerId + rowCount;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return CustomerId;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string CustomerId = txtCustomerId.Text;
                    string CustomerName = txtCustomerFullname.Text;
                    string CustomerPhoneNumber = txtPhoneNumber.Text;
                    string CustomerGender = cboCustomerGender.Text;
                    string CustomerAddress = txtCustomerAddress.Text;
                    string CustomerEmailAddress = txtEmailAddress.Text;
                    string CustomerPassword = txtPassword.Text;
                    string NextOfKinName = txtNextOfKinName.Text;
                    string NextOfKinPhone = txtNextOfKinPhone.Text;
                    int BookingStatus = 0;
                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblCustomer values('" + CustomerId + "','" + CustomerName + "','" + CustomerPhoneNumber + "','" + CustomerGender + "','" + CustomerAddress + "','" + CustomerEmailAddress + "','" + CustomerPassword + "','" + NextOfKinName + "','" + NextOfKinPhone + "'," + BookingStatus + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Customer Registration Details successfully saved!!!", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        //go back to home page
                    }
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

            if ((txtCustomerId.Text == "CAR/CUST/"))
            {
                MessageBox.Show("Please click refresh button to regenerate customer registration id", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerFullname.Focus();
                return isEntryFilled;
            }
            else if ((txtCustomerFullname.Text == ""))
            {
                MessageBox.Show("Please enter the Customer Fullname", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerFullname.Focus();
                return isEntryFilled;
            }
            else if ((txtPhoneNumber.Text == ""))
            {
                MessageBox.Show("Please enter the customer phone number", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhoneNumber.Focus();
                return isEntryFilled;
            }
            else if ((cboCustomerGender.Text == ""))
            {
                MessageBox.Show("Please set the Customer Gender", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCustomerGender.Focus();
                return isEntryFilled;
            }
            else if ((txtCustomerAddress.Text == ""))
            {
                MessageBox.Show("Please enter the Customer Address", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerAddress.Focus();
                return isEntryFilled;
            }
            else if ((txtEmailAddress.Text == ""))
            {
                MessageBox.Show("Please type the Email Address ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmailAddress.Focus();
                return isEntryFilled;
            }
            else if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Please type the Customer Password ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return isEntryFilled;
            }
            else if ((txtNextOfKinName.Text == ""))
            {
                MessageBox.Show("Please type the Customer Next Of Kin Name ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNextOfKinName.Focus();
                return isEntryFilled;
            }
            else if ((txtNextOfKinPhone.Text == ""))
            {
                MessageBox.Show("Please type the Customer Next Of Kin Phone ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNextOfKinPhone.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }


    }
}
