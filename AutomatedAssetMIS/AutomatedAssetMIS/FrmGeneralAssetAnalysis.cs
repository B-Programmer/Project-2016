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
    public partial class FrmGeneralAssetAnalysis : Form
    {
        private OleDbConnection cn;
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb");
        private OleDbCommand cmd;
        private OleDbDataReader dr;

        public FrmGeneralAssetAnalysis()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
            cmd = new OleDbCommand();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmGeneralAssetAnalysis_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                if ((txtAssetLocation.Text == ""))
                {
                    MessageBox.Show("Please specify the asset location before you proceed", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                    {
                        genAssetSalesAnalysisReport(txtAssetLocation.Text);
                    }
                    

                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "Asset MIS App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genAssetSalesAnalysisReport(string AssetLocation)
        {
            string[] arrRpt = new string[5];
            ListViewItem item;
            //Add Column Header
            listView1.Columns.Add("Asset Type", 150);
            listView1.Columns.Add("Number of Sales", 150);
            listView1.Columns.Add("Total Asset Cost", 150);
            listView1.Columns.Add("Total Amount Paid", 150);
            listView1.Columns.Add("Total Balance", 150);
            try
            {
                cn.Open();
                //cmd.CommandText = "select DISTINCT Building_ID, Building_Type, Building_Name, Count(Building_ID), Sum(Building_Rentage_Cost), Sum(Building_Amount_Paid) from tblBuildingSales WHERE (Building_Location ='" + AssetLocation + "') ORDER BY Building_ID, Building_Type, Building_Name";
                //cmd.CommandText = "select Count(Building_ID), Sum(Building_Rentage_Cost), Sum(Building_Amount_Paid), sum(Building_Balance) from tblBuildingSales WHERE (Building_Location ='" + AssetLocation + "') GROUP BY Building_ID, Building_Type, Building_Name";
                cmd.CommandText = "select Count(Building_ID), Sum(Building_Rentage_Cost), Sum(Building_Amount_Paid), sum(Building_Balance) from tblBuildingSales WHERE (Building_Location ='" + AssetLocation + "') ";
                dr = cmd.ExecuteReader();
                                
                    while (dr.Read())
                    {
                        arrRpt[0] = "Building ";
                        arrRpt[1] = ((dr[0]).ToString()); //populate the building type
                        arrRpt[2] = ((dr[1]).ToString()); //populate the building name
                        arrRpt[3] = ((dr[2]).ToString()); //populate the number of distinct building id
                        arrRpt[4] = ((dr[3]).ToString()); //populate the Sum of distinct building Cost                        
                        //add item into list
                        item = new ListViewItem(arrRpt);
                        listView1.Items.Add(item);
                    }
                dr.Close();
                cn.Close();
                //Generate report base on Land Sales
                cn.Open();
                cmd.CommandText = "select Count(Land_Reg_ID), Sum(Land_Sale_Cost), Sum(Land_Amount_Paid), sum(Land_Balance) from tblLandSales WHERE (Land_Location ='" + AssetLocation + "') ";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arrRpt[0] = "Land ";
                    arrRpt[1] = ((dr[0]).ToString()); //populate the Land Numbers
                    arrRpt[2] = ((dr[1]).ToString()); //populate the Land Cost
                    arrRpt[3] = ((dr[2]).ToString()); //populate the Sum of Land Amount Paid
                    arrRpt[4] = ((dr[3]).ToString()); //populate the Sum of distinct Land Balance                        
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView1.Items.Add(item);
                }
                dr.Close();
                cn.Close();
                //Generate report base on Furniture Sales
                cn.Open();
                cmd.CommandText = "select Count(Furniture_Name), Sum(Furniture_Cost), Sum(Furniture_Amount_Paid), Sum(Furniture_Balance) from tblFurnitureSales WHERE (Furniture_Location = '" + AssetLocation + "') ";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arrRpt[0] = "Furniture ";
                    arrRpt[1] = ((dr[0]).ToString()); //populate the Furniture Name numbers
                    arrRpt[2] = ((dr[1]).ToString()); //populate the Furniture Cost
                    arrRpt[3] = ((dr[2]).ToString()); //populate the Furniture Amount Paid
                    arrRpt[4] = ((dr[3]).ToString()); //populate the Sum of Furniture Balance                        
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView1.Items.Add(item);
                }
                dr.Close();
                cn.Close();
                //Generate report base on Vehicle Sales
                cn.Open();
                cmd.CommandText = "select Count(Vehicle_Type), Sum(Vehicle_Cost), Sum(Vehicle_Amount_Paid), Sum(Vehicle_Balance) from tblVehicleSales WHERE (Vehicle_Location = '" + AssetLocation + "')";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arrRpt[0] = "Vehicle ";
                    arrRpt[1] = ((dr[0]).ToString()); //populate the Vehicle Type numbers
                    arrRpt[2] = ((dr[1]).ToString()); //populate the Vehicle Cost
                    arrRpt[3] = ((dr[2]).ToString()); //populate the Vehicle Amount Paid
                    arrRpt[4] = ((dr[3]).ToString()); //populate the Sum of Vehicle Balance                        
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView1.Items.Add(item);
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
    }
}
