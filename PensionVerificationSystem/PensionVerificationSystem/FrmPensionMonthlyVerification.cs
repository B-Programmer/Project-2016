using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PensionVerificationSystem
{
    public partial class FrmPensionMonthlyVerification : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbPension.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\PensionVerificationSystem\PensionVerificationSystem\dbPension.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private string pensionerId;
        
        public FrmPensionMonthlyVerification(string pensionId)
        {
            InitializeComponent();
            pensionerId = pensionId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmPensionMonthlyVerification_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            retrievePensionPaymentInfo(pensionerId);
            txtPensionerId.Text = pensionerId;
        }

        private void retrievePensionPaymentInfo(string pensionId)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select PensionerFullname, CurrentMonthlyPension, VerificationMonth, VerificationYear, BankName, AccountNumber from tblMonthlyVerification where PensionerId = '" + pensionId + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtPensionerFullname.Text = (dr["PensionerFullname"].ToString());
                    txtPensionerFullname.Enabled = false;
                    txtMonthlyPensionPayment.Text = (dr["CurrentMonthlyPension"].ToString());
                    txtMonthlyPensionPayment.Enabled = true;
                    cboVerificationMonth.Text = (dr["VerificationMonth"].ToString());
                    cboVerificationYear.Text = (dr["VerificationYear"].ToString());
                    txtBankName.Text = (dr["BankName"].ToString());
                    //txtBankName.Enabled = false;
                    txtAccountNumber.Text = (dr["AccountNumber"].ToString());
                    //txtAccountNumber.Enabled = false;

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string PensionerId = txtPensionerId.Text;
                    string PensionerFullname = txtPensionerFullname.Text;
                    double MonthlyPensionPayment = Convert.ToDouble(txtMonthlyPensionPayment.Text);
                    string DateDueForPayment = dtpDateDueForPayment.Text;
                    string VerificationMonth = cboVerificationMonth.Text;
                    string VerificationYear = cboVerificationYear.Text;
                    string BankName = txtBankName.Text;
                    string AccountNumber = txtAccountNumber.Text;
                    if (!isRegistered(PensionerId, VerificationMonth, VerificationYear))
                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblMonthlyVerification values('" + PensionerId + "','" + PensionerFullname + "'," + MonthlyPensionPayment + ",'" + VerificationMonth + "','" + VerificationYear + "','" + BankName + "','" + AccountNumber + "','" + DateDueForPayment + "', 'Verified')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Pensioner Payment has been verified for this month: " + VerificationMonth + " in the year: " + VerificationYear, "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                    }
                    
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

            if ((txtMonthlyPensionPayment.Text == ""))
            {
                MessageBox.Show("Please enter the Pensioner's current monthly pension", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonthlyPensionPayment.Focus();
                return isEntryFilled;
            }
            else if ((txtBankName.Text == ""))
            {
                MessageBox.Show("Please enter the Pensioner's Bank Name", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBankName.Focus();
                return isEntryFilled;
            }
            else if ((txtAccountNumber.Text == ""))
            {
                MessageBox.Show("Please enter the Pensioner's Account Number", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccountNumber.Focus();
                return isEntryFilled;
            }
            else if ((dtpDateDueForPayment.Text == ""))
            {
                MessageBox.Show("Please set the Pensioner's Date Due for Payment ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDateDueForPayment.Focus();
                return isEntryFilled;
            }
            else if ((cboVerificationMonth.Text == ""))
            {
                MessageBox.Show("Please select the Verification Month ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboVerificationMonth.Focus();
                return isEntryFilled;
            }
            else if ((cboVerificationYear.Text == ""))
            {
                MessageBox.Show("Please select the Verification Year ", "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboVerificationYear.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }

        private bool isRegistered(string pension_id, string vMonth, string vYear)
        {
            bool isUserRegistered = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from tblMonthlyVerification where PensionerId ='" + pension_id + "' and VerificationMonth ='" + vMonth + "' and VerificationYear = '" + vYear + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Pensioner with this Pensioner's ID and information has already been verified for this month: " +vMonth + " in the year: " +vYear, "Pension Verification App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isUserRegistered = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Pension Verification App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserRegistered;

        }
    }
}
