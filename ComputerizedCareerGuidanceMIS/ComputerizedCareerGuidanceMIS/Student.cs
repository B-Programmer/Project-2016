using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ComputerizedCareerGuidanceMIS
{
    public class Student
    {
        private string studentName;
        private int studentAge;
        private string studentSex;
        private string studentClass;
        private string studentCategory;
        private string studentAddress;
        private string studentPhone;
        private OleDbConnection cn;
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private string studentCareer;
        private string studentReading;
        private string studentStudyTime;
        private string studentExtraCoaching;
        private string englishGrade;
        private string mathematicsGrade;
        private string subject1;
        private string subject1Grade;
        private string subject2;
        private string subject2Grade;
        private string subject3;
        private string subject3Grade;
        private string subject4;
        private string subject4Grade;


        public Student()
        {
             cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\CareerDb.accdb;Persist Security Info=True");
             //cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCareerGuidanceMIS\ComputerizedCareerGuidanceMIS\CareerDb.accdb");
             cmd = new OleDbCommand();
             cmd.Connection = cn;
        }

        public string StudentName
        {
            set
            {
                studentName = value;
            }
            get
            {
                return studentName;
            }
        }

        public int StudentAge
        {
            set
            {
                studentAge = value;
            }
            get
            {
                return studentAge;
            }
        }

        public string StudentSex
        {
            set
            {
                studentSex = value;
            }
            get
            {
                return studentSex;
            }
        }

        public string StudentClass
        {
            set
            {
                studentClass = value;
            }
            get
            {
                return studentClass;
            }
        }

        public string StudentCategory
        {
            set
            {
                studentCategory = value;
            }
            get
            {
                return studentCategory;
            }
        }

        public string StudentAddress
        {
            set
            {
                studentAddress = value;
            }
            get
            {
                return studentAddress;
            }
        }

        public string StudentPhone
        {
            set
            {
                studentPhone = value;
            }
            get
            {
                return studentPhone;
            }
        }

        public string StudentCareer
        {
            set
            {
                studentCareer = value;
            }
            get
            {
                return studentCareer;
            }
        }

        public string StudentReading
        {
            set
            {
                studentReading = value;
            }
            get
            {
                return studentReading;
            }
        }
        
        public string StudentStudyTime
        {
            set
            {
                studentStudyTime = value;
            }
            get
            {
                return studentStudyTime;
            }
        }
                       
        public string StudentExtraCoaching
        {
            set
            {
                studentExtraCoaching = value;
            }
            get
            {
                return studentExtraCoaching;
            }
        }

        public string EnglishGrade
        {
            set
            {
                englishGrade = value;
            }
            get
            {
                return englishGrade;
            }
        }

        public string MathematicsGrade
        {
            set
            {
                mathematicsGrade = value;
            }
            get
            {
                return mathematicsGrade;
            }
        }

        public string Subject1
        {
            set
            {
                subject1 = value;
            }
            get
            {
                return subject1;
            }
        }

        public string Subject1Grade
        {
            set
            {
                subject1Grade = value;
            }
            get
            {
                return subject1Grade;
            }
        }

        public string Subject2
        {
            set
            {
                subject2 = value;
            }
            get
            {
                return subject2;
            }
        }

        public string Subject2Grade
        {
            set
            {
                subject2Grade = value;
            }
            get
            {
                return subject2Grade;
            }
        }

        public string Subject3
        {
            set
            {
                subject3 = value;
            }
            get
            {
                return subject3;
            }
        }

        public string Subject3Grade
        {
            set
            {
                subject3Grade = value;
            }
            get
            {
                return subject3Grade;
            }
        }

        public string Subject4
        {
            set
            {
                subject4 = value;
            }
            get
            {
                return subject4;
            }
        }

        public string Subject4Grade
        {
            set
            {
                subject4Grade = value;
            }
            get
            {
                return subject4Grade;
            }
        }


        public void insertStudentData()
        {
            try
            {
                if (!isRegistered(studentName))
                {
                    cn.Open();
                    cmd.CommandText = "insert into tblStudent values('" + studentName + "', " + studentAge + ",'" + studentSex + "','" + studentClass + "','" + studentCategory + "','" + studentAddress + "','" + studentPhone + "','" + studentCareer + "','" + studentReading + "','" + studentStudyTime + "','" + studentExtraCoaching + "','" + englishGrade + "','" + mathematicsGrade + "','" + subject1 + "','" + subject1Grade + "','" + subject2 + "','" + subject2Grade + "','" + subject3 + "','" + subject3Grade + "','" + subject4 + "','" + subject4Grade + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student data successfully created!!!!", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                }
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.Message, "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isRegistered(string user)
        {
            bool isUserRegistered = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from TblStudent where Student_Name ='" + user + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //MessageBox.Show("Fail to change password!!! Username not exist. No user found ", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isUserRegistered = true;
                }
                
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Career Guidance App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserRegistered;

        }
    }
}
