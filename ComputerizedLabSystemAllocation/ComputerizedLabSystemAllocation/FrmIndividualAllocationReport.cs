using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedLabSystemAllocation
{
    public partial class FrmIndividualAllocationReport : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbSystemLab.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedLabSystemAllocation\ComputerizedLabSystemAllocation\dbSystemLab.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmIndividualAllocationReport()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            label2.Text = "System Allocation Report";
            listView1.Items.Clear();
            //cboUserID.Text = "";
            txtTotalNoOfSystems.Text = "";
        }
        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
            cboUserID.Text = "";
            if (cboUserType.Text == "Student")
            {
                label24.Text = "Student Matric No:";
                loadStudentMatricNo();
            }
            else if (cboUserType.Text == "Staff")
            {
                label24.Text = "Staff ID:";
                loadStaffID();
            }

        }

        private void loadStudentMatricNo()
        {
            try
            {
                cboUserID.Items.Clear();
                cn.Open();
                cmd.CommandText = "select Student_Matric_No from tblStudentReg";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboUserID.Items.Add((dr["Student_Matric_No"]).ToString());
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadStaffID()
        {
            try
            {
                cboUserID.Items.Clear();
                cn.Open();
                cmd.CommandText = "select Staff_ID from tblStaffReg";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboUserID.Items.Add((dr["Staff_ID"]).ToString());
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIndividualAllocationReport_Load(object sender, EventArgs e)
        {
            cboUserType.Text = "";
            //..........................................................................
            cmd.Connection = cn;
            listView1.View = View.Details; 
            listView1.GridLines = true; 
            listView1.FullRowSelect = true; 
            //Add Column Header for listView 1
            listView1.Columns.Add("System Allocated", 170);
            listView1.Columns.Add("Allocation Date", 150);
            listView1.Columns.Add("User ID", 200);
            listView1.Columns.Add("User Name", 200);
            listView1.Columns.Add("Department", 150);
            listView1.Columns.Add("Session", 150);
            listView1.Columns.Add("Time-in", 150);
            listView1.Columns.Add("Time-out", 150);
            listView1.Columns.Add("Amount Charges", 200);
            listView1.Columns.Add("Other Services", 200); 
            
        }

        private void cboUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                txtTotalNoOfSystems.Clear();
                //txtTotalNoOfStudents.Clear();
                //txtTotalNoOfStaff.Clear();
                if ((cboUserType.Text == ""))
                {
                    MessageBox.Show("Please specify the User Type before you proceed", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((cboUserID.Text == ""))
                {
                    MessageBox.Show("Please specify the User ID(Student Matric No or Staff No) before you proceed", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    {
                        genUserAllocationReport(cboUserType.Text, cboUserID.Text);
                    }


                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genUserAllocationReport(string userType, string userID)
        {
            string[] arrRpt = new string[10];
            ListViewItem item;

            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();

                cn.Open();
                cmd.CommandText = "select System_Type, Allocation_Date, User_ID, User_Name, Department, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (User_Type ='" + userType + "') AND (User_ID ='" + userID + "') ORDER BY Allocation_Date Desc";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    arrRpt[0] = ((dr[0]).ToString()); //populate the system type
                    arrRpt[1] = ((dr[1]).ToString()); //populate the user type
                    arrRpt[2] = ((dr[2]).ToString()); //populate the user ID
                    arrRpt[3] = ((dr[3]).ToString()); //populate the User Name
                    arrRpt[4] = ((dr[4]).ToString()); //populate the Department
                    arrRpt[5] = ((dr[5]).ToString()); //populate the Session
                    arrRpt[6] = ((dr[6]).ToString()); //populate the Time-in
                    arrRpt[7] = ((dr[7]).ToString()); //populate the Time-out
                    arrRpt[8] = ((dr[8]).ToString()); //populate the Amount Charges
                    arrRpt[9] = ((dr[9]).ToString()); //populate the Other Services
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView1.Items.Add(item);
                    label2.Text = "System Allocation Report for " + userID;
                }
                dr.Close();
                cn.Close();
                //Generate report base on Total no of System Allocated
                cn.Open();
                cmd.CommandText = "select Count(*), Sum(Amount_Charges) from tblSystemAllocation WHERE (User_Type ='" + userType + "') AND (User_ID ='" + userID + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTotalNoOfSystems.Text = ((dr[0]).ToString()); //populate the no of System Allocated                      
                    txtTotalAmountCharge.Text = string.Format("{0:N2}", dr[1]); //populate the sum of System Amount Charges 
                }
                dr.Close();
                cn.Close();
                
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "System Allocation App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
