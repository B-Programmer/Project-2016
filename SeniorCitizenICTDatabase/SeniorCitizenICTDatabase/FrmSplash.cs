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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            Shp2.Visible = false;
            Shp3.Visible = false;
            Shp4.Visible = false;
            Shp5.Visible = false;
            Shp6.Visible = false;
            Shp7.Visible = false;
            Shp8.Visible = false;
            Shp9.Visible = false;
            Shp10.Visible = false;
            Shp11.Visible = false;
            Shp12.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 4;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                FrmLogin f1 = new FrmLogin(this);
                f1.Show();
                //this.Hide();
            }
            lblMarquee.Left = lblMarquee.Left - 120;
            if (lblMarquee.Left <= -1164) lblMarquee.Left = 120;
            if (progressBar1.Value == 8) Shp2.Visible = true;
            else if (progressBar1.Value == 16) Shp3.Visible = true;
            else if (progressBar1.Value == 24) Shp4.Visible = true;
            else if (progressBar1.Value == 32) Shp5.Visible = true;
            else if (progressBar1.Value == 40) Shp6.Visible = true;
            else if (progressBar1.Value == 48) Shp7.Visible = true;
            else if (progressBar1.Value == 56) Shp8.Visible = true;
            else if (progressBar1.Value == 64) Shp9.Visible = true;
            else if (progressBar1.Value == 72) Shp10.Visible = true;
            else if (progressBar1.Value == 80) Shp11.Visible = true;
            else if (progressBar1.Value == 88) Shp12.Visible = true;

        }

        
    }
}
