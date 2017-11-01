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
    public partial class FrmPumpReport : Form
    {
        public FrmPumpReport()
        {
            InitializeComponent();
        }

        private void FrmPumpReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbArtificialLiftDataSet2.tblPumpReg' table. You can move, or remove it, as needed.
            this.tblPumpRegTableAdapter.Fill(this.dbArtificialLiftDataSet2.tblPumpReg);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
