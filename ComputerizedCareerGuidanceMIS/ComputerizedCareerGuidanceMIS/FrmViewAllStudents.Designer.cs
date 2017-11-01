namespace ComputerizedCareerGuidanceMIS
{
    partial class FrmViewAllStudents
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.careerDbDataSet = new ComputerizedCareerGuidanceMIS.CareerDbDataSet();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new ComputerizedCareerGuidanceMIS.CareerDbDataSetTableAdapters.TblStudentTableAdapter();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCareerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSocialMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStudyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExtraCoachingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEnglishGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMathematicsGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject1GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject2GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject3GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubject4GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(202, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "Report of all Registered Students";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(117, 20);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(711, 28);
            this.lblMarquee.TabIndex = 18;
            this.lblMarquee.Text = "Computerized Career Guidance Information Management System for Secondary School S" +
                "tudents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.studentAgeDataGridViewTextBoxColumn,
            this.studentSexDataGridViewTextBoxColumn,
            this.studentClassDataGridViewTextBoxColumn,
            this.studentCategoryDataGridViewTextBoxColumn,
            this.studentAddressDataGridViewTextBoxColumn,
            this.studentPhoneDataGridViewTextBoxColumn,
            this.studentCareerDataGridViewTextBoxColumn,
            this.studentSocialMediaDataGridViewTextBoxColumn,
            this.studentStudyTimeDataGridViewTextBoxColumn,
            this.studentExtraCoachingDataGridViewTextBoxColumn,
            this.studentEnglishGradeDataGridViewTextBoxColumn,
            this.studentMathematicsGradeDataGridViewTextBoxColumn,
            this.studentSubject1DataGridViewTextBoxColumn,
            this.studentSubject1GradeDataGridViewTextBoxColumn,
            this.studentSubject2DataGridViewTextBoxColumn,
            this.studentSubject2GradeDataGridViewTextBoxColumn,
            this.studentSubject3DataGridViewTextBoxColumn,
            this.studentSubject3GradeDataGridViewTextBoxColumn,
            this.studentSubject4DataGridViewTextBoxColumn,
            this.studentSubject4GradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 424);
            this.dataGridView1.TabIndex = 20;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(399, 560);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(180, 44);
            this.CmdCancel.TabIndex = 21;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // careerDbDataSet
            // 
            this.careerDbDataSet.DataSetName = "CareerDbDataSet";
            this.careerDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "TblStudent";
            this.tblStudentBindingSource.DataSource = this.careerDbDataSet;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentAgeDataGridViewTextBoxColumn
            // 
            this.studentAgeDataGridViewTextBoxColumn.DataPropertyName = "Student_Age";
            this.studentAgeDataGridViewTextBoxColumn.HeaderText = "Student_Age";
            this.studentAgeDataGridViewTextBoxColumn.Name = "studentAgeDataGridViewTextBoxColumn";
            // 
            // studentSexDataGridViewTextBoxColumn
            // 
            this.studentSexDataGridViewTextBoxColumn.DataPropertyName = "Student_Sex";
            this.studentSexDataGridViewTextBoxColumn.HeaderText = "Student_Sex";
            this.studentSexDataGridViewTextBoxColumn.Name = "studentSexDataGridViewTextBoxColumn";
            // 
            // studentClassDataGridViewTextBoxColumn
            // 
            this.studentClassDataGridViewTextBoxColumn.DataPropertyName = "Student_Class";
            this.studentClassDataGridViewTextBoxColumn.HeaderText = "Student_Class";
            this.studentClassDataGridViewTextBoxColumn.Name = "studentClassDataGridViewTextBoxColumn";
            // 
            // studentCategoryDataGridViewTextBoxColumn
            // 
            this.studentCategoryDataGridViewTextBoxColumn.DataPropertyName = "Student_Category";
            this.studentCategoryDataGridViewTextBoxColumn.HeaderText = "Student_Category";
            this.studentCategoryDataGridViewTextBoxColumn.Name = "studentCategoryDataGridViewTextBoxColumn";
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            this.studentAddressDataGridViewTextBoxColumn.DataPropertyName = "Student_Address";
            this.studentAddressDataGridViewTextBoxColumn.HeaderText = "Student_Address";
            this.studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            // 
            // studentPhoneDataGridViewTextBoxColumn
            // 
            this.studentPhoneDataGridViewTextBoxColumn.DataPropertyName = "Student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.HeaderText = "Student_Phone";
            this.studentPhoneDataGridViewTextBoxColumn.Name = "studentPhoneDataGridViewTextBoxColumn";
            // 
            // studentCareerDataGridViewTextBoxColumn
            // 
            this.studentCareerDataGridViewTextBoxColumn.DataPropertyName = "Student_Career";
            this.studentCareerDataGridViewTextBoxColumn.HeaderText = "Student_Career";
            this.studentCareerDataGridViewTextBoxColumn.Name = "studentCareerDataGridViewTextBoxColumn";
            // 
            // studentSocialMediaDataGridViewTextBoxColumn
            // 
            this.studentSocialMediaDataGridViewTextBoxColumn.DataPropertyName = "Student_Social_Media";
            this.studentSocialMediaDataGridViewTextBoxColumn.HeaderText = "Student_Social_Media";
            this.studentSocialMediaDataGridViewTextBoxColumn.Name = "studentSocialMediaDataGridViewTextBoxColumn";
            // 
            // studentStudyTimeDataGridViewTextBoxColumn
            // 
            this.studentStudyTimeDataGridViewTextBoxColumn.DataPropertyName = "Student_Study_Time";
            this.studentStudyTimeDataGridViewTextBoxColumn.HeaderText = "Student_Study_Time";
            this.studentStudyTimeDataGridViewTextBoxColumn.Name = "studentStudyTimeDataGridViewTextBoxColumn";
            // 
            // studentExtraCoachingDataGridViewTextBoxColumn
            // 
            this.studentExtraCoachingDataGridViewTextBoxColumn.DataPropertyName = "Student_Extra_Coaching";
            this.studentExtraCoachingDataGridViewTextBoxColumn.HeaderText = "Student_Extra_Coaching";
            this.studentExtraCoachingDataGridViewTextBoxColumn.Name = "studentExtraCoachingDataGridViewTextBoxColumn";
            // 
            // studentEnglishGradeDataGridViewTextBoxColumn
            // 
            this.studentEnglishGradeDataGridViewTextBoxColumn.DataPropertyName = "Student_English_Grade";
            this.studentEnglishGradeDataGridViewTextBoxColumn.HeaderText = "Student_English_Grade";
            this.studentEnglishGradeDataGridViewTextBoxColumn.Name = "studentEnglishGradeDataGridViewTextBoxColumn";
            // 
            // studentMathematicsGradeDataGridViewTextBoxColumn
            // 
            this.studentMathematicsGradeDataGridViewTextBoxColumn.DataPropertyName = "Student_Mathematics_Grade";
            this.studentMathematicsGradeDataGridViewTextBoxColumn.HeaderText = "Student_Mathematics_Grade";
            this.studentMathematicsGradeDataGridViewTextBoxColumn.Name = "studentMathematicsGradeDataGridViewTextBoxColumn";
            // 
            // studentSubject1DataGridViewTextBoxColumn
            // 
            this.studentSubject1DataGridViewTextBoxColumn.DataPropertyName = "Student_Subject1";
            this.studentSubject1DataGridViewTextBoxColumn.HeaderText = "Student_Subject1";
            this.studentSubject1DataGridViewTextBoxColumn.Name = "studentSubject1DataGridViewTextBoxColumn";
            // 
            // studentSubject1GradeDataGridViewTextBoxColumn
            // 
            this.studentSubject1GradeDataGridViewTextBoxColumn.DataPropertyName = "Student_Subject1_Grade";
            this.studentSubject1GradeDataGridViewTextBoxColumn.HeaderText = "Student_Subject1_Grade";
            this.studentSubject1GradeDataGridViewTextBoxColumn.Name = "studentSubject1GradeDataGridViewTextBoxColumn";
            // 
            // studentSubject2DataGridViewTextBoxColumn
            // 
            this.studentSubject2DataGridViewTextBoxColumn.DataPropertyName = "Student_Subject2";
            this.studentSubject2DataGridViewTextBoxColumn.HeaderText = "Student_Subject2";
            this.studentSubject2DataGridViewTextBoxColumn.Name = "studentSubject2DataGridViewTextBoxColumn";
            // 
            // studentSubject2GradeDataGridViewTextBoxColumn
            // 
            this.studentSubject2GradeDataGridViewTextBoxColumn.DataPropertyName = "Student_Subject2_Grade";
            this.studentSubject2GradeDataGridViewTextBoxColumn.HeaderText = "Student_Subject2_Grade";
            this.studentSubject2GradeDataGridViewTextBoxColumn.Name = "studentSubject2GradeDataGridViewTextBoxColumn";
            // 
            // studentSubject3DataGridViewTextBoxColumn
            // 
            this.studentSubject3DataGridViewTextBoxColumn.DataPropertyName = "Student_Subject3";
            this.studentSubject3DataGridViewTextBoxColumn.HeaderText = "Student_Subject3";
            this.studentSubject3DataGridViewTextBoxColumn.Name = "studentSubject3DataGridViewTextBoxColumn";
            // 
            // studentSubject3GradeDataGridViewTextBoxColumn
            // 
            this.studentSubject3GradeDataGridViewTextBoxColumn.DataPropertyName = "Student_Subject3_Grade";
            this.studentSubject3GradeDataGridViewTextBoxColumn.HeaderText = "Student_Subject3_Grade";
            this.studentSubject3GradeDataGridViewTextBoxColumn.Name = "studentSubject3GradeDataGridViewTextBoxColumn";
            // 
            // studentSubject4DataGridViewTextBoxColumn
            // 
            this.studentSubject4DataGridViewTextBoxColumn.DataPropertyName = "Student_Subject4";
            this.studentSubject4DataGridViewTextBoxColumn.HeaderText = "Student_Subject4";
            this.studentSubject4DataGridViewTextBoxColumn.Name = "studentSubject4DataGridViewTextBoxColumn";
            // 
            // studentSubject4GradeDataGridViewTextBoxColumn
            // 
            this.studentSubject4GradeDataGridViewTextBoxColumn.DataPropertyName = "Student_Subject4_Grade";
            this.studentSubject4GradeDataGridViewTextBoxColumn.HeaderText = "Student_Subject4_Grade";
            this.studentSubject4GradeDataGridViewTextBoxColumn.Name = "studentSubject4GradeDataGridViewTextBoxColumn";
            // 
            // FrmViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(983, 609);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMarquee);
            this.Name = "FrmViewAllStudents";
            this.Text = "View All Students Report Form";
            this.Load += new System.EventHandler(this.FrmViewAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdCancel;
        private CareerDbDataSet careerDbDataSet;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private CareerDbDataSetTableAdapters.TblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCareerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSocialMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStudyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExtraCoachingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEnglishGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMathematicsGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject1GradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject2GradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject3GradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSubject4GradeDataGridViewTextBoxColumn;
    }
}