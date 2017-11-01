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
    public partial class FrmMonthlyBudgetReport : Form
    {
        public FrmMonthlyBudgetReport()
        {
            InitializeComponent();
        }

        private void FrmMonthlyBudgetReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Budget_Month, Monthly_Year, Building_Monthly_Income, Land_Monthly_Income, Furniture_Monthly_Income, Vehicle_Monthly_Income, Total_Monthly_Income, Total_Monthly_Expenditure, Monthly_Net_Income from tblMonthlyBudget", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "MonthlyBudget");
                CrystalReportMonthlyReport rpt = new CrystalReportMonthlyReport();
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
