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
    public partial class FrmPumpRegistration : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbArtificialLift.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();

        public FrmPumpRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmPumpRegistration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string PumpID = txtPumpID.Text;
                    string ArtificialLift = cboArtificialLift.Text;
                    string Pump = cboPump.Text;
                    string OperatingRange = cboOperatingRange.Text;
                    string Motor = cboMotor.Text;
                    string Cable = cboCable.Text;
                    int PumpDepth = Convert.ToInt32(txtPumpDepth.Text);
                    int OperatingFrequency = Convert.ToInt16(txtOperatingFrequency.Text);
                    

                    {
                        cn.Open();
                        cmd.CommandText = "insert into tblPumpReg values('" + PumpID + "','" + ArtificialLift + "','" + Pump + "','" + OperatingRange + "','" + Motor + "','" + Cable + "'," + PumpDepth + "," + OperatingFrequency + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Pump Registration Details Successfully Saved!!!", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if ((txtPumpID.Text == ""))
            {
                MessageBox.Show("Please type the Pump ID", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPumpID.Focus();
                return isEntryFilled;
            }
            else if ((cboArtificialLift.Text == ""))
            {
                MessageBox.Show("Please type the Artificial Lift", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboArtificialLift.Focus();
                return isEntryFilled;
            }
            else if ((cboPump.Text == ""))
            {
                MessageBox.Show("Please set the Pump Type", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPump.Focus();
                return isEntryFilled;
            }
            else if ((cboOperatingRange.Text == ""))
            {
                MessageBox.Show("Please set the Operating Range", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboOperatingRange.Focus();
                return isEntryFilled;
            }
            else if ((cboMotor.Text == ""))
            {
                MessageBox.Show("Please set the Pump Motor", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboMotor.Focus();
                return isEntryFilled;
            }
            else if ((cboCable.Text == ""))
            {
                MessageBox.Show("Please type the Cable ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCable.Focus();
                return isEntryFilled;
            }
            else if ((txtPumpDepth.Text == ""))
            {
                MessageBox.Show("Please type the Pump Depth ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPumpDepth.Focus();
                return isEntryFilled;
            }
            else if ((txtOperatingFrequency.Text == ""))
            {
                MessageBox.Show("Please type the Operating Frequency ", "Failure Prediction App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOperatingFrequency.Focus();
                return isEntryFilled;
            }
            else
                return true;
        }

        private void btnRefresh()
        {
            txtPumpID.Clear();
            cboArtificialLift.ResetText();
            cboPump.ResetText();
            cboOperatingRange.ResetText();
            cboMotor.ResetText();
            cboCable.ResetText();
            txtPumpDepth.ResetText();
            txtOperatingFrequency.ResetText();
            txtPumpID.Focus();
        }
        


        
    }
}
