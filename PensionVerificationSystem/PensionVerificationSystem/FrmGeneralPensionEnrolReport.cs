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
    public partial class FrmGeneralPensionEnrolReport : Form
    {
        
        public FrmGeneralPensionEnrolReport()
        {
            InitializeComponent();
        }

        private void FrmGeneralPensionEnrolReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select UniquePensionerId, PensionerFullName, DateOfBirth, PensionerGender, SalaryStructure, CurrentMonthlyPension, Ministry, NextOfKinName, NextOfKinPhoneNumber from tblPensionerEnrollment", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblPensionerEnrolment");
                CrystalReportPensionEnrolment rpt = new CrystalReportPensionEnrolment();
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
