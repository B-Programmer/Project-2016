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
    public partial class FrmHomePage : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUserType.Text == "Administrator")
            {
                label1.Text = "Admin Username:";
                label2.Text = "Admin Password:";
                linkLabel1.Visible = false;
            }
            else if (cboUserType.Text == "Customer")
            {
                label1.Text = "Customer Id:";
                label2.Text = "Customer Password:";
                linkLabel1.Visible = true;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCustomerRegistration frmCustomerReg = new FrmCustomerRegistration();
            frmCustomerReg.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text != "") && (txtPassword.Text != ""))
            {
                if (isValidateUser(txtUsername.Text, txtPassword.Text, cboUserType.Text))
                {
                    MessageBox.Show("Username and password validated successfully!!!", "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MDICarRental mdiCarRental = new MDICarRental(cboUserType.Text, txtUsername.Text);
                    mdiCarRental.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password validation failed, please type correct username or password", "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User name or password cannot be emptied, please type username or password", "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValidateUser(string user, string pass, string userType)
        {
            bool validate = false;
            try
            {
                cn.Open();
                if (userType == "Administrator")
                {
                    cmd.CommandText = "select Username, Password from tblAdminUser where Username = '" + user + "' and Password = '" + pass + "'";
                }
                else if (userType == "Customer")
                {
                    cmd.CommandText = "select CustomerId, CustomerPassword from tblCustomer where CustomerId = '" + user + "' and CustomerPassword = '" + pass + "'";
                }
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    validate = true;
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
            return validate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            linkLabel1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMarquee.Left = lblMarquee.Left - 120;
            if (lblMarquee.Left <= -795) lblMarquee.Left = 906;
        }

    }
}
