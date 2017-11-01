using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FailurePredictionArtificialLiftSystem
{
    public partial class FrmWellReport : Form
    {
        public FrmWellReport()
        {
            InitializeComponent();
        }

        private void FrmWellReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbArtificialLiftDataSet1.tblWellReg' table. You can move, or remove it, as needed.
            this.tblWellRegTableAdapter.Fill(this.dbArtificialLiftDataSet1.tblWellReg);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
