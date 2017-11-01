using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PensionVerificationSystem
{
    public partial class FrmUserLogin : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text != "") && (txtPassword.Text != ""))
            {
                if (isValidateUser(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Username and password validated successfully!!!", "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MDIPensionVerification mdiPension = new MDIPensionVerification();
                    mdiPension.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User name or password validation failed, please type correct username or password", "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User name or password cannot be emptied, please type username or password", "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValidateUser(string user, string pass)
        {
            bool validate = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select Username, Password from tblUser where Username = '" + user + "' and Password = '" + pass + "'";
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
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validate;
        }

        private void FrmUserLogin_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }
    }
}
