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
    public partial class FrmBuildingAssetReport : Form
    {
        public FrmBuildingAssetReport()
        {
            InitializeComponent();
        }

        private void FrmBuildingAssetReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Building_Name, Building_Type, Room_Number, Building_Owner_Name, Building_Agent_Name, Building_Agent_Phone, Building_Sale_Rentage from tblBuilding", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Building");
                CrystalReportBuilding rpt = new CrystalReportBuilding();
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
