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


namespace MySampleCrystalReport
{
    public partial class FrmCrystalReport : Form
    {
        public FrmCrystalReport()
        {
            InitializeComponent();
        }

        private void FrmCrystalReport_Load(object sender, EventArgs e)
        {
            try
            {
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\cooperative.accdb;Persist Security Info=True");
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\MySampleCrystalReport\MySampleCrystalReport\cooperative.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select Reg_Date, staff_id, fullname, Phone_Number, Department from tblCustomerData", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "DataTable1");
                CrystalReport1 rpt = new CrystalReport1();
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
