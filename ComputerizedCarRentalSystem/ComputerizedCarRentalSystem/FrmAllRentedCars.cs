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
    public partial class FrmAllRentedCars : Form
    {
        private string userType;
        private string userName;
        public FrmAllRentedCars(string uType, string uName)
        {
            InitializeComponent();
            userType = uType;
            userName = uName;
        }

        private void FrmAllRentedCars_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
                //OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
                OleDbDataAdapter adapter;
                DataSet ds = new DataSet();
                if (userType == "Customer")
                {
                    adapter = new OleDbDataAdapter("select a.CarRegId, a.CustomerId, b.CarType, b.CarModel, a.TotalCarRentageCost, a.BookingDate, a.DueDate from tblBooking a, tblCar b WHERE (a.CarRegId = b.CarRegId) AND (a.BookingStatus = 1) AND (a.CustomerId = '"+ userName +"')", cn);
                    adapter.Fill(ds, "TblRentedCar");
                }
                else
                {
                    adapter = new OleDbDataAdapter("select a.CarRegId, a.CustomerId, b.CarType, b.CarModel, a.TotalCarRentageCost, a.BookingDate, a.DueDate from tblBooking a, tblCar b WHERE (a.CarRegId = b.CarRegId) AND (a.BookingStatus = 1)", cn);
                    adapter.Fill(ds, "TblRentedCar");
                }
                CrystalReportAllRentedCars rpt = new CrystalReportAllRentedCars();
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
