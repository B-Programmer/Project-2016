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
    public partial class FrmStudentReports : Form
    {
        public FrmStudentReports()
        {
            InitializeComponent();
        }

        private void FrmStudentReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentRegReportDataSet1.tblStudentReg' table. You can move, or remove it, as needed.
            this.tblStudentRegTableAdapter1.Fill(this.dbStudentRegReportDataSet1.tblStudentReg);
            // TODO: This line of code loads data into the 'dbStudentRegDataSet.tblStudentReg' table. You can move, or remove it, as needed.
            this.tblStudentRegTableAdapter.Fill(this.dbStudentRegDataSet.tblStudentReg);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
