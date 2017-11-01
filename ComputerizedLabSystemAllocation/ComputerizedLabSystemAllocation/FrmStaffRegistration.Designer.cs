namespace ComputerizedLabSystemAllocation
{
    partial class FrmStaffRegistration
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStaffDepartment = new System.Windows.Forms.ComboBox();
            this.cboStaffSchool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStaffSex = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdNext = new System.Windows.Forms.Button();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(201, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(442, 35);
            this.label8.TabIndex = 26;
            this.label8.Text = "New Staff Registration Form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStaffID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboStaffDepartment);
            this.panel1.Controls.Add(this.cboStaffSchool);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboStaffSex);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.txtStaffName);
            this.panel1.Controls.Add(this.CmdCancel);
            this.panel1.Controls.Add(this.CmdNext);
            this.panel1.Location = new System.Drawing.Point(47, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 331);
            this.panel1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "Staff Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(365, 9);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(372, 35);
            this.txtStaffID.TabIndex = 26;
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Staff ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStaffDepartment
            // 
            this.cboStaffDepartment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffDepartment.FormattingEnabled = true;
            this.cboStaffDepartment.Items.AddRange(new object[] {
            "Science",
            "Commercial",
            "Arts/Social Science",
            ""});
            this.cboStaffDepartment.Location = new System.Drawing.Point(365, 176);
            this.cboStaffDepartment.Name = "cboStaffDepartment";
            this.cboStaffDepartment.Size = new System.Drawing.Size(372, 31);
            this.cboStaffDepartment.TabIndex = 20;
            // 
            // cboStaffSchool
            // 
            this.cboStaffSchool.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffSchool.FormattingEnabled = true;
            this.cboStaffSchool.Items.AddRange(new object[] {
            "S. S. S. 1",
            "S. S. S. 2",
            "S. S. S. 3",
            "J. S. S. 3"});
            this.cboStaffSchool.Location = new System.Drawing.Point(365, 136);
            this.cboStaffSchool.Name = "cboStaffSchool";
            this.cboStaffSchool.Size = new System.Drawing.Size(372, 31);
            this.cboStaffSchool.TabIndex = 19;
            this.cboStaffSchool.Text = "Science";
            this.cboStaffSchool.SelectedIndexChanged += new System.EventHandler(this.cboStaffSchool_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Department:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "School:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStaffSex
            // 
            this.cboStaffSex.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffSex.FormattingEnabled = true;
            this.cboStaffSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboStaffSex.Location = new System.Drawing.Point(365, 95);
            this.cboStaffSex.Name = "cboStaffSex";
            this.cboStaffSex.Size = new System.Drawing.Size(265, 31);
            this.cboStaffSex.TabIndex = 16;
            this.cboStaffSex.Text = "Male";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(85, 91);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(234, 30);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Staff Sex:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(365, 50);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(372, 35);
            this.txtStaffName.TabIndex = 11;
            this.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(416, 257);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(180, 44);
            this.CmdCancel.TabIndex = 13;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdNext
            // 
            this.CmdNext.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdNext.Location = new System.Drawing.Point(230, 257);
            this.CmdNext.Name = "CmdNext";
            this.CmdNext.Size = new System.Drawing.Size(180, 44);
            this.CmdNext.TabIndex = 12;
            this.CmdNext.Text = "&Save";
            this.CmdNext.UseVisualStyleBackColor = true;
            this.CmdNext.Click += new System.EventHandler(this.CmdNext_Click);
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(75, 17);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(718, 28);
            this.lblMarquee.TabIndex = 24;
            this.lblMarquee.Text = "A Computerized Laboratory System Allocation Software";
            this.lblMarquee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmStaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedLabSystemAllocation.Properties.Resources.cloud;
            this.ClientSize = new System.Drawing.Size(866, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMarquee);
            this.MaximizeBox = false;
            this.Name = "FrmStaffRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff Registration Form";
            this.Load += new System.EventHandler(this.FrmStaffRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStaffDepartment;
        private System.Windows.Forms.ComboBox cboStaffSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStaffSex;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdNext;
        private System.Windows.Forms.Label lblMarquee;
    }
}