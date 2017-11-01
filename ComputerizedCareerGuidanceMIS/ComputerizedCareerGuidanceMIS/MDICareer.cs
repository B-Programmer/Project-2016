using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCareerGuidanceMIS
{
    public partial class MDICareer : Form
    {
        private string userName;
        private string userType;

        public MDICareer(string user, string uType)
        {
            InitializeComponent();
            userName = user;
            userType = uType;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {             
            FrmStudentDetails childForm = new FrmStudentDetails(userName, userType);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
           /* OpenFileDialog openFileDialog = new OpenFileDialog();
              openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
              openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
              if (openFileDialog.ShowDialog(this) == DialogResult.OK)
              {
                string FileName = openFileDialog.FileName;
              }
            */
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  SaveFileDialog saveFileDialog = new SaveFileDialog();
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
              

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
            FrmCareerAsk childForm = new FrmCareerAsk();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutApp childForm = new AboutApp();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MDICareer_Load(object sender, EventArgs e)
        {

        }

        private void viewAllUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewAllUsers childForm = new FrmViewAllUsers();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewAllStudents childForm = new FrmViewAllStudents();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void viewParentsGuardianCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewParentsComments childForm = new FrmViewParentsComments();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void viewAllUserLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewUserLog childForm = new FrmViewUserLog();
            childForm.MdiParent = this;
            childForm.Show();
        }
        
    }
}
