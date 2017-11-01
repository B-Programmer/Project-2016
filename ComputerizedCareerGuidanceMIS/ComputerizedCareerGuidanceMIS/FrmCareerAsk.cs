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
    public partial class FrmCareerAsk : Form
    {
        public FrmCareerAsk()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmCareerAsk_Load(object sender, EventArgs e)
        {
            //loading the component of Career options
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
                cboStudentCareer.Items.Add("Accountancy");
                cboStudentCareer.Items.Add("Banking and Finance");
                cboStudentCareer.Items.Add("Business Studies");
                cboStudentCareer.Items.Add("Business Administration");
                cboStudentCareer.Items.Add("Marketing");
                cboStudentCareer.Items.Add("Secretariat Studies");
                cboStudentCareer.Items.Add("Electrical and Electronic Engineering");
                cboStudentCareer.Items.Add("Civil Engineering");
                cboStudentCareer.Items.Add("Mechanical Engineering");
                cboStudentCareer.Items.Add("Computer Engineering");
                cboStudentCareer.Items.Add("Agricultural Engineering");
                cboStudentCareer.Items.Add("Petroleum Engineering");
                cboStudentCareer.Items.Add("Mining Engineering");
                cboStudentCareer.Items.Add("Material and Metallurgical Engineering");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboStudentCareer.Text == "")
            {
                MessageBox.Show("Please select the choice of career", "Application Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmAboutCareer frmAboutCareer = new FrmAboutCareer(cboStudentCareer.Text);
                frmAboutCareer.Show();
                this.Hide();
            }

        }
    }
}
