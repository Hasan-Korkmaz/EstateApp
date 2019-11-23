namespace Estate.FormUI.House
{
    partial class UiEditHouse
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numRentPrice = new System.Windows.Forms.NumericUpDown();
            this.lblRentPrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.numSellorDeposit = new System.Windows.Forms.NumericUpDown();
            this.lblSell = new System.Windows.Forms.Label();
            this.numDoorNumber = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHouseType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numRoomCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellorDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.lblFormTitle);
            this.pnlTopBar.Controls.Add(this.lblFormLogo);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(318, 45);
            this.pnlTopBar.TabIndex = 19;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(45, 12);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(114, 22);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Evi Düzenle";
            // 
            // lblFormLogo
            // 
            this.lblFormLogo.Image = global::Estate.FormUI.FormsResources.MyTeslaLogo;
            this.lblFormLogo.Location = new System.Drawing.Point(2, 3);
            this.lblFormLogo.Margin = new System.Windows.Forms.Padding(2);
            this.lblFormLogo.Name = "lblFormLogo";
            this.lblFormLogo.Size = new System.Drawing.Size(38, 38);
            this.lblFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblFormLogo.TabIndex = 0;
            this.lblFormLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Estate.FormUI.FormsResources.Multiply_32px;
            this.btnClose.Location = new System.Drawing.Point(280, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numRentPrice);
            this.panel1.Controls.Add(this.lblRentPrice);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.numSellorDeposit);
            this.panel1.Controls.Add(this.lblSell);
            this.panel1.Controls.Add(this.numDoorNumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtStreet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbDisc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCities);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbHouseType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.numSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numFloor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numRoomCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(6, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 411);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Estate.FormUI.FormsResources.Picture_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "Resim Klasörünü Göster";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numRentPrice
            // 
            this.numRentPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRentPrice.Location = new System.Drawing.Point(135, 305);
            this.numRentPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numRentPrice.Name = "numRentPrice";
            this.numRentPrice.Size = new System.Drawing.Size(156, 23);
            this.numRentPrice.TabIndex = 30;
            this.numRentPrice.ThousandsSeparator = true;
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.AutoSize = true;
            this.lblRentPrice.ForeColor = System.Drawing.Color.White;
            this.lblRentPrice.Location = new System.Drawing.Point(43, 304);
            this.lblRentPrice.Name = "lblRentPrice";
            this.lblRentPrice.Size = new System.Drawing.Size(90, 21);
            this.lblRentPrice.TabIndex = 31;
            this.lblRentPrice.Text = "Kira Fiyatı :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Estate.FormUI.FormsResources.Edit_Graph_Report_32px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(135, 366);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 35);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Güncelle";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // numSellorDeposit
            // 
            this.numSellorDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSellorDeposit.Location = new System.Drawing.Point(135, 337);
            this.numSellorDeposit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numSellorDeposit.Name = "numSellorDeposit";
            this.numSellorDeposit.Size = new System.Drawing.Size(156, 23);
            this.numSellorDeposit.TabIndex = 12;
            this.numSellorDeposit.ThousandsSeparator = true;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.ForeColor = System.Drawing.Color.White;
            this.lblSell.Location = new System.Drawing.Point(28, 336);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(105, 21);
            this.lblSell.TabIndex = 29;
            this.lblSell.Text = "Satılık Fiyatı :";
            // 
            // numDoorNumber
            // 
            this.numDoorNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDoorNumber.Location = new System.Drawing.Point(135, 273);
            this.numDoorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDoorNumber.Name = "numDoorNumber";
            this.numDoorNumber.Size = new System.Drawing.Size(156, 23);
            this.numDoorNumber.TabIndex = 8;
            this.numDoorNumber.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kapı Numarası :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cadde/Sokak :";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(135, 238);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(156, 27);
            this.txtStreet.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(87, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "İlçe :";
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(135, 205);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(156, 29);
            this.cmbDisc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Şehir :";
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(135, 173);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(156, 29);
            this.cmbCities.TabIndex = 5;
            this.cmbCities.SelectedIndexChanged += new System.EventHandler(this.cmbCities_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Evin Tipi :";
            // 
            // cmbHouseType
            // 
            this.cmbHouseType.FormattingEnabled = true;
            this.cmbHouseType.Location = new System.Drawing.Point(135, 141);
            this.cmbHouseType.Name = "cmbHouseType";
            this.cmbHouseType.Size = new System.Drawing.Size(156, 29);
            this.cmbHouseType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yapım Yılı :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 110);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // numSize
            // 
            this.numSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSize.Location = new System.Drawing.Point(137, 81);
            this.numSize.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(154, 23);
            this.numSize.TabIndex = 2;
            this.numSize.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Evin Genişliği :";
            // 
            // numFloor
            // 
            this.numFloor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFloor.Location = new System.Drawing.Point(137, 49);
            this.numFloor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(154, 23);
            this.numFloor.TabIndex = 1;
            this.numFloor.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kat Numarası :";
            // 
            // numRoomCount
            // 
            this.numRoomCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRoomCount.Location = new System.Drawing.Point(139, 17);
            this.numRoomCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRoomCount.Name = "numRoomCount";
            this.numRoomCount.Size = new System.Drawing.Size(152, 23);
            this.numRoomCount.TabIndex = 0;
            this.numRoomCount.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oda Sayısı : ";
            // 
            // UiEditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(318, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UiEditHouse";
            this.Text = "UiEditHouse";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellorDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCount)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox lblFormLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numRentPrice;
        private System.Windows.Forms.Label lblRentPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown numSellorDeposit;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.NumericUpDown numDoorNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDisc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHouseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRoomCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}