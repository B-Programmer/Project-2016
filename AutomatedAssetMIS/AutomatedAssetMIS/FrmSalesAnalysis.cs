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
    public partial class FrmSalesAnalysis : Form
    {
        private OleDbConnection cn;
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb");
        private OleDbCommand cmd;
        private OleDbDataReader dr;

        public FrmSalesAnalysis()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
            cmd = new OleDbCommand();
           // cmd.Connection = cn;
                    
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                if ((cboAssetType.Text == "") || (txtAssetLocation.Text == ""))
                {
                    MessageBox.Show("Please specify the asset type or asset location before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if ((cboAssetType.Text.ToLower() == "building"))
                    {
                        genBuildingSalesAnalysisReport(txtAssetLocation.Text);
                    }
                    else if ((cboAssetType.Text.ToLower() == "land"))
                    {
                        genLandSalesAnalysisReport(txtAssetLocation.Text);
                    }
                    else if ((cboAssetType.Text.ToLower() == "furniture"))
                    {
                        genFurnitureSalesAnalysisReport(txtAssetLocation.Text);
                    }
                    else if ((cboAssetType.Text.ToLower() == "vehicle"))
                    {
                        genVehicleSalesAnalysisReport(txtAssetLocation.Text);
                    }
                }
            }
            catch (Exception Er)
            {                
                MessageBox.Show(Er.Message, "Asset MIS App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genBuildingSalesAnalysisReport(string AssetLocation)
        {
            string[] arrRpt = new string[6];
            ListViewItem item;
            try
            {
                cn.Open();
                //cmd.CommandText = "select DISTINCT Building_ID, Building_Type, Building_Name, Count(Building_ID), Sum(Building_Rentage_Cost), Sum(Building_Amount_Paid) from tblBuildingSales WHERE (Building_Location ='" + AssetLocation + "') ORDER BY Building_ID, Building_Type, Building_Name";
                cmd.CommandText = "select Building_ID, Building_Type, Building_Name, Count(Building_ID), Sum(Building_Rentage_Cost), Sum(Building_Amount_Paid) from tblBuildingSales WHERE (Building_Location ='" + AssetLocation + "') GROUP BY Building_ID, Building_Type, Building_Name";
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    //no Report for the specified location
                    MessageBox.Show("There is no Asset Sales Report for the specified location", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Add Column Header
                    listView1.Columns.Add("Building ID", 150);
                    listView1.Columns.Add("Building Type", 150);
                    listView1.Columns.Add("Building Name", 250);
                    listView1.Columns.Add("Number of Sales", 150);
                    listView1.Columns.Add("Total Building Cost", 150);
                    listView1.Columns.Add("Total Amount Paid", 150);
                    while (dr.Read())
                    {
                        arrRpt[0] =  ((dr[0]).ToString()); //populate the building id
                        arrRpt[1] = ((dr[1]).ToString()); //populate the building type
                        arrRpt[2] = ((dr[2]).ToString()); //populate the building name
                        arrRpt[3] = ((dr[3]).ToString()); //populate the number of distinct building id
                        arrRpt[4] = ((dr[4]).ToString()); //populate the Sum of distinct building Cost
                        arrRpt[5] = ((dr[5]).ToString()); //populate the Sum of distinct building Amount Paid
                        //add item into list
                        item = new ListViewItem(arrRpt);
                        listView1.Items.Add(item);
                    }
                    
                }
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

        private void genLandSalesAnalysisReport(string AssetLocation)
        {
            string[] arrRpt = new string[6];
            ListViewItem item;
            try
            {
                cn.Open();
                cmd.CommandText = "select Land_Reg_ID, Land_Width, Land_Length, Count(Land_Reg_ID), Sum(Land_Sale_Cost), Sum(Land_Amount_Paid) from tblLandSales WHERE (Land_Location = '" + AssetLocation + "') GROUP BY Land_Reg_ID, Land_Width, Land_Length";
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    //no Report for the specified location
                    MessageBox.Show("There is no Asset Sales Report for the specified location", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Add Column Header
                    listView1.Columns.Add("Land Reg. ID", 150);
                    listView1.Columns.Add("Land Width", 150);
                    listView1.Columns.Add("Land Length", 250);
                    listView1.Columns.Add("Number of Sales", 150);
                    listView1.Columns.Add("Total Land Sale Cost", 150);
                    listView1.Columns.Add("Total Amount Paid", 150);
                    while (dr.Read())
                    {
                        arrRpt[0] = ((dr[0]).ToString()); //populate the Land Reg id
                        arrRpt[1] = ((dr[1]).ToString()); //populate the Land Width
                        arrRpt[2] = ((dr[2]).ToString()); //populate the Land Length
                        arrRpt[3] = ((dr[3]).ToString()); //populate the number of distinct Land id
                        arrRpt[4] = ((dr[4]).ToString()); //populate the Sum of distinct Land Cost
                        arrRpt[5] = ((dr[5]).ToString()); //populate the Sum of distinct Land Amount Paid
                        //add item into list
                        item = new ListViewItem(arrRpt);
                        listView1.Items.Add(item);
                    }

                }
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
        
        private void genFurnitureSalesAnalysisReport(string AssetLocation)
        {
            string[] arrRpt = new string[5];
            ListViewItem item;
            try
            {
                cn.Open();
                cmd.CommandText = "SELECT Furniture_Type, Furniture_Name, Count(Furniture_Name), Sum(Furniture_Cost), Sum(Furniture_Amount_Paid) from tblFurnitureSales WHERE (Furniture_Location = '" + AssetLocation + "') GROUP BY Furniture_Type, Furniture_Name";
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    //no Report for the specified location
                    MessageBox.Show("There is no Asset Sales Report for the specified location", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Add Column Header
                    listView1.Columns.Add("Furniture Type", 150);
                    listView1.Columns.Add("Furniture Name", 150);
                    listView1.Columns.Add("Number of Sales", 150);
                    listView1.Columns.Add("Total Furniture Cost", 150);
                    listView1.Columns.Add("Total Amount Paid", 150);
                    while (dr.Read())
                    {
                        arrRpt[0] = ((dr[0]).ToString()); //populate the Furniture Type
                        arrRpt[1] = ((dr[1]).ToString()); //populate the Furniture Name
                        arrRpt[2] = ((dr[2]).ToString()); //populate the Number of Sales
                        arrRpt[3] = ((dr[3]).ToString()); //populate the Sum of Distinct Furniture Cost
                        arrRpt[4] = ((dr[4]).ToString()); //populate the Sum of distinct Furniture Amount Paid
                        //add item into list
                        item = new ListViewItem(arrRpt);
                        listView1.Items.Add(item);
                    }

                }
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

        private void genVehicleSalesAnalysisReport(string AssetLocation)
        {
            string[] arrRpt = new string[5];
            ListViewItem item;
            try
            {
                cn.Open();
                cmd.CommandText = "select Vehicle_Type, Vehicle_Model, Count(Vehicle_Type), Sum(Vehicle_Cost), Sum(Vehicle_Amount_Paid) from tblVehicleSales WHERE (Vehicle_Location = '" + AssetLocation + "') GROUP BY Vehicle_Type, Vehicle_Model";
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    //no Report for the specified location
                    MessageBox.Show("There is no Asset Sales Report for the specified location", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Add Column Header
                    listView1.Columns.Add("Vehicle type", 150);
                    listView1.Columns.Add("Vehicle Model", 150);
                    listView1.Columns.Add("Number of Sales", 150);
                    listView1.Columns.Add("Total Vehicle Sale Cost", 170);
                    listView1.Columns.Add("Total Amount Paid", 150);
                    while (dr.Read())
                    {
                        arrRpt[0] = ((dr[0]).ToString()); //populate the Vehicle Type
                        arrRpt[1] = ((dr[1]).ToString()); //populate the Vehicle Model
                        arrRpt[2] = ((dr[2]).ToString()); //populate the number of distinct Vehicle Type
                        arrRpt[3] = ((dr[3]).ToString()); //populate the Sum of distinct Vehicle Cost
                        arrRpt[4] = ((dr[4]).ToString()); //populate the Sum of distinct Vehicle Amount Paid
                        //add item into list
                        item = new ListViewItem(arrRpt);
                        listView1.Items.Add(item);
                    }

                }
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

        private void FrmSalesAnalysis_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //listView1.Sort = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
    }
}
