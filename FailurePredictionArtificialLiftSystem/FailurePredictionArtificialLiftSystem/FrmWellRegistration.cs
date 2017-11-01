using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FailurePredictionArtificialLiftSystem
{
    public partial class FrmWellRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbArtificialLift.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();

        public FrmWellRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string WellID = txtWellID.Text;
                    string WellPermit = txtWellPermit.Text;
                    string OperatorName = txtOperatorName.Text;
                    string Field = txtField.Text;
                    string Country = cboCountry.Text;
                    string Location = cboLocation.Text;
                    string WellName = txtWellName.Text;
                    string WellStatus = cboWellStatus.Text;
                    string WellType = cboWellType.Text;
                    string FlowType = cboFlowType.Text;

                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblWellReg values('" + WellID + "','" + WellPermit + "','" + OperatorName + "','" + Field + "','" + Country + "','" + Location + "','" + WellName + "','" + WellStatus + "','" + WellType + "','" + FlowType + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Well Registration Details Successfully Saved!!!", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        btnRefresh();
                    }
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtWellID.Text == ""))
            {
                MessageBox.Show("Please type the Well ID", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWellID.Focus();
                return isEntryFilled;
            }
            else if ((txtWellPermit.Text == ""))
            {
                MessageBox.Show("Please type the Well Permit", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWellPermit.Focus();
                return isEntryFilled;
            }
            else if ((txtOperatorName.Text == ""))
            {
                MessageBox.Show("Please set the Operator Name", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOperatorName.Focus();
                return isEntryFilled;
            }
            else if ((txtField.Text == ""))
            {
                MessageBox.Show("Please set the Field", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtField.Focus();
                return isEntryFilled;
            }
            else if ((cboCountry.Text == ""))
            {
                MessageBox.Show("Please set the Country", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCountry.Focus();
                return isEntryFilled;
            }
            else if ((cboLocation.Text == ""))
            {
                MessageBox.Show("Please type the Location ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboLocation.Focus();
                return isEntryFilled;
            }
            else if ((txtWellName.Text == ""))
            {
                MessageBox.Show("Please type the Well Name ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWellName.Focus();
                return isEntryFilled;
            }
            else if ((cboWellStatus.Text == ""))
            {
                MessageBox.Show("Please type the Well Status ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboWellStatus.Focus();
                return isEntryFilled;
            }
            else if ((cboWellType.Text == ""))
            {
                MessageBox.Show("Please type the Well Type ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboWellType.Focus();
                return isEntryFilled;
            }
            else if ((cboFlowType.Text == ""))
            {
                MessageBox.Show("Please type the Flow Type ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFlowType.Focus();
                return isEntryFilled;
            }
            else
                return true;
        }

        private void btnRefresh()
        {
            txtWellID.Clear();
            txtWellPermit.Clear();
            txtOperatorName.ResetText();
            txtField.ResetText();
            cboCountry.ResetText();
            cboLocation.ResetText();
            txtWellName.ResetText();
            cboWellStatus.ResetText();
            cboWellType.ResetText();
            cboFlowType.ResetText();
        }

        private void FrmWellRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
