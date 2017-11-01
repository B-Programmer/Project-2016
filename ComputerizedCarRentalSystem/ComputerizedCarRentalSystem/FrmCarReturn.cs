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
    public partial class FrmCarReturn : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private string UserId;

        public FrmCarReturn(string user)
        {
            InitializeComponent();
            UserId = user;
        }
        private void FrmCarReturn_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            clearAllText();
            populateRentedCarRegistrationId();
            
        }
        private void clearAllText()
        {
            //cboCarRegId.ResetText();
            txtCarType.ResetText(); txtCarType.Enabled = false;
            txtCarModel.ResetText(); txtCarModel.Enabled = false;
            txtCarMaker.ResetText(); txtCarMaker.Enabled = false;
            txtCarColor.ResetText(); txtCarColor.Enabled = false;
            txtCarRentageCost.ResetText(); txtCarRentageCost.Enabled = false;
            txtCarPlateNumber.ResetText(); txtCarPlateNumber.Enabled = false;
            txtCarRentageDate.ResetText(); txtCarRentageDate.Enabled = false;
            txtCarDueDate.ResetText(); txtCarDueDate.Enabled = false;
            txtCustomerId.ResetText(); txtCustomerId.Enabled = false;
            btnReturn.Enabled = false;
        }
        private void populateRentedCarRegistrationId()
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select CarRegId from tblBooking Where (BookingStatus = 1) AND (CustomerId = '" + UserId + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboCarRegId.Items.Add((dr["CarRegId"]).ToString()); //populate the car reg id rented by this present customer
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                
                {
                    string CarRegId = cboCarRegId.Text;
                    string ReturnDate = DateTime.Now.ToString(); ;
                    int BookingStatus = 0;
                    int CustomerBookingStatus = GetCustomerBookingStatus(UserId);
                    {
                        cn.Open();
                        cmd.CommandText = "update tblBooking set BookingStatus = " + BookingStatus + ", ReturnDate = '"+ ReturnDate +"' where (BookingStatus = 1) And (CarRegId = '" + CarRegId + "') And (CustomerId ='" + UserId + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "update tblCar set CarStatus = 'Available!' where (CarRegId = '" + CarRegId + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "update tblCustomer set BookingStatus = " + CustomerBookingStatus + " where (CustomerId = '" + UserId + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("This Car has been successfully Returned!!!", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        this.Hide();
                    }
                }
                
            }
            catch (Exception Er)
            {
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCustomerBookingStatus(string user)
        {
            int bookingStatus = 0;
            try
            {
                cn.Open();
                cmd.CommandText = "select BookingStatus from tblCustomer Where (CustomerId = '" + user + "') AND (BookingStatus <= 3)";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bookingStatus = Convert.ToInt16(dr["BookingStatus"]); //to get the number of booking made by user
                }
                if (bookingStatus <= 3) bookingStatus--;
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bookingStatus;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cboCarRegId_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllText();
            populateAllText(cboCarRegId.Text);
        }

        private void populateAllText(string CarRegId)
        {
           try
            {
                cn.Open();
                cmd.CommandText = "select a.CarRegId, a.CarType, a.CarModel, a.CarMaker, a.CarColor, a.CarRentageCost, a.CarPlateNumber, b.BookingDate, b.DueDate from tblCar a, tblBooking b Where (a.CarRegId = '" + CarRegId + "') AND (b.CarRegId= '" + CarRegId + "') And (b.CustomerId = '" + UserId + "') AND (b.BookingStatus = 1)";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //txtCarRegId.Text = dr["a.CarRegId"].ToString();
                    txtCarType.Text = dr[1].ToString(); //txtCarType.Text = dr["a.CarType"].ToString();
                    txtCarModel.Text = dr[2].ToString(); //txtCarModel.Text = dr["a.CarModel"].ToString();
                    txtCarMaker.Text = dr[3].ToString(); //txtCarMaker.Text = dr["a.CarMaker"].ToString();
                    txtCarColor.Text = dr[4].ToString(); //txtCarColor.Text = dr["a.CarColor"].ToString();
                    txtCarRentageCost.Text = dr[5].ToString(); //txtCarRentageCost.Text = dr["a.CarRentageCost"].ToString();
                    txtCarPlateNumber.Text = dr[6].ToString(); //txtCarPlateNumber.Text = dr["a.CarPlateNumber"].ToString();
                    txtCarRentageDate.Text = dr[7].ToString(); //txtCarRentageDate.Text = dr["b.BookingDate"].ToString();
                    txtCarDueDate.Text = dr[8].ToString(); //txtCarDueDate.Text = dr["b.DueDate"].ToString();
                }
                dr.Close();
                cn.Close();
                txtCustomerId.Text = UserId;
                btnReturn.Enabled = true;

            }
           catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
