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
    public partial class FrmUserType : Form
    {
        //private string userName;
        private string userType;
        private OleDbConnection cn;
        private OleDbCommand cmd;
        private OleDbDataReader dr;

        public FrmUserType()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\CareerDb.accdb;Persist Security Info=True");
            //cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCareerGuidanceMIS\ComputerizedCareerGuidanceMIS\CareerDb.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = cn;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.SeaShell;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite;
            
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(347, 153);
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text != "") && (txtPassword.Text != ""))
            {
                if (isValidateUser(txtUserName.Text, txtPassword.Text, userType))
                {
                    MessageBox.Show("Username and password validated successfully!!!", "Career Guidance App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (userType != "Administrator")
                    {
                        SaveLogDetails(txtUserName.Text, userType);
                        this.Hide();
                        FrmStudentDetails frmStudentDetails = new FrmStudentDetails(txtUserName.Text, userType);
                        frmStudentDetails.Show();                                                
                    }
                    else
                    {
                        this.Hide();
                        MDICareer f1 = new MDICareer(txtUserName.Text, userType);
                        f1.Show();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Username or password validation failed, please type correct username or password", "Career Guidance App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User name or password cannot be emptied, please type username or password", "Career Guidance App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValidateUser(string user, string pass, string userType)
        {
            bool validate = false;
            try
            {
                cn.Open();
                if (userType == "Administrator")
                {
                    cmd.CommandText = "select UserName, UserPassword from tblUser where UserName = '" + user + "' and UserPassword = '" + pass + "'";
                }
                else if ((userType == "Student") ||(userType == "Parents/Guardian"))
                {
                    cmd.CommandText = "select UserName, UserPassword from TblUser where UserName = '" + user + "' AND UserPassword = '" + pass + "'";
                }
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    validate = true;
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
            return validate;
        }
        
        private void SaveLogDetails(string uName, string uType)
        {
            try
            {
                //if ((isAllEntryFilled()) && (!isRegistered(txtUserName.Text)))
                {
                    string DateLogin = DateTime.Now.ToLongDateString();
                    string Timein = DateTime.Now.ToLongTimeString();
                    string Timeout = "Timeout";

                    cn.Open();
                    cmd.CommandText = "insert into TblUserLog values('" + uType + "','" + uName + "','" + DateLogin + "','" + Timein + "','" + Timeout + "')";
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

        private void btnStudent_Click(object sender, EventArgs e)
        {
            userType = "Student";
            lblUsername.Text = "Username:";
            lblPassword.Text = "User Password:";
            linkLabel1.Visible = true;

            panel1.Visible = true; 
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Location = new Point(362, 183);
            
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            userType = "Parents/Guardian";
            lblUsername.Text = "Username:";
            lblPassword.Text = "User Password:";
            linkLabel1.Visible = true;

            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Location = new Point(362, 183);            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            userType = "Administrator";
            lblUsername.Text = "Admin Username:";
            lblPassword.Text = "Admin Password:";
            linkLabel1.Visible = false;
            
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Location = new Point(362, 183);            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel3.Location = new Point(365, 183);
            txtUserType.Text = userType;
        }

        private void FrmUserType_Load(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.SeaShell;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite;
            
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(347, 153);
        }

        private void btnStudent_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
            btnHome.ForeColor = Color.GhostWhite;

            btnStudent.BackColor = Color.Gray;
            btnStudent.ForeColor = Color.SeaShell;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnAboutUs.BackColor = Color.Black;
            btnAboutUs.ForeColor = Color.GhostWhite;
            
            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite;
        }

        private void btnParents_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
            btnHome.ForeColor = Color.GhostWhite;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Gray;
            btnParents.ForeColor = Color.SeaShell; 

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnAboutUs.BackColor = Color.Black;
            btnAboutUs.ForeColor = Color.GhostWhite;
            
            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite;
        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
            btnHome.ForeColor = Color.GhostWhite;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Gray;
            btnAdmin.ForeColor = Color.SeaShell;

            btnAboutUs.BackColor = Color.Black;
            btnAboutUs.ForeColor = Color.GhostWhite;
            
            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnQuit_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
            btnHome.ForeColor = Color.GhostWhite;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnAboutUs.BackColor = Color.Black;
            btnAboutUs.ForeColor = Color.GhostWhite;
            
            btnQuit.BackColor = Color.Gray;
            btnQuit.ForeColor = Color.SeaShell; 
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gray;
            btnHome.ForeColor = Color.SeaShell;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnAboutUs.BackColor = Color.Black;
            btnAboutUs.ForeColor = Color.GhostWhite;
            
            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(347, 153);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if ((isAllEntryFilled()) && (!isRegistered(txtNewUsername.Text)))
                {
                    string Username = txtNewUsername.Text;
                    string Password = txtNewPassword.Text;
                    //string UserType = "Administrator";

                    cn.Open();
                    cmd.CommandText = "insert into TblUser values('" + userType + "','" + Username + "','" + Password + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User has been successfully Created!!!", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtNewUsername.Text == ""))
            {
                MessageBox.Show("Please enter the username", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewUsername.Focus();
                return isEntryFilled;
            }
            else if ((txtNewPassword.Text == ""))
            {
                MessageBox.Show("Please enter the User Password", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewPassword.Focus();
                return isEntryFilled;
            }
            else if ((txtConfirmPassword.Text == ""))
            {
                MessageBox.Show("Please enter the user confirm password", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmPassword.Focus();
                return isEntryFilled;
            }
            else if ((txtNewPassword.Text != txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password mismatch. Please retype either password or confirm password", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewPassword.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }

        private bool isRegistered(string user)
        {
            bool isUserRegistered = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from TblUser where UserName = '" + user + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Fail to create user, username already exists. Duplicate user found ", "Career Guidance App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Location = new Point(362, 183);

            lblUsername.Text = "Username:";
            lblPassword.Text = "User Password:";
            linkLabel1.Visible = true;            
        }

        private void btnAboutUs_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Black;
            btnHome.ForeColor = Color.GhostWhite;

            btnStudent.BackColor = Color.Black;
            btnStudent.ForeColor = Color.GhostWhite;

            btnParents.BackColor = Color.Black;
            btnParents.ForeColor = Color.GhostWhite;

            btnAdmin.BackColor = Color.Black;
            btnAdmin.ForeColor = Color.GhostWhite;

            btnAboutUs.BackColor = Color.Gray;
            btnAboutUs.ForeColor = Color.SeaShell; 

            btnQuit.BackColor = Color.Black;
            btnQuit.ForeColor = Color.GhostWhite; 
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutApp aboutUs = new AboutApp();
            aboutUs.Show(); 
        }        
    }
}
