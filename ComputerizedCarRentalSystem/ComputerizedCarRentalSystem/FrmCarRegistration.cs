using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ComputerizedCarRentalSystem
{
    public partial class FrmCarRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmCarRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnRefresh()
        {
            txtCarRegistrationId.Text = genCarRegistrationId(); 
            cboCarType.ResetText();
            cboCarModel.ResetText();
            cboCarMaker.ResetText();
            txtCarColor.ResetText();
            txtCarRentageCost.ResetText();
            txtCarPlateNumber.ResetText(); 
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string CarRegId = txtCarRegistrationId.Text;
                    string CarType = cboCarType.Text;
                    string CarModel = cboCarModel.Text;
                    string CarMaker = cboCarMaker.Text;
                    string CarColor = txtCarColor.Text;
                    string CarRentageCost = txtCarRentageCost.Text;
                    string CarPlateNumber = txtCarPlateNumber.Text;
                    string CarStatus = "Available!";
                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblCar values('" + CarRegId + "','" + CarType + "','" + CarModel + "','" + CarMaker + "','" + CarColor + "','" + CarRentageCost + "','" + CarPlateNumber + "','" + CarStatus + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Car Registration Details successfully saved!!!", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        btnRefresh();
                    }
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtCarRegistrationId.Text == "CAR/RENT/"))
            {
                MessageBox.Show("Please click refresh button to regenerate car registration id", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCarType.Focus();
                return isEntryFilled;
            }
            else if ((cboCarType.Text == ""))
            {
                MessageBox.Show("Please specify the Car Type", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCarType.Focus();
                return isEntryFilled;
            }
            else if ((cboCarModel.Text == ""))
            {
                MessageBox.Show("Please set the Car Model", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCarModel.Focus();
                return isEntryFilled;
            }
            else if ((cboCarMaker.Text == ""))
            {
                MessageBox.Show("Please set the Car Maker", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCarMaker.Focus();
                return isEntryFilled;
            }
            else if ((txtCarColor.Text == ""))
            {
                MessageBox.Show("Please enter the Car Color", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarColor.Focus();
                return isEntryFilled;
            }
            else if ((txtCarRentageCost.Text == ""))
            {
                MessageBox.Show("Please type the Car Rentage Cost ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarRentageCost.Focus();
                return isEntryFilled;
            }
            else if ((txtCarPlateNumber.Text == ""))
            {
                MessageBox.Show("Please type the Car Plate Number ", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarPlateNumber.Focus();
                return isEntryFilled;
            }
            else
                return true;
            
        }

        private void FrmCarRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            txtCarRegistrationId.Text = genCarRegistrationId();
            txtCarRegistrationId.Enabled = false;

        }

        private string genCarRegistrationId()
        {
            string CarId = "CAR/RENT/";
            try
            {
                int rowCount = 0;
                cn.Open();
                cmd.CommandText = "select count(*) as RowCount from tblCar";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    rowCount = (int)(dr["RowCount"]);
                rowCount++;
                if (rowCount < 10)
                {
                    CarId = CarId + "000" + rowCount;
                }
                else if (rowCount < 100)
                {
                    CarId = CarId + "00" + rowCount;
                }
                else if (rowCount < 1000)
                {
                    CarId = CarId + "0" + rowCount;
                }
                else if (rowCount < 10000)
                {
                    CarId = CarId + rowCount;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return CarId;
        }

    }
}
