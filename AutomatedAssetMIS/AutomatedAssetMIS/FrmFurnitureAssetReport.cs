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
    public partial class FrmFurnitureAssetReport : Form
    {
        public FrmFurnitureAssetReport()
        {
            InitializeComponent();
        }

        private void FrmFurnitureAssetReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Manufacturer_Name, Manufacturer_Phone, Furniture_Type, Furniture_Name, Furniture_Cost, Furniture_Agent_Name, Furniture_Agent_Phone from tblFurniture", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Furniture");
                CrystalReportFurniture rpt = new CrystalReportFurniture();
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
