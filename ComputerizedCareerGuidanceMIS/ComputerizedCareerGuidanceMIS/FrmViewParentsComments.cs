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
    public partial class FrmViewParentsComments : Form
    {
        public FrmViewParentsComments()
        {
            InitializeComponent();
        }

        private void FrmViewParentsComments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerDbDataSet.TblComments' table. You can move, or remove it, as needed.
            this.tblCommentsTableAdapter.Fill(this.careerDbDataSet.TblComments);

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
