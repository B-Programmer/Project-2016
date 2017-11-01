using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedAssetMIS
{
    public partial class FrmAssetSales : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private bool nonNumberEntered;
        private double roomCost;
        public FrmAssetSales()
        {
            InitializeComponent();
            nonNumberEntered = false;
            roomCost = 0;
        }

        private void FrmAssetSales_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            genBuildingId();
            genLandRegId();
        }

        private void genBuildingId()
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select Building_ID from tblBuilding ";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboBuildingId.Items.Add((dr["Building_ID"]).ToString()); //populate the building id
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Asset MIS App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genLandRegId()
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select Land_Reg_ID from tblLand ";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboLandRegId.Items.Add((dr["Land_Reg_ID"]).ToString()); //populate the Land Reg id
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Asset MIS App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clearAllText()
        {
            txtBuildingName.Clear(); txtBuildingName.ReadOnly = true;
            txtBuildingType.Clear(); txtBuildingType.ReadOnly = true;
            txtRoomNumber.Clear(); //txtRoomNumber.ReadOnly = true;
            txtBuildingLocation.Clear(); txtBuildingLocation.ReadOnly = true;
            txtBuildingFacilities.Clear(); txtBuildingFacilities.ReadOnly = true;
            txtRoomRentageCost.Clear();
            txtBuildingCustomerName.Clear();
            txtBuildingCustomerAddress.Clear();
            txtBuildingCustomerPhone.Clear();
            txtBuildingAmountPaid.Clear();
            txtBuildingBalance.Clear(); txtBuildingBalance.ReadOnly = true;
            dtpBuildingTransactionDate.Value = DateTime.Now;//.ToString();//.ToShortDateString();
        }

        private void cboBuildingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllText();
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblBuilding Where Building_ID = '" + cboBuildingId.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cboCarRegId.Items.Add((dr["CarRegId"]).ToString());
                    txtBuildingName.Text = dr["Building_Name"].ToString();
                    txtBuildingType.Text = dr["Building_Type"].ToString();
                    txtRoomNumber.Text = dr["Room_Number"].ToString(); 
                    txtBuildingLocation.Text = dr["Building_Location"].ToString();
                    txtBuildingFacilities.Text = dr["Building_Facilities"].ToString();
                    txtRoomRentageCost.Text = dr["Room_Rentage_Cost"].ToString(); roomCost = Convert.ToDouble(txtRoomRentageCost.Text);
                }
                dr.Close();
                cn.Close();                                
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuildingSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtRoomRentageCost.Text == "") || (cboBuildingId.Text == "") || (txtRoomNumber.Text == "") || (txtBuildingLocation.Text == "") || (txtBuildingCustomerName.Text == "") || (txtBuildingCustomerPhone.Text == "") || (txtBuildingAmountPaid.Text == ""))
                {
                    MessageBox.Show("Please fill all Building details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                    string BuildingID = cboBuildingId.Text;
                    string BuildingName = txtBuildingName.Text;
                    string BuildingType = txtBuildingType.Text;
                    int RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                    string BuildingLocation = txtBuildingLocation.Text;
                    string BuildingFacilities = txtBuildingFacilities.Text;
                    double BuildingRentageCost = Convert.ToDouble(txtRoomRentageCost.Text);
                    string BuildingCustomerName = txtBuildingCustomerName.Text;
                    string BuildingCustomerAddress = txtBuildingCustomerAddress.Text;
                    string BuildingCustomerPhone = txtBuildingCustomerPhone.Text;
                    double BuildingAmountPaid = Convert.ToDouble(txtBuildingAmountPaid.Text);
                    double BuildingBalance = Convert.ToDouble(txtBuildingBalance.Text);
                    string BuildingTransactionDate = dtpBuildingTransactionDate.Text;

                    cn.Open();
                    cmd.CommandText = "insert into tblBuildingSales values('" + BuildingID + "','" + BuildingName + "', '" + BuildingType + "'," + RoomNumber + ",'" + BuildingLocation + "','" + BuildingFacilities + "'," + BuildingRentageCost + ",'" + BuildingCustomerName + "','" + BuildingCustomerAddress + "','" + BuildingCustomerPhone + "'," + BuildingAmountPaid + "," + BuildingBalance + ",'" + BuildingTransactionDate + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Building Asset Sales Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    clearAllText();
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {
            if ((txtRoomNumber.Text != ""))
            {
                
                txtRoomRentageCost.Text = (roomCost * Convert.ToInt32(txtRoomNumber.Text)).ToString();
            }
        }

        private void txtBuildingAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if ((txtBuildingAmountPaid.Text != "") && (txtRoomRentageCost.Text != ""))
            {
               txtBuildingBalance.Text = (Convert.ToDouble(txtRoomRentageCost.Text) - Convert.ToDouble(txtBuildingAmountPaid.Text)).ToString();
            }
        }

        private void txtBuildingAmountPaid_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.OemPeriod))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtBuildingAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void clearAllLandText()
        {
            txtLandLocation.Clear(); txtLandLocation.ReadOnly = true;
            txtLandWidth.Clear(); txtLandWidth.ReadOnly = true;
            txtLandLength.Clear(); txtLandLength.ReadOnly = true;
            txtLandSaleCost.Clear(); 
            txtLandCustomerName.Clear();
            txtLandCustomerAddress.Clear();
            txtLandCustomerPhone.Clear();
            txtLandAmountPaid.Clear();
            txtLandBalance.Clear(); txtLandBalance.ReadOnly = true;
            dtpLandTransactionDate.Value = DateTime.Now;//.ToString();//.ToShortDateString();
        }
        private void cboLandRegId_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllLandText();
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblLand Where Land_Reg_ID = '" + cboLandRegId.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    txtLandLocation.Text = dr["Land_Location"].ToString();
                    txtLandWidth.Text = dr["Land_Width"].ToString();
                    txtLandLength.Text = dr["Land_Length"].ToString();
                    txtLandSaleCost.Text = dr["Land_Sale_Cost"].ToString();
                    
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLandSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtLandSaleCost.Text == "") || (cboLandRegId.Text == "") || (txtLandLocation.Text == "") || (txtLandWidth.Text == "") || (txtLandCustomerName.Text == "") || (txtLandCustomerPhone.Text == "") || (txtLandAmountPaid.Text == ""))
                {
                    MessageBox.Show("Please fill all Land details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    string LandRegID = cboLandRegId.Text;
                    string LandLocation = txtLandLocation.Text;
                    double LandWidth = Convert.ToDouble(txtLandWidth.Text);
                    double LandLength = Convert.ToDouble(txtLandLength.Text);
                    double LandSaleCost = Convert.ToDouble(txtLandSaleCost.Text);
                    string LandCustomerName = txtLandCustomerName.Text;
                    string LandCustomerAddress = txtLandCustomerAddress.Text;
                    string LandCustomerPhone = txtLandCustomerPhone.Text;
                    double LandAmountPaid = Convert.ToDouble(txtLandAmountPaid.Text);
                    double LandBalance = Convert.ToDouble(txtLandBalance.Text);
                    string LandTransactionDate = dtpLandTransactionDate.Text;

                    cn.Open();
                    cmd.CommandText = "insert into tblLandSales values('" + LandRegID + "','" + LandLocation + "'," + LandWidth + "," + LandLength + "," + LandSaleCost + ",'" + LandCustomerName + "','" + LandCustomerAddress + "','" + LandCustomerPhone + "'," + LandAmountPaid + "," + LandBalance + ",'" + LandTransactionDate + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Land Asset Sales Information successfully saved!!! Transaction Completed.", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    clearAllLandText();
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLandAmountPaid_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.OemPeriod))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtLandAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void btnBuildingCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFurnitureSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboFurnitureType.Text == "") || (txtFurnitureLocation.Text == "") || (cboFurnitureName.Text == "") || (txtFurnitureCost.Text == "") || (txtFurnitureCustomerName.Text == "") || (txtFurnitureAmountPaid.Text == ""))
                {
                    MessageBox.Show("Please fill all Furniture details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    string FurnitureType = cboFurnitureType.Text;
                    string FurnitureName = cboFurnitureName.Text;
                    double FurnitureCost = Convert.ToDouble(txtFurnitureCost.Text);
                    string PurchasedDate = dtpPurchasedDate.Text;
                    string FurnitureCustomerName = txtFurnitureCustomerName.Text;
                    string FurnitureCustomerAddress = txtFurnitureCustomerAddress.Text;
                    string FurnitureCustomerPhone = txtFurnitureCustomerPhone.Text;
                    double FurnitureAmountPaid = Convert.ToDouble(txtFurnitureAmountPaid.Text);
                    double FurnitureBalance = Convert.ToDouble(txtFurnitureBalance.Text);
                    string FurnitureLocation = txtFurnitureLocation.Text;

                    cn.Open();
                    cmd.CommandText = "insert into tblFurnitureSales values('" + FurnitureType + "','" + FurnitureName + "'," + FurnitureCost + ",'" + PurchasedDate + "','" + FurnitureCustomerName + "','" + FurnitureCustomerAddress + "','" + FurnitureCustomerPhone + "'," + FurnitureAmountPaid + "," + FurnitureBalance + ",'" + FurnitureLocation + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Furniture Asset Sales Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    clearAllFurniture();
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLandAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if ((txtLandAmountPaid.Text != "") && (txtLandSaleCost.Text != ""))
            {
                txtLandBalance.Text = (Convert.ToDouble(txtLandSaleCost.Text) - Convert.ToDouble(txtLandAmountPaid.Text)).ToString();
            }
        }

        private void txtFurnitureAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if ((txtFurnitureAmountPaid.Text != "") && (txtFurnitureCost.Text != ""))
            {
                txtFurnitureBalance.Text = (Convert.ToDouble(txtFurnitureCost.Text) - Convert.ToDouble(txtFurnitureAmountPaid.Text)).ToString();
            }
        }

        private void clearAllFurniture()
        {
            cboFurnitureType.ResetText();
            cboFurnitureName.ResetText();
            txtFurnitureCost.Clear();
            dtpPurchasedDate.ResetText();
            txtFurnitureCustomerName.Clear();
            txtFurnitureCustomerAddress.Clear();
            txtFurnitureCustomerPhone.Clear();
            txtFurnitureAmountPaid.Clear();
            txtFurnitureBalance.Clear(); txtFurnitureBalance.ReadOnly = true;
            txtFurnitureLocation.Clear();
        }

        private void btnVehicleSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboVehicleType.Text == "") || (cboVehicleModel.Text == "") || (txtVehicleColor.Text == "") || (txtVehicleCost.Text == "") || (txtVehicleLocation.Text == "") || (txtVehicleCustomerName.Text == "") || (txtVehicleCustomerPhone.Text == "") || (txtVehicleAmountPaid.Text == ""))
                {
                    MessageBox.Show("Please fill all Vehicle details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string VehicleType = cboVehicleType.Text;
                    string VehicleModel = cboVehicleModel.Text;
                    string VehicleColor = txtVehicleColor.Text;
                    string VehiclePlateNumber = txtVehiclePlateNumber.Text;
                    string VehicleMode = cboVehicleMode.Text;
                    double VehicleCost = Convert.ToDouble(txtVehicleCost.Text);
                    string DatePurchased = dtpDateManufactured.Text;
                    string VehicleLocation = txtVehicleLocation.Text;
                    string VehicleCustomerName = txtVehicleCustomerName.Text;
                    string VehicleCustomerAddress = txtVehicleCustomerAddress.Text;
                    string VehicleCustomerPhone = txtVehicleCustomerPhone.Text;
                    double VehicleAmountPaid = Convert.ToDouble(txtVehicleAmountPaid.Text);
                    double VehicleBalance = Convert.ToDouble(txtVehicleBalance.Text);
                    

                    cn.Open();
                    cmd.CommandText = "insert into tblVehicleSales values('" + VehicleType + "','" + VehicleModel + "','" + VehicleColor + "','" + VehiclePlateNumber + "','" + VehicleMode + "'," + VehicleCost + ",'" + DatePurchased + "','" + VehicleLocation + "','" + VehicleCustomerName + "','" + VehicleCustomerAddress + "','" + VehicleCustomerPhone + "'," + VehicleAmountPaid + "," + VehicleBalance + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Asset Sales Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    clearAllVehicle();
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearAllVehicle()
        {
            cboVehicleType.ResetText();
            cboVehicleModel.ResetText();
            txtVehicleColor.Clear();
            txtVehiclePlateNumber.Clear();
            cboVehicleMode.ResetText();
            txtVehicleCost.Clear();
            dtpDateManufactured.ResetText();
            txtVehicleLocation.Clear();
            txtVehicleCustomerName.Clear();
            txtVehicleCustomerAddress.Clear();
            txtVehicleCustomerPhone.Clear();
            txtVehicleAmountPaid.Clear();
            txtVehicleBalance.Clear(); txtVehicleBalance.ReadOnly = true;
        }

        private void txtVehicleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if ((txtVehicleAmountPaid.Text != "") && (txtVehicleCost.Text != ""))
            {
                txtVehicleBalance.Text = (Convert.ToDouble(txtVehicleCost.Text) - Convert.ToDouble(txtVehicleAmountPaid.Text)).ToString();
            }
        }
        
        
    }
}
