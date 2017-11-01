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
    public partial class FrmMonthlyVerification : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        public FrmMonthlyVerification()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboVerificationMonth.Text != "" && cboVerificationYear.Text != "")
                {
                    cn.Open();
                    cmd.CommandText = "select * from tblMonthlyVerification where (VerificationMonth ='" + cboVerificationMonth.Text + "') AND (VerificationYear = '" + cboVerificationYear.Text + "')";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        FrmMonthlyVerificationReport frmMVReport = new FrmMonthlyVerificationReport(cboVerificationMonth.Text, cboVerificationYear.Text);
                        frmMVReport.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("There is no monthly verification report for pensioners during this month: " + cboVerificationMonth.Text + " in the year: " + cboVerificationYear.Text, "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                    dr.Close();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Please specify the month and year you want to view the verification report ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMonthlyVerification_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }
    }
}
