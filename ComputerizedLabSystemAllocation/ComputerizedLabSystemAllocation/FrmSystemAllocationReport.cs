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
    public partial class FrmSystemAllocationReport : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbSystemLab.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedLabSystemAllocation\ComputerizedLabSystemAllocation\dbSystemLab.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmSystemAllocationReport()
        {
            InitializeComponent();
        }

        private void FrmSystemAllocationReport_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn; 
            listView1.View = View.Details; listView2.View = View.Details; listView3.View = View.Details; listView4.View = View.Details;
            listView1.GridLines = true; listView2.GridLines = true; listView3.GridLines = true; listView4.GridLines = true;
            listView1.FullRowSelect = true; listView2.FullRowSelect = true; listView3.FullRowSelect = true; listView4.FullRowSelect = true;
            //Add Column Header for listView 1
            listView1.Columns.Add("System Type", 150);
            listView1.Columns.Add("User Type", 120);
            listView1.Columns.Add("User ID", 200);
            listView1.Columns.Add("User Name", 200);
            listView1.Columns.Add("Department", 150);
            listView1.Columns.Add("Gender", 120);
            listView1.Columns.Add("Session", 150);
            listView1.Columns.Add("Time-in", 150);
            listView1.Columns.Add("Time-out", 150);
            listView1.Columns.Add("Amount Charges", 200);
            listView1.Columns.Add("Other Services", 200);
            //Add Column Header for listView 2
            listView2.Columns.Add("System Type", 150);
            listView2.Columns.Add("User Type", 120);
            listView2.Columns.Add("User ID", 200);
            listView2.Columns.Add("User Name", 200);
            listView2.Columns.Add("Department", 150);
            listView2.Columns.Add("Gender", 120);
            listView2.Columns.Add("Session", 150);
            listView2.Columns.Add("Time-in", 150);
            listView2.Columns.Add("Time-out", 150);
            listView2.Columns.Add("Amount Charges", 200);
            listView2.Columns.Add("Other Services", 200);
            //Add Column Header for listView3
            listView3.Columns.Add("System Type", 150);
            listView3.Columns.Add("User Type", 120);
            listView3.Columns.Add("User ID", 200);
            listView3.Columns.Add("User Name", 200);
            listView3.Columns.Add("Department", 150);
            listView3.Columns.Add("Gender", 120);
            listView3.Columns.Add("Session", 150);
            listView3.Columns.Add("Time-in", 150);
            listView3.Columns.Add("Time-out", 150);
            listView3.Columns.Add("Amount Charges", 200);
            listView3.Columns.Add("Other Services", 200);
            //Add Column Header for listView4
            listView4.Columns.Add("System Type", 150);
            listView4.Columns.Add("User Type", 120);
            listView4.Columns.Add("User ID", 200);
            listView4.Columns.Add("User Name", 200);
            listView4.Columns.Add("Department", 150);
            listView4.Columns.Add("Gender", 120);
            listView4.Columns.Add("Session", 150);
            listView4.Columns.Add("Time-in", 150);
            listView4.Columns.Add("Time-out", 150);
            listView4.Columns.Add("Amount Charges", 200);
            listView4.Columns.Add("Other Services", 200);

        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                txtTotalNoOfSystems.Clear();
                txtTotalNoOfStudents.Clear();
                txtTotalNoOfStaff.Clear();
                if ((dtpAllocationDate.Text == ""))
                {
                    MessageBox.Show("Please specify the System Allocation Date before you proceed", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    {
                        genDailyAllocationReport(dtpAllocationDate.Text, cboUserGender.Text);
                    }


                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genDailyAllocationReport(string AllocationDate, string Gender)
        {
            string[] arrRpt = new string[11];
            ListViewItem item;
            
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                                
                cn.Open();
                if((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date ='" + AllocationDate + "')";
                else
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date ='" + AllocationDate + "') AND (User_Gender ='" + Gender + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    arrRpt[0] = ((dr[0]).ToString()); //populate the system type
                    arrRpt[1] = ((dr[1]).ToString()); //populate the user type
                    arrRpt[2] = ((dr[2]).ToString()); //populate the user ID
                    arrRpt[3] = ((dr[3]).ToString()); //populate the User Name
                    arrRpt[4] = ((dr[4]).ToString()); //populate the Department
                    arrRpt[5] = ((dr[5]).ToString()); //populate the User Gender
                    arrRpt[6] = ((dr[6]).ToString()); //populate the Session 
                    arrRpt[7] = ((dr[7]).ToString()); //populate the Time-in 
                    arrRpt[8] = ((dr[8]).ToString()); //populate the Time-out 
                    arrRpt[9] = ((dr[9]).ToString()); //populate the Amount Charges
                    arrRpt[10] = ((dr[10]).ToString()); //populate the Other Services
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView1.Items.Add(item);
                }
                dr.Close();
                cn.Close();
                //Generate report base on Total no of System Allocated
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select Count(*), Sum(Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date ='" + AllocationDate + "') ";
                else
                    cmd.CommandText = "select Count(*), Sum(Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date ='" + AllocationDate + "') AND (User_Gender ='" + Gender + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTotalNoOfSystems.Text = ((dr[0]).ToString()); //populate the no of System Allocated                      
                    txtTotalAmountCharge.Text = string.Format("{0:N2}", dr[1]); //populate the sum of System Amount Charges 
                }
                
                dr.Close();
                cn.Close();
                //Generate report base on number of UserType (Student, Staff)
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date ='" + AllocationDate + "') GROUP BY User_Type";
                else
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date ='" + AllocationDate + "') AND (User_Gender ='" + Gender + "') GROUP BY User_Type";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                     string userType = ((dr[0]).ToString()); //get the user Type
                     if(userType == "Student") txtTotalNoOfStudents.Text = ((dr[1]).ToString()); //populate the total number of Students
                     else if (userType == "Staff") txtTotalNoOfStaff.Text = ((dr[1]).ToString()); //populate the total number of Staffs                    
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

        private void btnMonthlyView_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Items.Clear();
                txtMonthlyTotalSystems.Clear();
                txtMonthlyTotalStudents.Clear();
                txtMonthlyTotalStaff.Clear();
                if ((cboMonth.Text == "") || (cboYear.Text == ""))
                {
                    MessageBox.Show("Please specify the System Allocation Month and Year before you proceed", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    {
                        string mth = getMonthValue(cboMonth.Text);
                        string AllocationMonth = mth + "/%/" + cboYear.Text;
                        genMonthlyAllocationReport(AllocationMonth, cboMonthlyUserGender.Text);
                    }


                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string getMonthValue(string aMonth)
        {
            string monthValue = "1";
            switch (aMonth)
            {
                case "January":
                    monthValue = "1";
                break;
                case "February":
                    monthValue = "2";
                break;
                case "March":
                    monthValue = "3";
                break;
                case "April":
                    monthValue = "4";
                break;
                case "May":
                    monthValue = "5";
                break;
                case "June":
                    monthValue = "6";
                break;
                case "July":
                    monthValue = "7";
                break;
                case "August":
                    monthValue = "8";
                break;
                case "September":
                    monthValue = "9";
                break;
                case "October":
                    monthValue = "10";
                break;
                case "November":
                    monthValue = "11";
                break;
                case "December":
                    monthValue = "12";
                break;
            }
            return monthValue;
        }

        private void genMonthlyAllocationReport(string AllocationMonth, string Gender)
        {
            string[] arrRpt = new string[11];
            ListViewItem item;
            
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationMonth + "') ";
                else
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationMonth + "') AND (User_Gender = '" + Gender + "') ";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arrRpt[0] = ((dr[0]).ToString()); //populate the system type
                    arrRpt[1] = ((dr[1]).ToString()); //populate the user type
                    arrRpt[2] = ((dr[2]).ToString()); //populate the user ID
                    arrRpt[3] = ((dr[3]).ToString()); //populate the User Name
                    arrRpt[4] = ((dr[4]).ToString()); //populate the Department
                    arrRpt[5] = ((dr[5]).ToString()); //populate the User Gender
                    arrRpt[6] = ((dr[6]).ToString()); //populate the Session
                    arrRpt[7] = ((dr[7]).ToString()); //populate the Time-in
                    arrRpt[8] = ((dr[8]).ToString()); //populate the Time-out
                    arrRpt[9] = ((dr[9]).ToString()); //populate the Amount Charges
                    arrRpt[10] = ((dr[10]).ToString()); //populate the Other Services
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView2.Items.Add(item);
                }
                dr.Close();
                cn.Close();
                //Generate report base on Total no of System Allocated
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select Count(*), Sum( Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationMonth + "') ";
                else
                    cmd.CommandText = "select Count(*), Sum( Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationMonth + "') AND (User_Gender = '" + Gender + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtMonthlyTotalSystems.Text = ((dr[0]).ToString()); //Set the no of System Allocated 
                    txtMonthlyTotalAmount.Text = string.Format("{0:N2}", dr[1]);  //Set the total amount charges
                }

                dr.Close();
                cn.Close();
                //Generate report base on number of UserType (Student, Staff)
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationMonth + "') GROUP BY User_Type";
                else
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationMonth + "') AND (User_Gender = '" + Gender + "') GROUP BY User_Type";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    string userType = ((dr[0]).ToString()); //get the user Type
                    if (userType == "Student") txtMonthlyTotalStudents.Text = ((dr[1]).ToString()); //populate the total number of Students
                    else if (userType == "Staff") txtMonthlyTotalStaff.Text = ((dr[1]).ToString()); //populate the total number of Staffs                    
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

        private void btnYearlyView_Click(object sender, EventArgs e)
        {
            try
            {
                listView3.Items.Clear();
                txtYearlyTotalSystems.Clear();
                txtYearlyTotalStudents.Clear();
                txtYearlyTotalStaff.Clear();
                if ((cboAllocationYear.Text == ""))
                {
                    MessageBox.Show("Please specify the System Allocation Year before you proceed", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    {
                        string AllocationYear = "%/%/" + cboAllocationYear.Text;
                        genYearlyAllocationReport(AllocationYear, cboYearlyUserGender.Text);
                    }


                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genYearlyAllocationReport(string AllocationYear, string Gender)
        {
            string[] arrRpt = new string[11];
            ListViewItem item;
            
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationYear + "') ";
                else
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationYear + "') AND (User_Gender = '" + Gender + "') ";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arrRpt[0] = ((dr[0]).ToString()); //populate the system type
                    arrRpt[1] = ((dr[1]).ToString()); //populate the user type
                    arrRpt[2] = ((dr[2]).ToString()); //populate the user ID
                    arrRpt[3] = ((dr[3]).ToString()); //populate the User Name
                    arrRpt[4] = ((dr[4]).ToString()); //populate the Department
                    arrRpt[5] = ((dr[5]).ToString()); //populate the User Gender
                    arrRpt[6] = ((dr[6]).ToString()); //populate the Session
                    arrRpt[7] = ((dr[7]).ToString()); //populate the Time-in
                    arrRpt[8] = ((dr[8]).ToString()); //populate the Time-out
                    arrRpt[9] = ((dr[9]).ToString()); //populate the Amount Charges
                    arrRpt[10] = ((dr[10]).ToString()); //populate the Other Services
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView3.Items.Add(item);
                }
                dr.Close();
                cn.Close();
                //Generate report base on Total no of System Allocated
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select Count(*), Sum( Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationYear + "') ";
                else
                    cmd.CommandText = "select Count(*), Sum( Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationYear + "') AND (User_Gender = '" + Gender + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtYearlyTotalSystems.Text = ((dr[0]).ToString()); //populate the no of System Allocated                        
                    txtYearlyTotalAmount.Text = string.Format("{0:N2}", dr[1]);  //Set the sum of Amount Charges
                }
                dr.Close();
                cn.Close();
                //Generate report base on number of UserType (Student, Staff)
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationYear + "') GROUP BY User_Type";
                else
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date LIKE '" + AllocationYear + "') AND (User_Gender = '" + Gender + "') GROUP BY User_Type";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    string userType = ((dr[0]).ToString()); //get the user Type
                    if (userType == "Student") txtYearlyTotalStudents.Text = ((dr[1]).ToString()); //populate the total number of Students
                    else if (userType == "Staff") txtYearlyTotalStaff.Text = ((dr[1]).ToString()); //populate the total number of Staffs                    
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

        private void btnPeriodicView_Click(object sender, EventArgs e)
        {
            try
            {
                listView4.Items.Clear();
                txtPeriodicTotalSystems.Clear();
                txtPeriodicTotalStudents.Clear();
                txtPeriodicTotalStaff.Clear();
                if ((dtpStartDate.Text == "") || (dtpEndDate.Text == ""))
                {
                    MessageBox.Show("Please specify the System Start Date and End Date before you proceed", "System Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    {
                        //genPeriodicAllocationReport(dtpStartDate.Value.ToString(), dtpEndDate.Value.ToString());
                        genPeriodicAllocationReport(dtpStartDate.Text, dtpEndDate.Text, cboPeriodicUserGender.Text);
                    }
                }
            }
            catch (Exception Er)
            {
                MessageBox.Show(Er.Message, "System Allocation App. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genPeriodicAllocationReport(string startDate, string endDate, string Gender)
        {
            string[] arrRpt = new string[11];
            ListViewItem item;

            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                //cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, [Session], Timein, Timeout from tblSystemAllocation WHERE (Allocation_Date BETWEEN STR_TO_DATE('" + startDate + "','" + dateFormat + "') AND STR_TO_DATE('" + endDate + "','" + dateFormat + "'))";
                //cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, [Session], Timein, Timeout from tblSystemAllocation WHERE (Allocation_Date >= '" + startDate + "') AND (Allocation_Date <= '" + endDate + "')"; this query works fine or
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date BETWEEN '" + startDate + "' AND '" + endDate + "')";
                else
                    cmd.CommandText = "select System_Type, User_Type, User_ID, User_Name, Department, User_Gender, [Session], Timein, Timeout, Amount_Charges, Other_Services from tblSystemAllocation WHERE (Allocation_Date BETWEEN '" + startDate + "' AND '" + endDate + "') AND (User_Gender = '" + Gender + "')";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    arrRpt[0] = ((dr[0]).ToString()); //populate the system type
                    arrRpt[1] = ((dr[1]).ToString()); //populate the user type
                    arrRpt[2] = ((dr[2]).ToString()); //populate the user ID
                    arrRpt[3] = ((dr[3]).ToString()); //populate the User Name
                    arrRpt[4] = ((dr[4]).ToString()); //populate the Department
                    arrRpt[5] = ((dr[5]).ToString()); //populate the User Gender
                    arrRpt[6] = ((dr[6]).ToString()); //populate the Session
                    arrRpt[7] = ((dr[7]).ToString()); //populate the Time-in
                    arrRpt[8] = ((dr[8]).ToString()); //populate the Time-out
                    arrRpt[9] = ((dr[9]).ToString()); //populate the Amount Charges
                    arrRpt[10] = ((dr[10]).ToString()); //populate the Other Services
                    //add item into list
                    item = new ListViewItem(arrRpt);
                    listView4.Items.Add(item);
                }
                dr.Close();
                cn.Close();
                //Generate report base on Total no of System Allocated
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select Count(*), Sum( Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date BETWEEN '" + startDate + "' AND '" + endDate + "')";
                else
                    cmd.CommandText = "select Count(*), Sum( Amount_Charges) from tblSystemAllocation WHERE (Allocation_Date BETWEEN '" + startDate + "' AND '" + endDate + "') AND (User_Gender = '" + Gender + "')";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtPeriodicTotalSystems.Text = ((dr[0]).ToString()); //populate the no of System Allocated                        
                    txtPeriodicTotalAmount.Text = string.Format("{0:N2}", dr[1]);  //Set the total amount of Charges
                }

                dr.Close();
                cn.Close();
                //Generate report base on number of UserType (Student, Staff)
                cn.Open();
                if ((Gender.ToLower() != "male") && (Gender.ToLower() != "female"))
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date BETWEEN '" + startDate + "' AND '" + endDate + "') GROUP BY User_Type";
                else
                    cmd.CommandText = "select User_Type, Count(User_Type) from tblSystemAllocation WHERE (Allocation_Date BETWEEN '" + startDate + "' AND '" + endDate + "') AND (User_Gender = '" + Gender + "') GROUP BY User_Type";
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    string userType = ((dr[0]).ToString()); //get the user Type
                    if (userType == "Student") txtPeriodicTotalStudents.Text = ((dr[1]).ToString()); //populate the total number of Students
                    else if (userType == "Staff") txtPeriodicTotalStaff.Text = ((dr[1]).ToString()); //populate the total number of Staffs                    
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
    }
}
