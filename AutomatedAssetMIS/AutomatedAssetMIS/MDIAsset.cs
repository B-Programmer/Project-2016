using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedAssetMIS
{
    public partial class MDIAsset : Form
    {
        //private int childFormNumber = 0;

        public MDIAsset()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmAsset childForm = new FrmAsset();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
           /*     OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = openFileDialog.FileName;
                }
            */
            FrmAssetBudget childForm = new FrmAssetBudget();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /*     SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                }
            */ 
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAssetApp childForm = new AboutAssetApp();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuildingAssetReport childForm = new FrmBuildingAssetReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void landAssetReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLandAssetReport childForm = new FrmLandAssetReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void furnitureAssetReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFurnitureAssetReport childForm = new FrmFurnitureAssetReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void vehicleAssetReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehicleAssetReport childForm = new FrmVehicleAssetReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void monthlyBudgetReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonthlyBudgetReport childForm = new FrmMonthlyBudgetReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void annualBudgetReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnnualBudgetReport childForm = new FrmAnnualBudgetReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void assetSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAssetSales childForm = new FrmAssetSales();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void assetSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalesAnalysis childForm = new FrmSalesAnalysis();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void generalAssetSalesAnalysisReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneralAssetAnalysis childForm = new FrmGeneralAssetAnalysis();
            childForm.MdiParent = this;
            childForm.Show();
        }

        
    }
}
