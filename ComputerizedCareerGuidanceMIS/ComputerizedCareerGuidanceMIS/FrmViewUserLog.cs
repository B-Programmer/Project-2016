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
    public partial class FrmViewUserLog : Form
    {
        public FrmViewUserLog()
        {
            InitializeComponent();
        }

        private void FrmViewUserLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerDbDataSet1.TblUserLog' table. You can move, or remove it, as needed.
            this.tblUserLogTableAdapter.Fill(this.careerDbDataSet1.TblUserLog);

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
