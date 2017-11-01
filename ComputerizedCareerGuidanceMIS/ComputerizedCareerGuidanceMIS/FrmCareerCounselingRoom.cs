using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCareerGuidanceMIS
{
    public partial class FrmCareerCounselingRoom : Form
    {
        string userName;
        string userType;
        public FrmCareerCounselingRoom(string uName, string uType)
        {
            InitializeComponent();
            userName = uName;
            userType = uType;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FrmStudentDetails frmStudentDetails = new FrmStudentDetails(userName, userType);
                frmStudentDetails.Show();
                this.Hide();
            }
        }
    }
}
