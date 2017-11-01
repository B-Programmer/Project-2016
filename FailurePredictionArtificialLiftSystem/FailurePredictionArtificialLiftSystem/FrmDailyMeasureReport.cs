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
    public partial class FrmDailyMeasureReport : Form
    {
        public FrmDailyMeasureReport()
        {
            InitializeComponent();
        }

        private void FrmDailyMeasureReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbArtificialLiftDataSet3.tblDailyMeasure' table. You can move, or remove it, as needed.
            this.tblDailyMeasureTableAdapter.Fill(this.dbArtificialLiftDataSet3.tblDailyMeasure);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
