using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace PensionVerificationSystem
{
    public partial class FrmMonthlyVerificationReport : Form
    {
        private string verificationMonth;
        private string verificationYear;
        public FrmMonthlyVerificationReport(string vMonth, string vYear)
        {
            InitializeComponent();
            verificationMonth = vMonth;
            verificationYear = vYear;
        }

        private void FrmMonthlyVerificationReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select PensionerId, PensionerFullname, CurrentMonthlyPension, VerificationMonth, VerificationYear, BankName, AccountNumber, VerificationStatus from tblMonthlyVerification where (VerificationMonth = '" + verificationMonth + "') and (VerificationYear = '" + verificationYear + "')", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblMonthlyVerification");
                CrystalReportMonthlyVerification rpt = new CrystalReportMonthlyVerification();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
