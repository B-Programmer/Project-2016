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
    public partial class FrmViewAllStudents : Form
    {
        public FrmViewAllStudents()
        {
            InitializeComponent();
        }

        private void FrmViewAllStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'careerDbDataSet.TblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.careerDbDataSet.TblStudent);

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
