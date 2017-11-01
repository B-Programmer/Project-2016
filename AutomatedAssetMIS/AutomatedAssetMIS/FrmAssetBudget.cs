using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedAssetMIS
{
    public partial class FrmAssetBudget : Form
    {
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\dbAsset.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\AutomatedAssetMIS\AutomatedAssetMIS\dbAsset.accdb");
        private OleDbCommand cmd = new OleDbCommand();
        private bool nonNumberEntered = false;
        public FrmAssetBudget()
        {
            InitializeComponent();
        }

        private void btnMonthlyCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAnnualCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMonthlyClear_Click(object sender, EventArgs e)
        {
            cboBudgetMonth.ResetText();
            cboMonthlyYear.ResetText();
            txtBuildingMonthlyIncome.ResetText();
            txtFurnitureMonthlyIncome.ResetText();
            txtLandMonthlyIncome.ResetText();
            txtVehicleMonthlyIncome.ResetText();
            txtTotalMonthlyIncome.ResetText();
            txtMonthlyPHCNBill.ResetText();
            txtMonthlyRenovationCharges.ResetText();
            txtMonthlySecurityCharges.ResetText();
            txtMonthlyMiscellaneous.ResetText();
            txtTotalMonthlyExpenditure.ResetText();
            txtMonthlyNetIncome.ResetText();
        }

        private void btnAnnualClear_Click(object sender, EventArgs e)
        {
            cboBudgetYear.ResetText();
            txtBuildingAnnualIncome.ResetText();
            txtFurnitureAnnualIncome.ResetText();
            txtLandAnnualIncome.ResetText();
            txtVehicleAnnualIncome.ResetText();
            txtTotalAnnualIncome.ResetText();
            txtAnnualPHCNBill.ResetText();
            txtAnnualRenovationCharges.ResetText();
            txtAnnualSecurityCharges.ResetText();
            txtAnnualMiscellaneous.ResetText();
            txtTotalAnnualExpenditure.ResetText();
            txtAnnualNetIncome.ResetText();
        }

        private void btnMonthlyCompute_Click(object sender, EventArgs e)
        {
            double TotalMonthlyIncome;
            double TotalMonthlyExpenditure;
            double MonthlyNetIncome;
            TotalMonthlyIncome = Convert.ToDouble(txtBuildingMonthlyIncome.Text) + Convert.ToDouble(txtFurnitureMonthlyIncome.Text) + Convert.ToDouble(txtLandMonthlyIncome.Text) + Convert.ToDouble(txtVehicleMonthlyIncome.Text);
            txtTotalMonthlyIncome.Text = TotalMonthlyIncome.ToString();
            TotalMonthlyExpenditure = Convert.ToDouble(txtMonthlyPHCNBill.Text) + Convert.ToDouble(txtMonthlyRenovationCharges.Text) + Convert.ToDouble(txtMonthlySecurityCharges.Text) + Convert.ToDouble(txtMonthlyMiscellaneous.Text);
            txtTotalMonthlyExpenditure.Text = TotalMonthlyExpenditure.ToString();
            MonthlyNetIncome = TotalMonthlyIncome - TotalMonthlyExpenditure;
            txtMonthlyNetIncome.Text = MonthlyNetIncome.ToString();

        }

        private void btnAnnualCompute_Click(object sender, EventArgs e)
        {
            double TotalAnnualIncome;
            double TotalAnnualExpenditure;
            double AnnualNetIncome;
            TotalAnnualIncome = Convert.ToDouble(txtBuildingAnnualIncome.Text) + Convert.ToDouble(txtFurnitureAnnualIncome.Text) + Convert.ToDouble(txtLandAnnualIncome.Text) + Convert.ToDouble(txtVehicleAnnualIncome.Text);
            txtTotalAnnualIncome.Text = TotalAnnualIncome.ToString();
            TotalAnnualExpenditure = Convert.ToDouble(txtAnnualPHCNBill.Text) + Convert.ToDouble(txtAnnualRenovationCharges.Text) + Convert.ToDouble(txtAnnualSecurityCharges.Text) + Convert.ToDouble(txtAnnualMiscellaneous.Text);
            txtTotalAnnualExpenditure.Text = TotalAnnualExpenditure.ToString();
            AnnualNetIncome = TotalAnnualIncome - TotalAnnualExpenditure;
            txtAnnualNetIncome.Text = AnnualNetIncome.ToString();
        }

        private void btnMonthlySave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDouble(txtTotalMonthlyIncome.Text) == 0.00) || (Convert.ToDouble(txtTotalMonthlyExpenditure.Text) == 0.00))
                {
                    MessageBox.Show("Please enter all the  monthly budget details and click on compute button before you proceed to save entries", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string BudgetMonth = cboBudgetMonth.Text;
                    string MonthlyYear = cboMonthlyYear.Text;
                    double BuildingMonthlyIncome = Convert.ToDouble(txtBuildingMonthlyIncome.Text);
                    double FurnitureMonthlyIncome = Convert.ToDouble(txtFurnitureMonthlyIncome.Text);
                    double LandMonthlyIncome = Convert.ToDouble(txtLandMonthlyIncome.Text);
                    double VehicleMonthlyIncome = Convert.ToDouble(txtVehicleMonthlyIncome.Text);
                    double TotalMonthlyIncome = Convert.ToDouble(txtTotalMonthlyIncome.Text);
                    double MonthlyPHCNBill = Convert.ToDouble(txtMonthlyPHCNBill.Text);
                    double MonthlyRenovationCharges = Convert.ToDouble(txtMonthlyRenovationCharges.Text);
                    double MonthlySecurityCharges = Convert.ToDouble(txtMonthlySecurityCharges.Text); 
                    double MonthlyMiscellaneous = Convert.ToDouble(txtMonthlyMiscellaneous.Text);
                    double TotalMonthlyExpenditure = Convert.ToDouble(txtTotalMonthlyExpenditure.Text);
                    double MonthlyNetIncome = Convert.ToDouble(txtMonthlyNetIncome.Text);
                                
                    cn.Open();
                    cmd.CommandText = "insert into tblMonthlyBudget values('" + BudgetMonth + "','" + MonthlyYear + "'," + BuildingMonthlyIncome + "," + LandMonthlyIncome + "," + FurnitureMonthlyIncome + "," + VehicleMonthlyIncome + "," + TotalMonthlyIncome + "," + MonthlyPHCNBill + "," + MonthlySecurityCharges + "," + MonthlyRenovationCharges + "," + MonthlyMiscellaneous + "," + TotalMonthlyExpenditure + "," + MonthlyNetIncome + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Monthly Budget Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    btnMonthlyClear_Click(sender, e);
                }
           }
           catch (Exception er)
           {
               cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }

        private void btnAnnualSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDouble(txtTotalAnnualIncome.Text) == 0.00) || (Convert.ToDouble(txtTotalAnnualExpenditure.Text) == 0.00))
                {
                    MessageBox.Show("Please enter all the  Annual budget details and click on compute button before you proceed to save entries", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string AnnualYear = cboBudgetYear.Text;
                    double BuildingAnnualIncome = Convert.ToDouble(txtBuildingAnnualIncome.Text);
                    double FurnitureAnnualIncome = Convert.ToDouble(txtFurnitureAnnualIncome.Text);
                    double LandAnnualIncome = Convert.ToDouble(txtLandAnnualIncome.Text);
                    double VehicleAnnualIncome = Convert.ToDouble(txtVehicleAnnualIncome.Text);
                    double TotalAnnualIncome = Convert.ToDouble(txtTotalAnnualIncome.Text);
                    double AnnualPHCNBill = Convert.ToDouble(txtAnnualPHCNBill.Text);
                    double AnnualRenovationCharges = Convert.ToDouble(txtAnnualRenovationCharges.Text);
                    double AnnualSecurityCharges = Convert.ToDouble(txtAnnualSecurityCharges.Text);
                    double AnnualMiscellaneous = Convert.ToDouble(txtAnnualMiscellaneous.Text);
                    double TotalAnnualExpenditure = Convert.ToDouble(txtTotalAnnualExpenditure.Text);
                    double AnnualNetIncome = Convert.ToDouble(txtAnnualNetIncome.Text);

                    cn.Open();
                    cmd.CommandText = "insert into tblAnnualBudget values('" + AnnualYear + "'," + BuildingAnnualIncome + "," + LandAnnualIncome + "," + FurnitureAnnualIncome + "," + VehicleAnnualIncome + "," + TotalAnnualIncome + "," + AnnualPHCNBill + "," + AnnualSecurityCharges + "," + AnnualRenovationCharges + "," + AnnualMiscellaneous + "," + TotalAnnualExpenditure + "," + AnnualNetIncome + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Annual Budget Information successfully saved!!!", "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    btnAnnualClear_Click(sender, e);
                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Asset MIS App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAssetBudget_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void txtBuildingMonthlyIncome_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.OemPeriod))
                    nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtBuildingMonthlyIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }

        private void txtBuildingAnnualIncome_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.OemPeriod))
                        nonNumberEntered = true;
                }

            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtBuildingAnnualIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (nonNumberEntered == true) e.Handled = true; //capture keytrapping i.e. keypress = 0 (null)
        }
       
    }
}
