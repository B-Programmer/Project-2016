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


namespace SeniorCitizenICTDatabase
{
    public partial class FrmGeneralReport : Form
    {
        
        public FrmGeneralReport()
        {
            InitializeComponent();
        }

        private void FrmGeneralReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbCitizen.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\SeniorCitizenICTDatabase\SeniorCitizenICTDatabase\dbCitizen.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select UniqueCitizenId, CitizenFullname, Gender, DateOfBirth, PhoneNumber, StateOfOrigin, LGAOfOrigin from tblSeniorCitizen", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "GeneralReport");
                CrystalReportGeneral rpt = new CrystalReportGeneral();
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
