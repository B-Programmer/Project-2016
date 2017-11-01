using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCareerGuidanceMIS
{
    public partial class FrmComments : Form
    {
        string userName;
        string userType;
        Student student;
        private OleDbConnection cn;
        private OleDbCommand cmd;

        public FrmComments(string uName, string uType, Student stdt)
        {
            InitializeComponent();
            userName = uName;
            userType = uType;
            student = stdt;
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\CareerDb.accdb;Persist Security Info=True");
            //cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCareerGuidanceMIS\ComputerizedCareerGuidanceMIS\CareerDb.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = cn;
        }

        private void FrmComments_Load(object sender, EventArgs e)
        {
            LblStudentName.Text = student.StudentName;
            LblUsername.Text = userName;
            LblUserType.Text = userType;
            LblCareer.Text = student.StudentCareer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCareerAdvice.Text == "")
                {
                    MessageBox.Show("Operation not successfully, Please type your Comments", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCareerAdvice.Focus();
                }
                else if (txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Operation not successfully, Please type your Phone Number", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Focus();
                }
                else if (txtEmailAddress.Text == "")
                {
                    MessageBox.Show("Operation not successfully, Please type your Email Address", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();
                }
                else
                {
                    string PhoneNo = txtPhoneNumber.Text;
                    string EmailAddress = txtEmailAddress.Text;
                    string Comments = TxtCareerAdvice.Text;
                    cn.Open();
                    cmd.CommandText = "insert into TblComments values('" + userType + "', '" + userName + "','" + student.StudentName + "','" + student.StudentCareer + "','" + Comments + "','" + DateTime.Now.ToString() + "','" + EmailAddress + "','" + PhoneNo + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Comments/Feedback has been successfully sent!!! Thank for using this application", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                }
            }
            catch (OleDbException er)
            {
                MessageBox.Show(er.Message, "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
