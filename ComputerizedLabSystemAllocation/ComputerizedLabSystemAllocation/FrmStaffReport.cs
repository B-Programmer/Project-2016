using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedLabSystemAllocation
{
    public partial class FrmStaffReport : Form
    {
        public FrmStaffReport()
        {
            InitializeComponent();
        }

        private void FrmStaffReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStaffRegDataSet.tblStaffReg' table. You can move, or remove it, as needed.
            this.tblStaffRegTableAdapter.Fill(this.dbStaffRegDataSet.tblStaffReg);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
