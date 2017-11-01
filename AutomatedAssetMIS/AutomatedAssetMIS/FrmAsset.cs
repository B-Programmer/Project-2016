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
    public partial class FrmAsset : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private bool nonNumberEntered = false; 


        public FrmAsset()
        {
            InitializeComponent();
        }

        private void btnBuildingCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLandCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFurnitureCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVehicleCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuildingClear_Click(object sender, EventArgs e)
        {
            txtBuildingID.Text = genBuildingId();
            txtBuildingName.Clear();
            cboBuildingType.ResetText();
            txtRoomNumber.Clear();
            txtBuildingOwnerName.Clear();
            txtBuildingLocation.Clear();
            txtBuildingOwnerPhone.Clear();
            optSale.Checked = false;
            optRentage.Checked = false;
            txtRoomRentageCost.Clear();
            txtRoomSaleCost.Clear();
            chkWater.Checked = false;
            chkToilet.Checked = false;
            chkSittingRoom.Checked = false;
            chkShop.Checked = false;
            chkOthers.Checked = false;
            chkKitchen.Checked = false;
            chkGarden.Checked = false;
            chkFurniture.Checked = false;
            chkFence.Checked = false;
            chkDinningRoom.Checked = false;
            chkBedroom.Checked = false;
            txtBuildingAgentName.Clear();
            txtBuildingAgentAddress.Clear();
            txtBuildingAgentPhone.Clear();
        }

        private void btnLandClear_Click(object sender, EventArgs e)
        {
            txtLandRegID.Text = genLandRegId();
            txtLandOwnerName.Clear();
            txtLandOwnerAddress.Clear();
            txtLandOwnerPhone.Clear();
            txtLandLocation.Clear();
            txtLandWidth.Clear();
            txtLandLength.Clear();
            optLandSale.Checked = false;
            optLandRentage.Checked = false;
            txtLandRentageCost.Clear();
            txtLandSaleCost.Clear();
            txtLandAgentName.Clear();
            txtLandAgentAddress.Clear();
            txtLandAgentPhone.Clear();
            dtpLandChargeDate.ResetText();
        }

        private void btnFurnitureClear_Click(object sender, EventArgs e)
        {
            cboFurnitureType.ResetText();
            txtManufacturerName.Clear();
            txtManufacturerAddress.Clear();
            txtManufacturerPhone.Clear();
            cboFurnitureName.ResetText();
            txtFurnitureCost.Clear();
            dtpManufactureDate.ResetText();
            txtFurnitureAgentName.Clear();
            txtFurnitureAgentAddress.Clear();
            txtFurnitureAgentPhone.Clear();
            dtpFurnitureChargeDate.ResetText();
        }

        private void btnVehicleClear_Click(object sender, EventArgs e)
        {
            cboVehicleType.ResetText();
            cboVehicleModel.ResetText();
            cboVehicleBrand.ResetText();
            optNewModel.Checked = false;
            optOldModel.Checked = false;
            txtVehicleColor.Clear();
            cboVehicleEngineType.ResetText();
            txtVehicleEngineNumber.Clear();
            txtVehiclePlateNumber.Clear();
            cboVehicleMode.ResetText();
            cboFuelType.ResetText();
            txtVehicleCost.Clear();
            dtpDateManufactured.ResetText();
            txtVehicleAgentName.Clear();
            txtVehicleAgentAddress.Clear();
            txtVehicleAgentPhone.Clear();
        }

        private void btnBuildingSave_Click(object sender, EventArgs e)
        {
           try
           {
               if ((txtBuildingName.Text == "") || (cboBuildingType.Text == "") || (txtRoomNumber.Text == "") || (txtBuildingLocation.Text == "") || (txtBuildingOwnerName.Text == "") || (txtBuildingAgentName.Text == ""))
               {
                   MessageBox.Show("Please fill all Building details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {
                   string BuildingSaleRentage = "Sale", BuildingFacilities = "";
                   string BuildingID = txtBuildingID.Text;
                   string BuildingName = txtBuildingName.Text;
                   string BuildingType = cboBuildingType.Text;
                   int RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                   string BuildingOwnerName = txtBuildingOwnerName.Text;
                   string BuildingLocation = txtBuildingLocation.Text;
                   string BuildingOwnerPhone = txtBuildingOwnerPhone.Text;
                   string BuildingAgentName = txtBuildingAgentName.Text;
                   string BuildingAgentAddress = txtBuildingAgentAddress.Text;
                   string BuildingAgentPhone = txtBuildingAgentPhone.Text;
                   if (optSale.Checked) BuildingSaleRentage = "Sale";
                   if (optRentage.Checked) BuildingSaleRentage = "Rentage";
                   double RoomRentageCost = Convert.ToDouble(txtRoomRentageCost.Text);
                   double RoomSaleCost = Convert.ToDouble(txtRoomSaleCost.Text);
                   if (chkWater.Checked) BuildingFacilities = "Water, ";
                   if (chkToilet.Checked) BuildingFacilities = BuildingFacilities + "Toilet, ";
                   if (chkSittingRoom.Checked) BuildingFacilities = BuildingFacilities + "SittingRoom, ";
                   if (chkShop.Checked) BuildingFacilities = BuildingFacilities + "Shop, ";
                   if (chkOthers.Checked) BuildingFacilities = BuildingFacilities + "and Others. ";
                   if (chkKitchen.Checked) BuildingFacilities = BuildingFacilities + "Kitchen, ";
                   if (chkGarden.Checked) BuildingFacilities = BuildingFacilities + "Garden, ";
                   if (chkFurniture.Checked) BuildingFacilities = BuildingFacilities + "Furniture, ";
                   if (chkFence.Checked) BuildingFacilities = BuildingFacilities + "Fence, ";
                   if (chkDinningRoom.Checked) BuildingFacilities = BuildingFacilities + "DiningRoom, ";
                   if (chkBedroom.Checked) BuildingFacilities = BuildingFacilities + "Bedroom, ";

                   cn.Open();
                   cmd.CommandText = "insert into tblBuilding values('" + BuildingID + "','" + BuildingName + "', '" + BuildingType + "'," + RoomNumber + ",'" + BuildingOwnerName + "','" + BuildingLocation + "','" + BuildingOwnerPhone + "','" + BuildingAgentName + "','" + BuildingAgentAddress + "','" + BuildingAgentPhone + "','" + BuildingFacilities + "','" + BuildingSaleRentage + "'," + RoomRentageCost + "," + RoomSaleCost + ")";
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Building Asset Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   cn.Close();
                   btnBuildingClear_Click(sender, e);
               }
           }
           catch (Exception er)
           {
               cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }

        private void btnLandSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtLandOwnerName.Text == "") || (txtLandLocation.Text == "") || (txtLandWidth.Text == "") || (txtLandLength.Text == "") || (txtLandAgentName.Text == ""))
                {
                    MessageBox.Show("Please fill all Land details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
            
                    string LandSaleRentage = "Sale";
                    string LandRegID = txtLandRegID.Text;
                    string LandOwnerName = txtLandOwnerName.Text;
                    string LandOwnerAddress = txtLandOwnerAddress.Text;
                    string LandOwnerPhone = txtLandOwnerPhone.Text;
                    string LandLocation = txtLandLocation.Text;
                    double LandWidth = Convert.ToDouble(txtLandWidth.Text);
                    double LandLength = Convert.ToDouble(txtLandLength.Text);
                    if(optLandSale.Checked) LandSaleRentage = "Sale";
                    if (optLandRentage.Checked) LandSaleRentage = "Lease(Rentage)";
                    double LandRentageCost = Convert.ToDouble(txtLandRentageCost.Text);
                    double LandSaleCost = Convert.ToDouble(txtLandSaleCost.Text);
                    string LandAgentName = txtLandAgentName.Text;
                    string LandAgentAddress = txtLandAgentAddress.Text;
                    string LandAgentPhone = txtLandAgentPhone.Text;
                    string LandChargeDate = dtpLandChargeDate.Text;
            
                   cn.Open();
                   cmd.CommandText = "insert into tblLand values('" + LandRegID + "','" + LandOwnerName + "','" + LandOwnerAddress + "','" + LandOwnerPhone + "','" + LandLocation + "'," + LandWidth + "," + LandLength + ",'" + LandSaleRentage + "'," + LandRentageCost + "," + LandSaleCost + ",'" + LandAgentName + "','" + LandAgentAddress + "','" + LandAgentPhone + "','" + LandChargeDate + "')";
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Land Asset Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   cn.Close();
                   btnLandClear_Click(sender, e);
               }
           }
           catch (Exception er)
           {
               cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btnFurnitureSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboFurnitureType.Text == "") || (txtManufacturerName.Text == "") || (cboFurnitureName.Text == "") || (txtFurnitureCost.Text == "") || (txtFurnitureAgentName.Text == ""))
                {
                    MessageBox.Show("Please fill all Furniture details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
            
                    string FurnitureType = cboFurnitureType.Text;
                    string ManufacturerName = txtManufacturerName.Text;
                    string ManufacturerAddress = txtManufacturerAddress.Text;
                    string ManufacturerPhone = txtManufacturerPhone.Text;
                    string FurnitureName = cboFurnitureName.Text;
                    double FurnitureCost = Convert.ToDouble(txtFurnitureCost.Text);
                    string ManufactureDate = dtpManufactureDate.Text;
                    string FurnitureAgentName = txtFurnitureAgentName.Text;
                    string FurnitureAgentAddress = txtFurnitureAgentAddress.Text;
                    string FurnitureAgentPhone = txtFurnitureAgentPhone.Text;
                    string FurnitureChargeDate = dtpFurnitureChargeDate.Text;
                                
                   cn.Open();
                   cmd.CommandText = "insert into tblFurniture values('" + ManufacturerName + "','" + ManufacturerAddress + "','" + ManufacturerPhone + "','" + FurnitureType + "','" + FurnitureName + "'," + FurnitureCost + ",'" + ManufactureDate + "','" + FurnitureAgentName + "','" + FurnitureAgentAddress + "','" + FurnitureAgentPhone + "','" + FurnitureChargeDate + "')";
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Furniture Asset Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   cn.Close();
               }
           }
           catch (Exception er)
           {
               cn.Close(); 
               MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btnVehicleSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cboVehicleType.Text == "") || (cboVehicleModel.Text == "") || (txtVehicleColor.Text == "") || (cboFuelType.Text == "") || (txtVehicleCost.Text == "")|| (txtVehicleAgentName.Text == ""))
                {
                    MessageBox.Show("Please fill all Vehicle details before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string VehicleModelType = "New Model";
                    string VehicleType = cboVehicleType.Text;
                    string VehicleModel = cboVehicleModel.Text;
                    string VehicleBrand = cboVehicleBrand.Text;
                    if(optNewModel.Checked) VehicleModelType = "New Model";
                    if (optOldModel.Checked) VehicleModelType = "Old Model";
                    string VehicleColor = txtVehicleColor.Text;
                    string VehicleEngineType = cboVehicleEngineType.Text;
                    string VehicleEngineNumber = txtVehicleEngineNumber.Text;
                    string VehiclePlateNumber = txtVehiclePlateNumber.Text;
                    string VehicleMode = cboVehicleMode.Text;
                    string FuelType = cboFuelType.Text;
                    double VehicleCost = Convert.ToDouble(txtVehicleCost.Text);
                    string DateManufactured = dtpDateManufactured.Text;
                    string VehicleAgentName = txtVehicleAgentName.Text;
                    string VehicleAgentAddress = txtVehicleAgentAddress.Text;
                    string VehicleAgentPhone = txtVehicleAgentPhone.Text;
                                
                   cn.Open();
                   cmd.CommandText = "insert into tblVehicle values('" + VehicleType + "','" + VehicleModel + "','" + VehicleBrand + "','" + VehicleModelType + "','" + VehicleColor + "','" + VehicleEngineType + "','" + VehicleEngineNumber + "','" + VehiclePlateNumber + "','" + VehicleMode + "','" + FuelType + "'," + VehicleCost + ",'" + DateManufactured + "','" + VehicleAgentName + "','" + VehicleAgentAddress + "','" + VehicleAgentPhone + "')";
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Vehicle Asset Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   cn.Close();
               }
           }
           catch (Exception er)
           {
               cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void FrmAsset_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            txtBuildingID.Text = genBuildingId();
            txtBuildingID.Enabled = false;
            txtLandRegID.Text = genLandRegId();
            txtLandRegID.Enabled = false;
        }

        private string genBuildingId()
        {
            string BuildingId = "Building";
            try
            {
                int rowCount = 0;
                cn.Open();
                cmd.CommandText = "select count(*) as RowCount from tblBuilding";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    rowCount = (int)(dr["RowCount"]);
                rowCount++;
                if (rowCount < 10)
                {
                    BuildingId = BuildingId + "000" + rowCount;
                }
                else if (rowCount < 100)
                {
                    BuildingId = BuildingId + "00" + rowCount;
                }
                else if (rowCount < 1000)
                {
                    BuildingId = BuildingId + "0" + rowCount;
                }
                else if (rowCount < 10000)
                {
                    BuildingId = BuildingId + rowCount;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Asset MIS App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return BuildingId;
        }

        private string genLandRegId()
        {
            string LandRegId = "Land";
            try
            {
                int rowCount = 0;
                cn.Open();
                cmd.CommandText = "select count(*) as RowCount from tblLand";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    rowCount = (int)(dr["RowCount"]);
                rowCount++;
                if (rowCount < 10)
                {
                    LandRegId = LandRegId + "000" + rowCount;
                }
                else if (rowCount < 100)
                {
                    LandRegId = LandRegId + "00" + rowCount;
                }
                else if (rowCount < 1000)
                {
                    LandRegId = LandRegId + "0" + rowCount;
                }
                else if (rowCount < 10000)
                {
                    LandRegId = LandRegId + rowCount;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Asset MIS App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return LandRegId;
        }


        private void txtRoomNumber_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtBuildingOwnerPhone_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtBuildingOwnerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtBuildingAgentPhone_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtBuildingAgentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtRoomRentageCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtRoomRentageCost_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        private void txtRoomSaleCost_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        private void txtRoomSaleCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void optSale_CheckedChanged(object sender, EventArgs e)
        {
            if (optSale.Checked)
            {
                txtRoomSaleCost.Enabled = true;
                txtRoomRentageCost.Enabled = false;
                txtRoomRentageCost.Text = "0.00";
            }
        }

        private void optRentage_CheckedChanged(object sender, EventArgs e)
        {
            if (optRentage.Checked)
            {
                txtRoomSaleCost.Enabled = false;
                txtRoomRentageCost.Enabled = true;
                txtRoomSaleCost.Text = "0.00";
            }
        }

        private void optLandSale_CheckedChanged(object sender, EventArgs e)
        {
            if (optLandSale.Checked)
            {
                txtLandSaleCost.Enabled = true;
                txtLandRentageCost.Enabled = false;
                txtLandRentageCost.Text = "0.00";
            }
        }

        private void optLandRentage_CheckedChanged(object sender, EventArgs e)
        {
            if (optLandRentage.Checked)
            {
                txtLandSaleCost.Enabled = false;
                txtLandRentageCost.Enabled = true;
                txtLandSaleCost.Text = "0.00";
            }
        }

        private void txtLandOwnerPhone_KeyDown(object sender, KeyEventArgs e)
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

        private void txtLandOwnerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtManufacturerPhone_KeyDown(object sender, KeyEventArgs e)
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

        private void txtManufacturerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtVehicleAgentPhone_KeyDown(object sender, KeyEventArgs e)
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

        private void txtVehicleAgentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtVehicleAgentPhone_TextChanged(object sender, EventArgs e)
        {

        }

        

        

    }
}
