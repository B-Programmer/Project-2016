using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PensionVerificationSystem
{
    public partial class MDIPensionVerification : Form
    {
        //private int childFormNumber = 0;

        public MDIPensionVerification()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmPensionEnrollment childForm = new FrmPensionEnrollment();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            FrmPensionPayment childForm = new FrmPensionPayment();
            childForm.MdiParent = this;
            childForm.Show();      
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
            * 
            */
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPensionerVerification childForm = new FrmPensionerVerification();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateUser childForm = new FrmCreateUser();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword childForm = new FrmChangePassword();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void generalPensionersEnrollmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneralPensionEnrolReport childForm = new FrmGeneralPensionEnrolReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void pensionPaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPensionPaymentReport childForm = new FrmPensionPaymentReport();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void monthlyVerificationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonthlyVerification childForm = new FrmMonthlyVerification();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPensionVerification childForm = new AboutPensionVerification();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MDIPensionVerification_Load(object sender, EventArgs e)
        {

        }
       
    }
}
