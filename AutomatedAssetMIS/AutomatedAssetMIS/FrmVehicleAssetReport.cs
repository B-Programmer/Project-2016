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
    public partial class FrmVehicleAssetReport : Form
    {
        public FrmVehicleAssetReport()
        {
            InitializeComponent();
        }

        private void FrmVehicleAssetReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Vehicle_Type, Vehicle_Model, Vehicle_Brand, Vehicle_Model_Type, Vehicle_Mode, Vehicle_Cost, Vehicle_Agent_Name, Vehicle_Agent_Phone from tblVehicle", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Vehicle");
                CrystalReportVehicle rpt = new CrystalReportVehicle();
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
