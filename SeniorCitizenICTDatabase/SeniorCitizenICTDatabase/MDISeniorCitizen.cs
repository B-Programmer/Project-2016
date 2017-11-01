using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeniorCitizenICTDatabase
{
    public partial class MDISeniorCitizen : Form
    {
        public MDISeniorCitizen()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmSeniorCitizenRegistration childForm = new FrmSeniorCitizenRegistration();
            childForm.MdiParent = this;
            childForm.Show();
        }

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchCitizen childForm = new FrmSearchCitizen();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void generalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneralReport childForm = new FrmGeneralReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void governmentWorkersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGovernmentWorkersReport childForm = new FrmGovernmentWorkersReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void nonGovernmentWorkersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNonGovernmentWorkersRpt childForm = new FrmNonGovernmentWorkersRpt();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSeniorCitizen childForm = new AboutSeniorCitizen();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword childForm = new FrmChangePassword();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateUser childForm = new FrmCreateUser();
            childForm.MdiParent = this;
            childForm.Show();
        }

        
    }
}
