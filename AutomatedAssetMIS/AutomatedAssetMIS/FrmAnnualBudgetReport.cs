using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace AutomatedAssetMIS
{
    public partial class FrmAnnualBudgetReport : Form
    {
        public FrmAnnualBudgetReport()
        {
            InitializeComponent();
        }

        private void FrmAnnualBudgetReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Budget_Year, Building_Annual_Income, Land_Annual_Income, Furniture_Annual_Income, Vehicle_Annual_Income, Total_Annual_Income, Total_Annual_Expenditure, Annual_Net_Income from tblAnnualBudget", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "AnnualBudget");
                CrystalReportAnnualBudget rpt = new CrystalReportAnnualBudget();
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
