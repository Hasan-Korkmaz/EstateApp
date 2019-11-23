namespace Estate.FormUI.House
{
    partial class UINewHouse
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnADD = new System.Windows.Forms.Button();
            this.numSellorDeposit = new System.Windows.Forms.NumericUpDown();
            this.lblSell = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdSaleFalse = new System.Windows.Forms.RadioButton();
            this.rdSaleTrue = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellorDeposit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.numSellorDeposit);
            this.panel1.Controls.Add(this.lblSell);
            this.panel1.Controls.Add(this.panel2);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 435);
            this.panel1.TabIndex = 0;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::Estate.FormUI.FormsResources.Bulleted_List_32px;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.Location = new System.Drawing.Point(83, 382);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(210, 35);
            this.btnADD.TabIndex = 13;
            this.btnADD.Text = "Yeni Evi Ekle";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // numSellorDeposit
            // 
            this.numSellorDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSellorDeposit.Location = new System.Drawing.Point(137, 346);
            this.numSellorDeposit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numSellorDeposit.Name = "numSellorDeposit";
            this.numSellorDeposit.Size = new System.Drawing.Size(151, 23);
            this.numSellorDeposit.TabIndex = 12;
            this.numSellorDeposit.ThousandsSeparator = true;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.ForeColor = System.Drawing.Color.White;
            this.lblSell.Location = new System.Drawing.Point(28, 345);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(105, 21);
            this.lblSell.TabIndex = 29;
            this.lblSell.Text = "Satılık Fiyatı :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSaleFalse);
            this.panel2.Controls.Add(this.rdSaleTrue);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(8, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 36);
            this.panel2.TabIndex = 9;
            // 
            // rdSaleFalse
            // 
            this.rdSaleFalse.AutoSize = true;
            this.rdSaleFalse.ForeColor = System.Drawing.Color.White;
            this.rdSaleFalse.Location = new System.Drawing.Point(212, 6);
            this.rdSaleFalse.Name = "rdSaleFalse";
            this.rdSaleFalse.Size = new System.Drawing.Size(66, 25);
            this.rdSaleFalse.TabIndex = 11;
            this.rdSaleFalse.TabStop = true;
            this.rdSaleFalse.Text = "Hayır";
            this.rdSaleFalse.UseVisualStyleBackColor = true;
            this.rdSaleFalse.CheckedChanged += new System.EventHandler(this.rdSaleFalse_CheckedChanged);
            // 
            // rdSaleTrue
            // 
            this.rdSaleTrue.AutoSize = true;
            this.rdSaleTrue.ForeColor = System.Drawing.Color.White;
            this.rdSaleTrue.Location = new System.Drawing.Point(131, 6);
            this.rdSaleTrue.Name = "rdSaleTrue";
            this.rdSaleTrue.Size = new System.Drawing.Size(64, 25);
            this.rdSaleTrue.TabIndex = 10;
            this.rdSaleTrue.TabStop = true;
            this.rdSaleTrue.Text = "Evet";
            this.rdSaleTrue.UseVisualStyleBackColor = true;
            this.rdSaleTrue.CheckedChanged += new System.EventHandler(this.rdSaleTrue_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Satılık mı? :";
            // 
            // numDoorNumber
            // 
            this.numDoorNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDoorNumber.Location = new System.Drawing.Point(138, 273);
            this.numDoorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDoorNumber.Name = "numDoorNumber";
            this.numDoorNumber.Size = new System.Drawing.Size(151, 23);
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
            this.txtStreet.Location = new System.Drawing.Point(137, 237);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(153, 27);
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
            this.cmbDisc.Location = new System.Drawing.Point(138, 205);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(152, 29);
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
            this.cmbCities.Location = new System.Drawing.Point(137, 173);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(153, 29);
            this.cmbCities.TabIndex = 5;
            this.cmbCities.SelectedValueChanged += new System.EventHandler(this.cmbCities_SelectedValueChanged);
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
            this.cmbHouseType.Location = new System.Drawing.Point(137, 141);
            this.cmbHouseType.Name = "cmbHouseType";
            this.cmbHouseType.Size = new System.Drawing.Size(153, 29);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 107);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // numSize
            // 
            this.numSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSize.Location = new System.Drawing.Point(139, 81);
            this.numSize.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(151, 23);
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
            this.numFloor.Location = new System.Drawing.Point(138, 49);
            this.numFloor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(151, 23);
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
            this.numRoomCount.Location = new System.Drawing.Point(138, 17);
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
            // UINewHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UINewHouse";
            this.Size = new System.Drawing.Size(322, 449);
            this.Load += new System.EventHandler(this.UINewHouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellorDeposit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRoomCount;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHouseType;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDisc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.NumericUpDown numDoorNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.NumericUpDown numSellorDeposit;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdSaleFalse;
        private System.Windows.Forms.RadioButton rdSaleTrue;
        private System.Windows.Forms.Label label10;
    }
}
