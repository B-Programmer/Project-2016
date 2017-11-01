using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCareerGuidanceMIS
{
    public partial class FrmExamination1 : Form
    {
        string userName;
        string userType;
        Student student;
        public FrmExamination1(string uName, string uType, Student stdt)
        {
            InitializeComponent();
            userName = uName;
            userType = uType;
            student = stdt;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void FrmExamination1_Load(object sender, EventArgs e)
        {
            //loading the component of Career options
            if (student.StudentCategory == "Science")
            {
                cboStudentCareer.Text = "Computer Science";
                cboStudentCareer.Items.Add("Medicine");
                cboStudentCareer.Items.Add("Pharmacy");
                cboStudentCareer.Items.Add("Biochemistry");
                cboStudentCareer.Items.Add("Computer Science");
                cboStudentCareer.Items.Add("Industrial Chemistry");
                cboStudentCareer.Items.Add("Industrial Mathematics");
                cboStudentCareer.Items.Add("Microbiology");
                cboStudentCareer.Items.Add("Physics Electronics");
                cboStudentCareer.Items.Add("Science Laboratory Technology");
                cboStudentCareer.Items.Add("Statistics");
                cboStudentCareer.Items.Add("Food Science Technology");
                cboStudentCareer.Items.Add("Library Information Science");
                cboStudentCareer.Items.Add("Telecommunication Science");
                cboStudentCareer.Items.Add("Information and Communication Science");
                cboStudentCareer.Items.Add("Electrical and Electronic Engineering");
                cboStudentCareer.Items.Add("Civil Engineering");
                cboStudentCareer.Items.Add("Mechanical Engineering");
                cboStudentCareer.Items.Add("Computer Engineering");
                cboStudentCareer.Items.Add("Agricultural Engineering");
                cboStudentCareer.Items.Add("Petroleum Engineering");
                cboStudentCareer.Items.Add("Mining Engineering");
                cboStudentCareer.Items.Add("Material and Metallurgical Engineering");
            }
            else if (student.StudentCategory == "Commercial")
            {
                cboStudentCareer.Text = "Accountancy";
                cboStudentCareer.Items.Add("Accountancy");
                cboStudentCareer.Items.Add("Banking and Finance");
                cboStudentCareer.Items.Add("Business Studies");
                cboStudentCareer.Items.Add("Business Administration");
                cboStudentCareer.Items.Add("Marketing");
                cboStudentCareer.Items.Add("Secretariat Studies");
            }
            else if (student.StudentCategory == "Arts/Social Science")
            {
                cboStudentCareer.Text = "Mass Communication";
                cboStudentCareer.Items.Add("Mass Communication");
                cboStudentCareer.Items.Add("Architecture");
                cboStudentCareer.Items.Add("Estate Management");
                cboStudentCareer.Items.Add("Quantity Surveying");
                cboStudentCareer.Items.Add("Building Technology");
                cboStudentCareer.Items.Add("Urban and Regional Planning");
                cboStudentCareer.Items.Add("Law");
                cboStudentCareer.Items.Add("Psychology");
                cboStudentCareer.Items.Add("Industrial Design");
            }
        }

        private void cboStudentCareer_Leave(object sender, EventArgs e)
        {
            //set career courses for science students
            if ((cboStudentCareer.Text == "Industrial Chemistry") || (cboStudentCareer.Text == "Food Science Technology") || (cboStudentCareer.Text == "Science Laboratory Technology"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Physics";
                lblSubject3.Text = "Biology"; lblSubject4.Text = "Economics";    
            }
            else if ((cboStudentCareer.Text == "Medicine") || (cboStudentCareer.Text == "Pharmacy") || (cboStudentCareer.Text == "Biochemistry") || (cboStudentCareer.Text == "Microbiology"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Physics";
                lblSubject3.Text = "Biology"; lblSubject4.Text = "Agricultural Science";    
            }
            else if ((cboStudentCareer.Text == "Computer Science") || (cboStudentCareer.Text == "Library Information Science") || (cboStudentCareer.Text == "Telecommunication Science") || (cboStudentCareer.Text == "Information and Communication Science"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Physics";
                lblSubject3.Text = "Biology"; lblSubject4.Text = "Computer Studies";    
            }
            else if ((cboStudentCareer.Text == "Physics Electronics") || (cboStudentCareer.Text == "Statistics") || (cboStudentCareer.Text == "Industrial Mathematics"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Physics";
                lblSubject3.Text = "Further Mathematics"; lblSubject4.Text = "Economics";
            }
            //set career courses for Technical students
            else if ((cboStudentCareer.Text == "Electrical and Electronic Engineering") || (cboStudentCareer.Text == "Civil Engineering") || (cboStudentCareer.Text == "Mechanical Engineering") || (cboStudentCareer.Text == "Computer Engineering"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Physics";
                lblSubject3.Text = "Technical Drawing"; lblSubject4.Text = "Further Mathematics";
            }
            else if ((cboStudentCareer.Text == "Agricultural Engineering") || (cboStudentCareer.Text == "Petroleum Engineering") || (cboStudentCareer.Text == "Mining Engineering") || (cboStudentCareer.Text == "Material and Metallurgical Engineering"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Physics";
                lblSubject3.Text = "Technical Drawing"; lblSubject4.Text = "Further Mathematics";
            }
            //set career courses for Commercial students
            else if ((cboStudentCareer.Text == "Accountancy") || (cboStudentCareer.Text == "Banking and Finance") || (cboStudentCareer.Text == "Business Administration") || (cboStudentCareer.Text == "Marketing"))
            {
                lblSubject1.Text = "Financial Accounting"; lblSubject2.Text = "Commerce";
                lblSubject3.Text = "Economics"; lblSubject4.Text = "Government";
            }
            else if ((cboStudentCareer.Text == "Business Studies") ||(cboStudentCareer.Text == "Secretariat Studies"))
            {
                lblSubject1.Text = "Financial Accounting"; lblSubject2.Text = "Commerce";
                lblSubject3.Text = "Book Keeping"; lblSubject4.Text = "Shorthand";
            }
            //set career courses for Social Science and Arts students
            else if ((cboStudentCareer.Text == "Mass Communication") || (cboStudentCareer.Text == "Law") || (cboStudentCareer.Text == "Psychology"))
            {
                lblSubject1.Text = "Literature in English"; lblSubject2.Text = "History";
                lblSubject3.Text = "Economics"; lblSubject4.Text = "Government";
            }
            else if ((cboStudentCareer.Text == "Architecture") || (cboStudentCareer.Text == "Estate Management") || (cboStudentCareer.Text == "Quantity Surveying") || (cboStudentCareer.Text == "Building Technology") || (cboStudentCareer.Text == "Urban and Regional Planning") || (cboStudentCareer.Text == "Industrial Design"))
            {
                lblSubject1.Text = "Chemistry"; lblSubject2.Text = "Geography";
                lblSubject3.Text = "Economics"; lblSubject4.Text = "Government";
            }
            
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            if (lblSubject1.Text == "")
            {
                MessageBox.Show("Please select the student choice of career", "Empty Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                student.StudentCareer = cboStudentCareer.Text;
                student.StudentReading = cboReading.Text;
                student.StudentStudyTime = cboStudyTime.Text;
                student.StudentExtraCoaching = cboExtraCoaching.Text;
                student.EnglishGrade = cboEnglishGrade.Text;
                student.MathematicsGrade = cboMathematicsGrade.Text;
                student.Subject1 = lblSubject1.Text;
                student.Subject1Grade = cboGrade1.Text;
                student.Subject2 = lblSubject2.Text;
                student.Subject2Grade = cboGrade2.Text;
                student.Subject3 = lblSubject3.Text;
                student.Subject3Grade = cboGrade3.Text;
                student.Subject4 = lblSubject4.Text;
                student.Subject4Grade = cboGrade4.Text;
                student.insertStudentData(); //store all the student's information 
                this.Hide();
                FrmCareerResult frmCareerResult = new FrmCareerResult(userName, userType, student);
                frmCareerResult.Show();                
            }
            
        }

        
                
    }
}
