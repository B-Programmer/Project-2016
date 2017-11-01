namespace ComputerizedLabSystemAllocation
{
    partial class FrmStudentRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboProgrammeOfStudy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStudentLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentMatricNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStudentDepartment = new System.Windows.Forms.ComboBox();
            this.cboStudentSchool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStudentSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdNext = new System.Windows.Forms.Button();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cboProgrammeOfStudy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboStudentLevel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStudentMatricNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboStudentDepartment);
            this.panel1.Controls.Add(this.cboStudentSchool);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboStudentSex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.CmdCancel);
            this.panel1.Controls.Add(this.CmdNext);
            this.panel1.Location = new System.Drawing.Point(3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 366);
            this.panel1.TabIndex = 22;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(661, 209);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(195, 44);
            this.btnUpload.TabIndex = 32;
            this.btnUpload.Text = "&Upload Pix";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(661, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 192);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // cboProgrammeOfStudy
            // 
            this.cboProgrammeOfStudy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProgrammeOfStudy.FormattingEnabled = true;
            this.cboProgrammeOfStudy.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time"});
            this.cboProgrammeOfStudy.Location = new System.Drawing.Point(266, 242);
            this.cboProgrammeOfStudy.Name = "cboProgrammeOfStudy";
            this.cboProgrammeOfStudy.Size = new System.Drawing.Size(372, 31);
            this.cboProgrammeOfStudy.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Programme of Study:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStudentLevel
            // 
            this.cboStudentLevel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudentLevel.FormattingEnabled = true;
            this.cboStudentLevel.Items.AddRange(new object[] {
            "ND I",
            "ND II",
            "HND I",
            "HND II"});
            this.cboStudentLevel.Location = new System.Drawing.Point(266, 124);
            this.cboStudentLevel.Name = "cboStudentLevel";
            this.cboStudentLevel.Size = new System.Drawing.Size(372, 31);
            this.cboStudentLevel.TabIndex = 28;
            this.cboStudentLevel.Text = "ND I";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "Student Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentMatricNo
            // 
            this.txtStudentMatricNo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentMatricNo.Location = new System.Drawing.Point(266, 9);
            this.txtStudentMatricNo.Name = "txtStudentMatricNo";
            this.txtStudentMatricNo.Size = new System.Drawing.Size(372, 35);
            this.txtStudentMatricNo.TabIndex = 26;
            this.txtStudentMatricNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Student Matric No:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStudentDepartment
            // 
            this.cboStudentDepartment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudentDepartment.FormattingEnabled = true;
            this.cboStudentDepartment.Location = new System.Drawing.Point(266, 202);
            this.cboStudentDepartment.Name = "cboStudentDepartment";
            this.cboStudentDepartment.Size = new System.Drawing.Size(372, 31);
            this.cboStudentDepartment.TabIndex = 20;
            // 
            // cboStudentSchool
            // 
            this.cboStudentSchool.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudentSchool.FormattingEnabled = true;
            this.cboStudentSchool.Items.AddRange(new object[] {
            "Science"});
            this.cboStudentSchool.Location = new System.Drawing.Point(266, 164);
            this.cboStudentSchool.Name = "cboStudentSchool";
            this.cboStudentSchool.Size = new System.Drawing.Size(372, 31);
            this.cboStudentSchool.TabIndex = 19;
            this.cboStudentSchool.Text = "Science";
            this.cboStudentSchool.SelectedIndexChanged += new System.EventHandler(this.cboStudentSchool_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 203);
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
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "School:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStudentSex
            // 
            this.cboStudentSex.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cboStudentSex.FormattingEnabled = true;
            this.cboStudentSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboStudentSex.Location = new System.Drawing.Point(266, 87);
            this.cboStudentSex.Name = "cboStudentSex";
            this.cboStudentSex.Size = new System.Drawing.Size(265, 31);
            this.cboStudentSex.TabIndex = 16;
            this.cboStudentSex.Text = "Male";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(14, 87);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(234, 30);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Student Sex:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(266, 47);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(372, 35);
            this.txtStudentName.TabIndex = 11;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(411, 299);
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
            this.CmdNext.Location = new System.Drawing.Point(225, 299);
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
            this.lblMarquee.Location = new System.Drawing.Point(82, 9);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(718, 28);
            this.lblMarquee.TabIndex = 14;
            this.lblMarquee.Text = "A Computerized Laboratory System Allocation Software";
            this.lblMarquee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(198, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(457, 35);
            this.label8.TabIndex = 23;
            this.label8.Text = "New Student Registration Form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedLabSystemAllocation.Properties.Resources.cloud;
            this.ClientSize = new System.Drawing.Size(885, 593);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMarquee);
            this.MaximizeBox = false;
            this.Name = "FrmStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.FrmStudentRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStudentMatricNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStudentDepartment;
        private System.Windows.Forms.ComboBox cboStudentSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStudentSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdNext;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStudentLevel;
        private System.Windows.Forms.ComboBox cboProgrammeOfStudy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

