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
    public partial class FrmEditCarRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmEditCarRegistration()
        {
            InitializeComponent();
        }

        private void FrmEditCarRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            clearAllText();
            populateCarRegistrationId();
        }
        private void populateCarRegistrationId()
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select CarRegId from tblCar";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboCarRegId.Items.Add((dr["CarRegId"]).ToString());
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
        private void clearAllText()
        {
            //cboCarRegId.ResetText();
            cboCarType.ResetText(); cboCarType.Enabled = false;
            cboCarModel.ResetText(); cboCarModel.Enabled = false;
            cboCarMaker.ResetText(); cboCarMaker.Enabled = false;
            txtCarColor.ResetText(); txtCarColor.Enabled = false;
            txtCarRentageCost.ResetText(); txtCarRentageCost.Enabled = false;
            txtCarPlateNumber.ResetText(); txtCarPlateNumber.Enabled = false;
            
            btnUpdate.Enabled = false;
        }

        private void cboCarRegId_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllText();
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblCar Where CarRegId = '" + cboCarRegId.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cboCarRegId.Items.Add((dr["CarRegId"]).ToString());
                    cboCarType.Text = dr["CarType"].ToString();
                    cboCarModel.Text = dr["CarModel"].ToString();
                    cboCarMaker.Text = dr["CarMaker"].ToString();
                    txtCarColor.Text = dr["CarColor"].ToString();
                    txtCarRentageCost.Text = dr["CarRentageCost"].ToString();
                    txtCarPlateNumber.Text = dr["CarPlateNumber"].ToString();
                    EnabledAllText();
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
        }
        private void EnabledAllText()
        {
            //cboCarRegId.ResetText();
            cboCarType.Enabled = true;
            cboCarModel.Enabled = true;
            cboCarMaker.Enabled = true;
            txtCarColor.Enabled = true;
            txtCarRentageCost.Enabled = true;
            txtCarPlateNumber.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string CarRegId = cboCarRegId.Text;
                    string CarType = cboCarType.Text;
                    string CarModel = cboCarModel.Text;
                    string CarMaker = cboCarMaker.Text;
                    string CarColor = txtCarColor.Text;
                    string CarRentageCost = txtCarRentageCost.Text;
                    string CarPlateNumber = txtCarPlateNumber.Text;
                    //string CarStatus = "Available!";
                    {
                        cn.Open();
                        cmd.CommandText = "Update tblCar Set CarType ='" + CarType + "', CarModel ='" + CarModel + "', CarMaker ='" + CarMaker + "', CarColor ='" + CarColor + "', CarRentageCost ='" + CarRentageCost + "', CarPlateNumber ='" + CarPlateNumber + "' WHERE (CarRegId = '" + CarRegId + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Registration Details successfully Updated!!!", "Car Rental App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        clearAllText();
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

            if ((cboCarRegId.Text == "CAR/RENT/"))
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

    }
}
