using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ComputerizedCareerGuidanceMIS
{
    public partial class FrmStudentDetails : Form
    {
        string userName;
        string userType;
        Student student;
       // private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\CareerDb.accdb;Persist Security Info=True");
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCareerGuidanceMIS\ComputerizedCareerGuidanceMIS\CareerDb.accdb");
        private OleDbCommand cmd = new OleDbCommand();

        public FrmStudentDetails(string uName, string uType)
        {
            InitializeComponent();
            userName = uName;
            userType = uType;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            if ((txtStudentName.Text == "") || (txtStudentAge.Text == "") || (txtStudentAddress.Text == "") || (txtStudentPhoneNo.Text == ""))
            {
                MessageBox.Show("Please fill all student details before you proceed", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //create a class student
                student = new Student();
                student.StudentName = txtStudentName.Text;
                student.StudentAge = Convert.ToInt16(txtStudentAge.Text);
                student.StudentSex = cboStudentSex.Text;
                student.StudentClass = cboStudentClass.Text;
                student.StudentCategory = cboCategoryOfStudent.Text;
                student.StudentAddress = txtStudentAddress.Text;
                student.StudentPhone = txtStudentPhoneNo.Text;
                //student.insertStudentData();
                this.Hide();
                FrmExamination1 frmExamination1 = new FrmExamination1(userName, userType, student);
                frmExamination1.Show();                
            }
        }
    }
}
