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
    public partial class FrmCareerResult : Form
    {
        string userName;
        string userType;
        Student student;
        private OleDbConnection cn;
        private OleDbCommand cmd;
        //private OleDbDataReader dr;
        
        public FrmCareerResult()
        {
            InitializeComponent();
        }

        public FrmCareerResult(string uName, string uType, Student stdt)
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

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            UpdateLogDetails(userName, userType);
            this.Hide();
            FrmUserType f1 = new FrmUserType();
            f1.Show();
        }

        private void UpdateLogDetails(string uName, string uType)
        {
            try
            {
                //if ((isAllEntryFilled()) && (!isRegistered(txtUserName.Text)))
                {
                    string Timeout = "Timeout";

                    cn.Open();
                    cmd.CommandText = "Update TblUserLog  Set Time_Out ='" + DateTime.Now.ToLongTimeString() + "' Where (User_Name = '" + uName + "') AND (User_Type ='" + uType + "') AND (Time_Out ='" + Timeout + "')";
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("New User has been successfully Created!!!", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCareerResult_Load(object sender, EventArgs e)
        {
            LblStudentName.Text = student.StudentName;
            LblAge.Text = student.StudentAge.ToString();
            LblGender.Text = student.StudentSex;
            LblCareer.Text = student.StudentCareer;
            string studentReading = student.StudentReading;
            string studentStudyTime = student.StudentStudyTime;
            string studentExtraCoaching = student.StudentExtraCoaching;
            string englishGrade = student.EnglishGrade;
            string mathematicsGrade = student.MathematicsGrade;
            string subject1 = student.Subject1;
            string subject1Grade = student.Subject1Grade;
            string subject2 = student.Subject2;
            string subject2Grade = student.Subject2Grade;
            string subject3 = student.Subject3;
            string subject3Grade = student.Subject3Grade;
            string subject4 = student.Subject4;
            string subject4Grade = student.Subject4Grade;
            bool blnEnglish = (englishGrade == "Excellent") || (englishGrade == "Very Good") || (englishGrade == "Good");
            bool blnMathematics = (mathematicsGrade == "Excellent") || (mathematicsGrade == "Very Good") || (mathematicsGrade == "Good");
            bool blnSubject1 = (subject1Grade == "Excellent") || (subject1Grade == "Very Good") || (subject1Grade == "Good");
            bool blnSubject2 = (subject2Grade == "Excellent") || (subject2Grade == "Very Good") || (subject2Grade == "Good");
            bool blnSubject3 = (subject3Grade == "Excellent") || (subject3Grade == "Very Good") || (subject3Grade == "Good");
            bool blnSubject4 = (subject4Grade == "Excellent") || (subject4Grade == "Very Good") || (subject4Grade == "Good");
            //MessageBox.Show("English Grade: " + englishGrade);
            
            TxtCareerAdvice.Text = "Career Guidance and Counseling Assessment Results " + "\r\n===========================================================";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n\r\nDear " + LblStudentName.Text + ",";
            //if (((englishGrade == "Excellent") && (mathematicsGrade == "Excellent") && (subject1Grade == "Excellent") && (subject2Grade == "Excellent") && (subject3Grade == "Excellent") && (subject4Grade == "Excellent")))
            if (blnEnglish && blnMathematics && blnSubject1 && blnSubject2 && blnSubject3 && blnSubject4)
            {
                
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\nI am pleased to inform you that your intending choice of career, " + LblCareer.Text + "is suitable for you due to the following reasons:";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Your Performance in the selected career courses(subjects) is Satisfactory.";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* English Language Grade is " + englishGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Mathematics Grade is " + mathematicsGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject1 + " Grade is " + subject1Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject2 + " Grade is " + subject2Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject3 + " Grade is " + subject3Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject4 + " Grade is " + subject4Grade;
            }
            else if ((blnEnglish && blnMathematics && blnSubject1 && blnSubject2 && blnSubject3) || (blnEnglish && blnMathematics && blnSubject1 && blnSubject2 && blnSubject4) || (blnEnglish && blnMathematics && blnSubject2 && blnSubject3 && blnSubject4))
            {

                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\nI am pleased to inform you that your intending choice of career, " + LblCareer.Text + "is suitable for you due to the following reasons:";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Your Performance in the selected career courses(subjects) is Satisfactory.";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* English Language Grade is " + englishGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Mathematics Grade is " + mathematicsGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject1 + " Grade is " + subject1Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject2 + " Grade is " + subject2Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject3 + " Grade is " + subject3Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject4 + " Grade is " + subject4Grade;
            }
            else if ((blnEnglish && blnMathematics && blnSubject1 && blnSubject2) || (blnEnglish && blnMathematics && blnSubject1 && blnSubject3) || (blnEnglish && blnMathematics && blnSubject1 && blnSubject4) || (blnEnglish && blnMathematics && blnSubject2 && blnSubject3) || (blnEnglish && blnMathematics && blnSubject2 && blnSubject4) || (blnEnglish && blnMathematics && blnSubject3 && blnSubject4))
            {

                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\nI am pleased to inform you that your intending choice of career, " + LblCareer.Text + "is suitable for you due to the following reasons:";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Your Performance in the selected career courses(subjects) is Satisfactory.";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* English Language Grade is " + englishGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Mathematics Grade is " + mathematicsGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject1 + " Grade is " + subject1Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject2 + " Grade is " + subject2Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject3 + " Grade is " + subject3Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject4 + " Grade is " + subject4Grade;
            }
            else
            {
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\nI am sorry to inform you that your intending choice of career, " + LblCareer.Text + "is not suitable for you due to the following reasons:";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Your Performance in the selected career courses(subjects) is not Satisfactory.";
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* English Language Grade is " + englishGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Mathematics Grade is " + mathematicsGrade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject1 + " Grade is " + subject1Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject2 + " Grade is " + subject2Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject3 + " Grade is " + subject3Grade;
                TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* " + subject4 + " Grade is " + subject4Grade;
            }
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n\r\nThe Following pieces of advice are recommended for you:";
            if(!blnEnglish) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need more study on English Language.";
            if (!blnMathematics) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need more study on Mathematics.";
            if (!blnSubject1) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need more study on "+ subject1 +".";
            if (!blnSubject2) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need more study on " + subject2 + ".";
            if (!blnSubject3) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need more study on " + subject3 + ".";
            if (!blnSubject4) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need more study on " + subject4 + ".";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need always attend class during school lecture time.";
            if (studentExtraCoaching == "No") TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You may attend lesson or extra-coaching or tutorial class after school during the week or every weekend.";
            if ((studentStudyTime == "Less than 1 hours") || (studentStudyTime == "1 hours") || (studentStudyTime == "2 hours") || (studentStudyTime == "3 hours") || (studentStudyTime == "4 hours")) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need to spend more time on reading per day.";
            if ((studentReading == "Frequently") || (studentReading == "Every Day") || (studentReading == "Every Night") || (studentReading == "Every Weekend")) TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You need to spend little or no time on social media networks per day.";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You are advice to strongly seek higher education.";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\nNB: Just because you are(or not) suitable for this career course, does not mean you will not be successful with a career in another, you can always choose other career courses if you wish.";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\nGenerally, the individual student should develop abilities such as the following:";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Self Knowledge";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Ability to opportunity pursuit";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Action Planning";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Interests, personality and action combination";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Negotiation ability";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Acceptance and confrontation of social/economic uncertainty(NOTHING IS PERMANENT)";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Flexibility";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Development view of life, education and action";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* Political awareness.";
            TxtCareerAdvice.Text = TxtCareerAdvice.Text + "\r\n* You can click on About Career button to know more about the career of your choice.";

            //parents and guardians should send comments or feedback
            if (userType == "Parents/Guardian")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAboutCareer frmAboutCareer = new FrmAboutCareer(student);
            frmAboutCareer.Show();
        }

        private void CmdPrintTreatment_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmComments ParentComments = new FrmComments(userName, userType, student);
            ParentComments.Show();
        }
    }
}
