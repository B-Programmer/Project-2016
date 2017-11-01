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
    public partial class FrmViewAllUsers : Form
    {
        public FrmViewAllUsers()
        {
            InitializeComponent();
        }

        private void FrmViewAllUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerDbDataSet.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.careerDbDataSet.TblUser);

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
