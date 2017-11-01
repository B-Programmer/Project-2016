namespace ComputerizedCarRentalSystem
{
    partial class FrmEditCarRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditCarRegistration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.cboCarModel = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCarPlateNumber = new System.Windows.Forms.TextBox();
            this.txtCarRentageCost = new System.Windows.Forms.TextBox();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.cboCarMaker = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCarRegId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cboCarRegId);
            this.groupBox1.Controls.Add(this.cboCarType);
            this.groupBox1.Controls.Add(this.cboCarModel);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtCarPlateNumber);
            this.groupBox1.Controls.Add(this.txtCarRentageCost);
            this.groupBox1.Controls.Add(this.txtCarColor);
            this.groupBox1.Controls.Add(this.cboCarMaker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(17, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Registration details ";
            // 
            // cboCarType
            // 
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Items.AddRange(new object[] {
            "Passenger Car",
            "Van",
            "Taxi",
            "Hearse",
            "2-axle Limousine",
            "Car Carrier",
            "2-Door Car",
            "Luxury Car",
            "Sport Car"});
            this.cboCarType.Location = new System.Drawing.Point(322, 66);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(410, 28);
            this.cboCarType.TabIndex = 25;
            // 
            // cboCarModel
            // 
            this.cboCarModel.FormattingEnabled = true;
            this.cboCarModel.Items.AddRange(new object[] {
            "Chevy Sonic",
            "Ford Fiesta",
            "Honda Fit",
            "Hyundai Accent",
            "Kia Rio",
            "Mazda2",
            "Mitsubishi Mirage",
            "Nissan Versa",
            "Scion xD",
            "Toyota Yaris",
            "Chevy Cruze",
            "Dodge Dart",
            "Ford Focus",
            "Honda Civic",
            "Hyundai Elantra",
            "Kia Forte",
            "Mazda3",
            "Mitsubishi Lancer",
            "Nissan Sentra",
            "Subaru Impreza",
            "Toyota Corolla",
            "Chevy Malibu",
            "Dodge Avenger",
            "Ford Fusion",
            "Hyundai Sonata",
            "Kia Optima",
            "Mazda6",
            "Mitsubishi Eclipse",
            "Nissan Altima",
            "Subaru Legacy",
            "Toyota Camry",
            "Chevy Impala",
            "Ford Taurus",
            "Honda Accord",
            "Hyundai Genesis",
            "Kia Cadenza",
            "Nissan Maxima",
            "Toyota Avalon"});
            this.cboCarModel.Location = new System.Drawing.Point(322, 104);
            this.cboCarModel.Name = "cboCarModel";
            this.cboCarModel.Size = new System.Drawing.Size(410, 28);
            this.cboCarModel.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(408, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 56);
            this.panel2.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::ComputerizedCarRentalSystem.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(183, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "   &Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(12, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 40);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "  &Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCarPlateNumber
            // 
            this.txtCarPlateNumber.Location = new System.Drawing.Point(322, 251);
            this.txtCarPlateNumber.Name = "txtCarPlateNumber";
            this.txtCarPlateNumber.PasswordChar = '*';
            this.txtCarPlateNumber.Size = new System.Drawing.Size(410, 32);
            this.txtCarPlateNumber.TabIndex = 20;
            // 
            // txtCarRentageCost
            // 
            this.txtCarRentageCost.Location = new System.Drawing.Point(322, 213);
            this.txtCarRentageCost.Name = "txtCarRentageCost";
            this.txtCarRentageCost.Size = new System.Drawing.Size(410, 32);
            this.txtCarRentageCost.TabIndex = 19;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(322, 175);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(410, 32);
            this.txtCarColor.TabIndex = 14;
            // 
            // cboCarMaker
            // 
            this.cboCarMaker.FormattingEnabled = true;
            this.cboCarMaker.Items.AddRange(new object[] {
            "Toyota",
            "Nissan",
            "Honda",
            "Mercedez",
            "Chevy",
            "Dodge(Chrysler)",
            "Ford",
            "Hyundai",
            "Kia",
            "Mazda",
            "Mitsubishi",
            "Subaru"});
            this.cboCarMaker.Location = new System.Drawing.Point(322, 141);
            this.cboCarMaker.Name = "cboCarMaker";
            this.cboCarMaker.Size = new System.Drawing.Size(410, 28);
            this.cboCarMaker.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Car Plate Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car Rentage Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Maker (Brand):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Registration Id:";
            // 
            // cboCarRegId
            // 
            this.cboCarRegId.FormattingEnabled = true;
            this.cboCarRegId.Location = new System.Drawing.Point(322, 31);
            this.cboCarRegId.Name = "cboCarRegId";
            this.cboCarRegId.Size = new System.Drawing.Size(300, 28);
            this.cboCarRegId.TabIndex = 26;
            this.cboCarRegId.SelectedIndexChanged += new System.EventHandler(this.cboCarRegId_SelectedIndexChanged);
            // 
            // FrmEditCarRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedCarRentalSystem.Properties.Resources.cloud;
            this.ClientSize = new System.Drawing.Size(793, 432);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditCarRegistration";
            this.Text = "Edit Car Registration Form";
            this.Load += new System.EventHandler(this.FrmEditCarRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.ComboBox cboCarModel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCarPlateNumber;
        private System.Windows.Forms.TextBox txtCarRentageCost;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.ComboBox cboCarMaker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCarRegId;

    }
}