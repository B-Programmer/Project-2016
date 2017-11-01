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
                this.Hide();
                MDIFailurePrediction f1 = new MDIFailurePrediction();
                f1.Show();
            }
            lblMarquee.Left = lblMarquee.Left - 120;
            if (lblMarquee.Left <= -740) lblMarquee.Left = 773;
        }
    }
}
