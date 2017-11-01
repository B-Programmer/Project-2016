namespace SampleFaceApplication
{
    partial class FrmSampleFace
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optCamera = new System.Windows.Forms.RadioButton();
            this.optPicture = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVerify1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.optCamera);
            this.groupBox2.Controls.Add(this.optPicture);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 278);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biometric(Face) Details";
            // 
            // btnUpload
            // 
            this.btnUpload.ForeColor = System.Drawing.Color.Gray;
            this.btnUpload.Location = new System.Drawing.Point(198, 23);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 30);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "&Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(14, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 201);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // optCamera
            // 
            this.optCamera.AutoSize = true;
            this.optCamera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optCamera.Location = new System.Drawing.Point(108, 27);
            this.optCamera.Name = "optCamera";
            this.optCamera.Size = new System.Drawing.Size(81, 23);
            this.optCamera.TabIndex = 1;
            this.optCamera.TabStop = true;
            this.optCamera.Text = "Camera";
            this.optCamera.UseVisualStyleBackColor = true;
            // 
            // optPicture
            // 
            this.optPicture.AutoSize = true;
            this.optPicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optPicture.Location = new System.Drawing.Point(12, 27);
            this.optPicture.Name = "optPicture";
            this.optPicture.Size = new System.Drawing.Size(75, 23);
            this.optPicture.TabIndex = 0;
            this.optPicture.TabStop = true;
            this.optPicture.Text = "Picture";
            this.optPicture.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnVerify1);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnVerify);
            this.panel2.Location = new System.Drawing.Point(15, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 58);
            this.panel2.TabIndex = 25;
            // 
            // btnVerify1
            // 
            this.btnVerify1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVerify1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerify1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVerify1.Location = new System.Drawing.Point(109, 9);
            this.btnVerify1.Name = "btnVerify1";
            this.btnVerify1.Size = new System.Drawing.Size(93, 40);
            this.btnVerify1.TabIndex = 3;
            this.btnVerify1.Text = "&Verify";
            this.btnVerify1.UseVisualStyleBackColor = false;
            this.btnVerify1.Click += new System.EventHandler(this.btnVerify1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(209, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVerify.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVerify.Location = new System.Drawing.Point(10, 9);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(93, 40);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "&Save";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // FrmSampleFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 374);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmSampleFace";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton optCamera;
        private System.Windows.Forms.RadioButton optPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnVerify1;
    }
}

