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
    public partial class FrmLandAssetReport : Form
    {
        public FrmLandAssetReport()
        {
            InitializeComponent();
        }

        private void FrmLandAssetReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Land_Owner_Name, Land_Owner_Phone, Land_Location, Land_Width, Land_Length, Land_Sale_Rentage, Land_Agent_Name, Land_Agent_Phone from tblLand", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Land");
                CrystalReportLand rpt = new CrystalReportLand();
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
