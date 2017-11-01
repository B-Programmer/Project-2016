namespace ComputerizedCareerGuidanceMIS
{
    partial class FrmExamination1
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
            this.lblMarquee = new System.Windows.Forms.Label();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdNext = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubject4 = new System.Windows.Forms.Label();
            this.lblSubject3 = new System.Windows.Forms.Label();
            this.lblSubject2 = new System.Windows.Forms.Label();
            this.lblSubject1 = new System.Windows.Forms.Label();
            this.cboGrade4 = new System.Windows.Forms.ComboBox();
            this.cboGrade3 = new System.Windows.Forms.ComboBox();
            this.cboGrade2 = new System.Windows.Forms.ComboBox();
            this.cboGrade1 = new System.Windows.Forms.ComboBox();
            this.cboMathematicsGrade = new System.Windows.Forms.ComboBox();
            this.cboEnglishGrade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboExtraCoaching = new System.Windows.Forms.ComboBox();
            this.cboStudyTime = new System.Windows.Forms.ComboBox();
            this.cboReading = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStudentCareer = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.CmdCancel.Location = new System.Drawing.Point(680, 499);
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
            this.CmdNext.Location = new System.Drawing.Point(680, 445);
            this.CmdNext.Name = "CmdNext";
            this.CmdNext.Size = new System.Drawing.Size(180, 44);
            this.CmdNext.TabIndex = 12;
            this.CmdNext.Text = "Next>>>";
            this.CmdNext.UseVisualStyleBackColor = true;
            this.CmdNext.Click += new System.EventHandler(this.CmdNext_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(14, 53);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(321, 30);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Student Choice of Career:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cboExtraCoaching);
            this.panel1.Controls.Add(this.cboStudyTime);
            this.panel1.Controls.Add(this.cboReading);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboStudentCareer);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.lblMarquee);
            this.panel1.Controls.Add(this.CmdCancel);
            this.panel1.Controls.Add(this.CmdNext);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 607);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.panel2.Controls.Add(this.lblSubject4);
            this.panel2.Controls.Add(this.lblSubject3);
            this.panel2.Controls.Add(this.lblSubject2);
            this.panel2.Controls.Add(this.lblSubject1);
            this.panel2.Controls.Add(this.cboGrade4);
            this.panel2.Controls.Add(this.cboGrade3);
            this.panel2.Controls.Add(this.cboGrade2);
            this.panel2.Controls.Add(this.cboGrade1);
            this.panel2.Controls.Add(this.cboMathematicsGrade);
            this.panel2.Controls.Add(this.cboEnglishGrade);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 325);
            this.panel2.TabIndex = 25;
            // 
            // lblSubject4
            // 
            this.lblSubject4.BackColor = System.Drawing.Color.White;
            this.lblSubject4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject4.Location = new System.Drawing.Point(24, 284);
            this.lblSubject4.Name = "lblSubject4";
            this.lblSubject4.Size = new System.Drawing.Size(293, 25);
            this.lblSubject4.TabIndex = 38;
            this.lblSubject4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubject3
            // 
            this.lblSubject3.BackColor = System.Drawing.Color.White;
            this.lblSubject3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject3.Location = new System.Drawing.Point(24, 241);
            this.lblSubject3.Name = "lblSubject3";
            this.lblSubject3.Size = new System.Drawing.Size(293, 25);
            this.lblSubject3.TabIndex = 37;
            this.lblSubject3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubject2
            // 
            this.lblSubject2.BackColor = System.Drawing.Color.White;
            this.lblSubject2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject2.Location = new System.Drawing.Point(24, 200);
            this.lblSubject2.Name = "lblSubject2";
            this.lblSubject2.Size = new System.Drawing.Size(293, 25);
            this.lblSubject2.TabIndex = 36;
            this.lblSubject2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubject1
            // 
            this.lblSubject1.BackColor = System.Drawing.Color.White;
            this.lblSubject1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject1.Location = new System.Drawing.Point(24, 159);
            this.lblSubject1.Name = "lblSubject1";
            this.lblSubject1.Size = new System.Drawing.Size(293, 25);
            this.lblSubject1.TabIndex = 35;
            this.lblSubject1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboGrade4
            // 
            this.cboGrade4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade4.FormattingEnabled = true;
            this.cboGrade4.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair",
            "Weak",
            "Poor",
            "Very Poor"});
            this.cboGrade4.Location = new System.Drawing.Point(384, 284);
            this.cboGrade4.Name = "cboGrade4";
            this.cboGrade4.Size = new System.Drawing.Size(215, 29);
            this.cboGrade4.TabIndex = 34;
            this.cboGrade4.Text = "Excellent";
            // 
            // cboGrade3
            // 
            this.cboGrade3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade3.FormattingEnabled = true;
            this.cboGrade3.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair",
            "Weak",
            "Poor",
            "Very Poor"});
            this.cboGrade3.Location = new System.Drawing.Point(384, 240);
            this.cboGrade3.Name = "cboGrade3";
            this.cboGrade3.Size = new System.Drawing.Size(215, 29);
            this.cboGrade3.TabIndex = 33;
            this.cboGrade3.Text = "Excellent";
            // 
            // cboGrade2
            // 
            this.cboGrade2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade2.FormattingEnabled = true;
            this.cboGrade2.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair",
            "Weak",
            "Poor",
            "Very Poor"});
            this.cboGrade2.Location = new System.Drawing.Point(384, 199);
            this.cboGrade2.Name = "cboGrade2";
            this.cboGrade2.Size = new System.Drawing.Size(215, 29);
            this.cboGrade2.TabIndex = 32;
            this.cboGrade2.Text = "Excellent";
            // 
            // cboGrade1
            // 
            this.cboGrade1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade1.FormattingEnabled = true;
            this.cboGrade1.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair",
            "Weak",
            "Poor",
            "Very Poor"});
            this.cboGrade1.Location = new System.Drawing.Point(384, 156);
            this.cboGrade1.Name = "cboGrade1";
            this.cboGrade1.Size = new System.Drawing.Size(215, 29);
            this.cboGrade1.TabIndex = 31;
            this.cboGrade1.Text = "Excellent";
            // 
            // cboMathematicsGrade
            // 
            this.cboMathematicsGrade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMathematicsGrade.FormattingEnabled = true;
            this.cboMathematicsGrade.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair",
            "Weak",
            "Poor",
            "Very Poor"});
            this.cboMathematicsGrade.Location = new System.Drawing.Point(384, 114);
            this.cboMathematicsGrade.Name = "cboMathematicsGrade";
            this.cboMathematicsGrade.Size = new System.Drawing.Size(215, 29);
            this.cboMathematicsGrade.TabIndex = 30;
            this.cboMathematicsGrade.Text = "Excellent";
            // 
            // cboEnglishGrade
            // 
            this.cboEnglishGrade.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEnglishGrade.FormattingEnabled = true;
            this.cboEnglishGrade.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Fair",
            "Weak",
            "Poor",
            "Very Poor"});
            this.cboEnglishGrade.Location = new System.Drawing.Point(384, 75);
            this.cboEnglishGrade.Name = "cboEnglishGrade";
            this.cboEnglishGrade.Size = new System.Drawing.Size(215, 29);
            this.cboEnglishGrade.TabIndex = 29;
            this.cboEnglishGrade.Text = "Excellent";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mathematics";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "English Language";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grades";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Subjects";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student Performance on key career subjects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboExtraCoaching
            // 
            this.cboExtraCoaching.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExtraCoaching.FormattingEnabled = true;
            this.cboExtraCoaching.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboExtraCoaching.Location = new System.Drawing.Point(613, 175);
            this.cboExtraCoaching.Name = "cboExtraCoaching";
            this.cboExtraCoaching.Size = new System.Drawing.Size(244, 29);
            this.cboExtraCoaching.TabIndex = 24;
            this.cboExtraCoaching.Text = "No";
            // 
            // cboStudyTime
            // 
            this.cboStudyTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudyTime.FormattingEnabled = true;
            this.cboStudyTime.Items.AddRange(new object[] {
            "Less than 1 hours",
            "1 hours",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours",
            "9 hours",
            "10 hours",
            "11 hours",
            "12 hours"});
            this.cboStudyTime.Location = new System.Drawing.Point(613, 131);
            this.cboStudyTime.Name = "cboStudyTime";
            this.cboStudyTime.Size = new System.Drawing.Size(244, 29);
            this.cboStudyTime.TabIndex = 22;
            this.cboStudyTime.Text = "Less than 1 hours";
            // 
            // cboReading
            // 
            this.cboReading.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReading.FormattingEnabled = true;
            this.cboReading.Items.AddRange(new object[] {
            "Frequently",
            "Occasionally",
            "Seldomly",
            "Every Weekend",
            "Every Day",
            "Every two weeks",
            "Once in a Month",
            "Rarely",
            "Every Night"});
            this.cboReading.Location = new System.Drawing.Point(613, 96);
            this.cboReading.Name = "cboReading";
            this.cboReading.Size = new System.Drawing.Size(244, 29);
            this.cboReading.TabIndex = 21;
            this.cboReading.Text = "Frequently";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Do you(Student) attend any extra-coaching or tutorial class:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "For How long do you(Student) read:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "How often do you(Student) use social media:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStudentCareer
            // 
            this.cboStudentCareer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudentCareer.FormattingEnabled = true;
            this.cboStudentCareer.Location = new System.Drawing.Point(437, 53);
            this.cboStudentCareer.Name = "cboStudentCareer";
            this.cboStudentCareer.Size = new System.Drawing.Size(420, 29);
            this.cboStudentCareer.TabIndex = 16;
            this.cboStudentCareer.Leave += new System.EventHandler(this.cboStudentCareer_Leave);
            // 
            // FrmExamination1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(881, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FrmExamination1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Career-Guidance Assessment Form";
            this.Load += new System.EventHandler(this.FrmExamination1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdNext;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStudentCareer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboExtraCoaching;
        private System.Windows.Forms.ComboBox cboStudyTime;
        private System.Windows.Forms.ComboBox cboReading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboGrade3;
        private System.Windows.Forms.ComboBox cboGrade2;
        private System.Windows.Forms.ComboBox cboGrade1;
        private System.Windows.Forms.ComboBox cboMathematicsGrade;
        private System.Windows.Forms.ComboBox cboEnglishGrade;
        private System.Windows.Forms.ComboBox cboGrade4;
        private System.Windows.Forms.Label lblSubject4;
        private System.Windows.Forms.Label lblSubject3;
        private System.Windows.Forms.Label lblSubject2;
        private System.Windows.Forms.Label lblSubject1;
    }
}

