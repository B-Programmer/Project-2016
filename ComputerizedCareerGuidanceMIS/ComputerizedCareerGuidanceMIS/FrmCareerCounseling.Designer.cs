namespace ComputerizedCareerGuidanceMIS
{
    partial class FrmCareerCounseling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCareerCounseling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmdPrintTreatment = new System.Windows.Forms.Button();
            this.TxtTreatment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblMarquee);
            this.panel1.Controls.Add(this.CmdCancel);
            this.panel1.Controls.Add(this.CmdNext);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 607);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.CmdPrintTreatment);
            this.panel2.Controls.Add(this.TxtTreatment);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(16, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 438);
            this.panel2.TabIndex = 28;
            // 
            // CmdPrintTreatment
            // 
            this.CmdPrintTreatment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CmdPrintTreatment.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdPrintTreatment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CmdPrintTreatment.Location = new System.Drawing.Point(688, 369);
            this.CmdPrintTreatment.Name = "CmdPrintTreatment";
            this.CmdPrintTreatment.Size = new System.Drawing.Size(140, 44);
            this.CmdPrintTreatment.TabIndex = 31;
            this.CmdPrintTreatment.Text = "&Print";
            this.CmdPrintTreatment.UseVisualStyleBackColor = false;
            // 
            // TxtTreatment
            // 
            this.TxtTreatment.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTreatment.Location = new System.Drawing.Point(15, 53);
            this.TxtTreatment.Multiline = true;
            this.TxtTreatment.Name = "TxtTreatment";
            this.TxtTreatment.ReadOnly = true;
            this.TxtTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTreatment.Size = new System.Drawing.Size(656, 374);
            this.TxtTreatment.TabIndex = 30;
            this.TxtTreatment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(131, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Career guidance and counseling advice";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Blue;
            this.lblResult.Location = new System.Drawing.Point(29, 61);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(815, 56);
            this.lblResult.TabIndex = 26;
            this.lblResult.Text = "Dear User Name, Welcome to Computerized Career Guidance and Counseling Room.";
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(42, 13);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(783, 28);
            this.lblMarquee.TabIndex = 14;
            this.lblMarquee.Text = "Computerized Career Guidance Information Management System for Secondary School S" +
                "tudents";
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(664, 555);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(180, 44);
            this.CmdCancel.TabIndex = 13;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdNext
            // 
            this.CmdNext.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdNext.Location = new System.Drawing.Point(478, 554);
            this.CmdNext.Name = "CmdNext";
            this.CmdNext.Size = new System.Drawing.Size(180, 44);
            this.CmdNext.TabIndex = 12;
            this.CmdNext.Text = "<<<Back";
            this.CmdNext.UseVisualStyleBackColor = true;
            // 
            // FrmCareerCounseling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(887, 611);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCareerCounseling";
            this.Text = "Career Counseling Information ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CmdPrintTreatment;
        private System.Windows.Forms.TextBox TxtTreatment;
        private System.Windows.Forms.Label label5;
    }
}