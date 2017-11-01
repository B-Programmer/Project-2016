using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PensionVerificationSystem
{
    public partial class FrmPensionPayment : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public FrmPensionPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboPensionerId.ResetText();
            txtPensionerFullname.ResetText();
            txtMonthlyPensionPayment.ResetText();
            txtPensionArears.ResetText();
            dtpDateOfLastPayment.ResetText();
            txtGrativityInArears.ResetText();
            dtpDateDueForPayment.ResetText();
            cboInitialMonth.ResetText();
            cboInitialYear.ResetText();
            txtBankName.ResetText();
            txtAccountNumber.ResetText();
        }

        private void FrmPensionPayment_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            loadPensionerId();
        }

        private void loadPensionerId()
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select UniquePensionerId from tblPensionerEnrollment";
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                   cboPensionerId.Items.Add(dr["UniquePensionerId"].ToString());
                }
                dr.Close();
                cn.Close();                
            }
            catch(Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void getPensionerDetails(string id)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select PensionerFullname, CurrentMonthlyPension, BankName, AccountNumber from tblPensionerEnrollment where UniquePensionerId = '" + id + "'";
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    txtPensionerFullname.Text = (dr["PensionerFullname"].ToString()); 
                    txtPensionerFullname.Enabled = false;
                    txtMonthlyPensionPayment.Text = (dr["CurrentMonthlyPension"].ToString());
                    txtMonthlyPensionPayment.Enabled = false;
                    txtBankName.Text = (dr["BankName"].ToString());
                    txtBankName.Enabled = false;
                    txtAccountNumber.Text = (dr["AccountNumber"].ToString());
                    txtAccountNumber.Enabled = false;
                }
                dr.Close();
                cn.Close();                
            }
            catch(Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cboPensionerId_Leave(object sender, EventArgs e)
        {
            if (cboPensionerId.Text != "") 
            {
                getPensionerDetails(cboPensionerId.Text);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((isAllEntryFilled()) && (!isRegistered(cboPensionerId.Text)))
                {
                    string PensionerId = cboPensionerId.Text;
                    string PensionerFullname = txtPensionerFullname.Text;
                    double MonthlyPensionPayment = Convert.ToDouble(txtMonthlyPensionPayment.Text);
                    double PensionArears = Convert.ToDouble(txtPensionArears.Text);
                    string DateOfLastPayment = dtpDateOfLastPayment.Text;
                    double GrativityInArears = Convert.ToDouble(txtGrativityInArears.Text);
                    string DateDueForPayment = dtpDateDueForPayment.Text;
                    string InitialMonth = cboInitialMonth.Text;
                    string InitialYear = cboInitialYear.Text;
                    string BankName = txtBankName.Text;
                    string AccountNumber = txtAccountNumber.Text;

                    cn.Open();
                    cmd.CommandText = "insert into tblPensionPayment values('" + PensionerId + "','" + PensionerFullname + "'," + MonthlyPensionPayment + "," + PensionArears + ",'" + DateOfLastPayment + "'," + GrativityInArears + ",'" + DateDueForPayment + "','" + InitialMonth + "','" + InitialYear + "','" + BankName + "','" + AccountNumber + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Pensioner Payment Information successfully saved!!!", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.CommandText = "insert into tblMonthlyVerification values('" + PensionerId + "','" + PensionerFullname + "'," + MonthlyPensionPayment + ",'" + InitialMonth + "','" + InitialYear + "','" + BankName + "','" + AccountNumber + "','" + DateDueForPayment + "', 'Verified')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Pensioner Payment has been verified for this month: " + InitialMonth + " in the year: " + InitialYear, "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    btnRefresh_Click(sender, e);
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((cboPensionerId.Text == "")||(txtPensionerFullname.Text == "") || (txtMonthlyPensionPayment.Text == ""))
            {
                MessageBox.Show("Please select the Pensioner's Id", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPensionerId.Focus();
                return isEntryFilled;
            }
            else if ((dtpDateOfLastPayment.Text == ""))
            {
                MessageBox.Show("Please set the Pensioner's Date of Last Payment", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDateOfLastPayment.Focus();
                return isEntryFilled;
            }
            else if ((txtPensionArears.Text == ""))
            {
                MessageBox.Show("Please enter the Pensioner's Pension Arears", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPensionArears.Focus();
                return isEntryFilled;
            }
            else if ((dtpDateDueForPayment.Text == ""))
            {
                MessageBox.Show("Please set the Pensioner's Date Due for Payment ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDateDueForPayment.Focus();
                return isEntryFilled;
            }
            else if ((cboInitialMonth.Text == ""))
            {
                MessageBox.Show("Please select the Initial Month ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboInitialMonth.Focus();
                return isEntryFilled;
            }
            else if ((cboInitialYear.Text == ""))
            {
                MessageBox.Show("Please select the Initial Year ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboInitialYear.Focus();
                return isEntryFilled;
            }
            else
                return true;
            
        }

        private bool isRegistered(string pension_id)
        {
            bool isUserRegistered = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblPensionPayment where PensionerId ='" + pension_id + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Pensioner's ID already exists.");
                    isUserRegistered = true;
                }
                dr.Close();
                cn.Close();               
            }
            catch(Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return isUserRegistered;
        
        }
       

        
    }
}
