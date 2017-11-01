using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedAssetMIS
{
    public partial class FrmUserLogin : Form
    {
        private FrmSplash frmSplash;
        public FrmUserLogin(FrmSplash splash)
        {
            InitializeComponent();
            frmSplash = splash;
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
                    MessageBox.Show("Username and password validated successfully!!!", "Automated Asset MIS App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MDIAsset mdiAsset = new MDIAsset();
                    mdiAsset.Show();
                    this.Hide();
                    frmSplash.Hide();
                }
                else
                {
                    MessageBox.Show("User name or password validation failed, please type correct username or password", "Automated Asset MIS App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User name or password cannot be emptied, please type username or password", "Automated Asset MIS App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool isValidateUser(string user, string pass)
        {
            bool validate = false;
            try
            {
                
                if (user.ToLower() == "admin" && pass.ToLower() == "asset")
                {
                    validate = true;
                }

            }
            catch (Exception Er)
            {

                MessageBox.Show(Er.Message, "Automated Asset MIS App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validate;
        }
    }
}
