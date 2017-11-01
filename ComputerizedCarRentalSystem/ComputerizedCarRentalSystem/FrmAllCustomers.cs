using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCarRentalSystem
{
    public partial class FrmAllCustomers : Form
    {
        public FrmAllCustomers()
        {
            InitializeComponent();
        }

        private void FrmAllCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter = new OleDbDataAdapter("select CustomerId, CustomerName, CustomerPhoneNumber, CustomerGender, CustomerAddress, NextOfKinName, NextOfKinPhone from tblCustomer", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "TblCustomer");
                CrystalReportAllCustomers rpt = new CrystalReportAllCustomers();
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
