using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FailurePredictionArtificialLiftSystem
{
    public partial class MDIFailurePrediction : Form
    {
        

        public MDIFailurePrediction()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmWellRegistration childForm = new FrmWellRegistration();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
            //LayoutMdi(MdiLayout.Cascade);
            FrmPumpReport childForm = new FrmPumpReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.TileVertical);
            FrmDailyMeasureReport childForm = new FrmDailyMeasureReport();
            childForm.MdiParent = this;
            childForm.Show();
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDailyMeasure childForm = new FrmDailyMeasure();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWellReport childForm = new FrmWellReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPumpRegistration frmPumpReg = new FrmPumpRegistration();
            frmPumpReg.MdiParent = this;
            frmPumpReg.Show();
        }

       

        

       
    }
}
