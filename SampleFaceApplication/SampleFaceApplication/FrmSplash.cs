using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleFaceApplication
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                MDIFace f1 = new MDIFace(this);
                f1.Show();
                //this.Close();
            }
            lblMarquee.Left = lblMarquee.Left - 120;
            if (lblMarquee.Left <= -1164) lblMarquee.Left = 120;
        }
    }
}
