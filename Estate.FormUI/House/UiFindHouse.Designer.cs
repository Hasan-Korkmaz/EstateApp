namespace Estate.FormUI.House
{
    partial class UiFindHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.numDepositMax = new System.Windows.Forms.NumericUpDown();
            this.numDepositMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.numRoomCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHouseType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chIsArchive = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdRent = new System.Windows.Forms.RadioButton();
            this.rdSale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHouseList = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.pnlDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlDeposit);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.numRoomCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbDisc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbCities);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbHouseType);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 128);
            this.panel1.TabIndex = 5;
            // 
            // numSize
            // 
            this.numSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSize.Location = new System.Drawing.Point(260, 93);
            this.numSize.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(88, 23);
            this.numSize.TabIndex = 12;
            this.numSize.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(124, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Evin Genişliği :";
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Controls.Add(this.numDepositMax);
            this.pnlDeposit.Controls.Add(this.numDepositMin);
            this.pnlDeposit.Controls.Add(this.label1);
            this.pnlDeposit.Controls.Add(this.label3);
            this.pnlDeposit.Location = new System.Drawing.Point(820, 12);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(260, 72);
            this.pnlDeposit.TabIndex = 13;
            // 
            // numDepositMax
            // 
            this.numDepositMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDepositMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDepositMax.Location = new System.Drawing.Point(138, 44);
            this.numDepositMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDepositMax.Name = "numDepositMax";
            this.numDepositMax.Size = new System.Drawing.Size(112, 23);
            this.numDepositMax.TabIndex = 15;
            this.numDepositMax.ThousandsSeparator = true;
            // 
            // numDepositMin
            // 
            this.numDepositMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDepositMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDepositMin.Location = new System.Drawing.Point(138, 5);
            this.numDepositMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDepositMin.Name = "numDepositMin";
            this.numDepositMin.Size = new System.Drawing.Size(112, 23);
            this.numDepositMin.TabIndex = 14;
            this.numDepositMin.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Depozito Max :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Depozito Min :";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::Estate.FormUI.FormsResources.Search_32px;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.Location = new System.Drawing.Point(1086, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(128, 48);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Ara";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // numMax
            // 
            this.numMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMax.Location = new System.Drawing.Point(685, 54);
            this.numMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(129, 23);
            this.numMax.TabIndex = 11;
            this.numMax.ThousandsSeparator = true;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(579, 55);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(84, 21);
            this.lblMax.TabIndex = 33;
            this.lblMax.Text = "Kira Max :";
            // 
            // numMin
            // 
            this.numMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMin.Location = new System.Drawing.Point(685, 14);
            this.numMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(129, 23);
            this.numMin.TabIndex = 8;
            this.numMin.ThousandsSeparator = true;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(579, 15);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(78, 21);
            this.lblMin.TabIndex = 31;
            this.lblMin.Text = "Kira Min :";
            // 
            // numRoomCount
            // 
            this.numRoomCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numRoomCount.Location = new System.Drawing.Point(231, 54);
            this.numRoomCount.Name = "numRoomCount";
            this.numRoomCount.Size = new System.Drawing.Size(118, 23);
            this.numRoomCount.TabIndex = 9;
            this.numRoomCount.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Oda Sayısı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(366, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "İlçe :";
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(417, 51);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(152, 29);
            this.cmbDisc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(358, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Şehir :";
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(416, 11);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(153, 29);
            this.cmbCities.TabIndex = 7;
            this.cmbCities.SelectedIndexChanged += new System.EventHandler(this.cmbCities_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(125, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Evin Tipi :";
            // 
            // cmbHouseType
            // 
            this.cmbHouseType.FormattingEnabled = true;
            this.cmbHouseType.Location = new System.Drawing.Point(208, 11);
            this.cmbHouseType.Name = "cmbHouseType";
            this.cmbHouseType.Size = new System.Drawing.Size(141, 29);
            this.cmbHouseType.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 126);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chIsArchive);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 39);
            this.panel5.TabIndex = 3;
            // 
            // chIsArchive
            // 
            this.chIsArchive.AutoSize = true;
            this.chIsArchive.ForeColor = System.Drawing.Color.White;
            this.chIsArchive.Location = new System.Drawing.Point(5, 6);
            this.chIsArchive.Name = "chIsArchive";
            this.chIsArchive.Size = new System.Drawing.Size(66, 25);
            this.chIsArchive.TabIndex = 4;
            this.chIsArchive.Text = "Arşiv";
            this.chIsArchive.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdRent);
            this.panel4.Controls.Add(this.rdSale);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 85);
            this.panel4.TabIndex = 0;
            // 
            // rdRent
            // 
            this.rdRent.AutoSize = true;
            this.rdRent.ForeColor = System.Drawing.Color.White;
            this.rdRent.Location = new System.Drawing.Point(5, 50);
            this.rdRent.Name = "rdRent";
            this.rdRent.Size = new System.Drawing.Size(70, 25);
            this.rdRent.TabIndex = 2;
            this.rdRent.TabStop = true;
            this.rdRent.Text = "Kiralık";
            this.rdRent.UseVisualStyleBackColor = true;
            // 
            // rdSale
            // 
            this.rdSale.AutoSize = true;
            this.rdSale.ForeColor = System.Drawing.Color.White;
            this.rdSale.Location = new System.Drawing.Point(5, 11);
            this.rdSale.Name = "rdSale";
            this.rdSale.Size = new System.Drawing.Size(71, 25);
            this.rdSale.TabIndex = 1;
            this.rdSale.TabStop = true;
            this.rdSale.Text = "Satılık";
            this.rdSale.UseVisualStyleBackColor = true;
            this.rdSale.CheckedChanged += new System.EventHandler(this.rdSale_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHouseList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 372);
            this.panel2.TabIndex = 19;
            // 
            // dgvHouseList
            // 
            this.dgvHouseList.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            this.dgvHouseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHouseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHouseList.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvHouseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHouseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHouseList.Location = new System.Drawing.Point(0, 0);
            this.dgvHouseList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHouseList.MultiSelect = false;
            this.dgvHouseList.Name = "dgvHouseList";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dgvHouseList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvHouseList.RowTemplate.Height = 24;
            this.dgvHouseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouseList.Size = new System.Drawing.Size(1032, 372);
            this.dgvHouseList.TabIndex = 45;
            this.dgvHouseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHouseList_CellClick);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::Estate.FormUI.FormsResources.Eye_32px;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.Location = new System.Drawing.Point(1037, 236);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 48);
            this.btnShow.TabIndex = 39;
            this.btnShow.Text = "Görüntüle";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Estate.FormUI.FormsResources.Trash_32px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(1037, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 48);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Estate.FormUI.FormsResources.Edit_Graph_Report_32px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(1037, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 48);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UiFindHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Name = "UiFindHouse";
            this.Size = new System.Drawing.Size(1218, 500);
            this.Load += new System.EventHandler(this.UiFindHouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdRent;
        private System.Windows.Forms.RadioButton rdSale;
        private System.Windows.Forms.DataGridView dgvHouseList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHouseType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDisc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.NumericUpDown numRoomCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.NumericUpDown numDepositMax;
        private System.Windows.Forms.NumericUpDown numDepositMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chIsArchive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
    }
}
