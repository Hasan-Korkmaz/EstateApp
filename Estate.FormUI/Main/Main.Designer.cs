namespace Estate.FormUI.Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.radImageUser = new Estate.FormUI.Main.RadiusImageBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnEditHouse = new System.Windows.Forms.Button();
            this.btnNewHouse = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormLogo)).BeginInit();
            this.pnlLeftBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radImageUser)).BeginInit();
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
            this.pnlTopBar.Size = new System.Drawing.Size(1420, 45);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(45, 12);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(326, 22);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Emlak Otomaston Version 0.1 beta";
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
            this.btnClose.Location = new System.Drawing.Point(1382, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftBar.Controls.Add(this.panel1);
            this.pnlLeftBar.Controls.Add(this.btnList);
            this.pnlLeftBar.Controls.Add(this.btnEditHouse);
            this.pnlLeftBar.Controls.Add(this.btnNewHouse);
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 45);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(197, 538);
            this.pnlLeftBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUserStatus);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.radImageUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.White;
            this.lblUserStatus.Location = new System.Drawing.Point(52, 45);
            this.lblUserStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(32, 15);
            this.lblUserStatus.TabIndex = 2;
            this.lblUserStatus.Text = "Aktif";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(51, 20);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 21);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            // 
            // radImageUser
            // 
            this.radImageUser.Image = global::Estate.FormUI.FormsResources.pexels_photo_614810;
            this.radImageUser.Location = new System.Drawing.Point(9, 17);
            this.radImageUser.Margin = new System.Windows.Forms.Padding(2);
            this.radImageUser.Name = "radImageUser";
            this.radImageUser.Size = new System.Drawing.Size(38, 38);
            this.radImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.radImageUser.TabIndex = 0;
            this.radImageUser.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = global::Estate.FormUI.FormsResources.Bulleted_List_32px;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(2, 91);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(180, 35);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Liste";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnEditHouse
            // 
            this.btnEditHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnEditHouse.FlatAppearance.BorderSize = 0;
            this.btnEditHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHouse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditHouse.ForeColor = System.Drawing.Color.White;
            this.btnEditHouse.Image = global::Estate.FormUI.FormsResources.Edit_Graph_Report_32px;
            this.btnEditHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditHouse.Location = new System.Drawing.Point(4, 48);
            this.btnEditHouse.Name = "btnEditHouse";
            this.btnEditHouse.Size = new System.Drawing.Size(180, 35);
            this.btnEditHouse.TabIndex = 2;
            this.btnEditHouse.Text = "Düzenle";
            this.btnEditHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditHouse.UseVisualStyleBackColor = false;
            this.btnEditHouse.Click += new System.EventHandler(this.btnEditHouse_Click);
            // 
            // btnNewHouse
            // 
            this.btnNewHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnNewHouse.FlatAppearance.BorderSize = 0;
            this.btnNewHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewHouse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewHouse.ForeColor = System.Drawing.Color.White;
            this.btnNewHouse.Image = global::Estate.FormUI.FormsResources.Plus_Math_32px;
            this.btnNewHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewHouse.Location = new System.Drawing.Point(4, 5);
            this.btnNewHouse.Name = "btnNewHouse";
            this.btnNewHouse.Size = new System.Drawing.Size(180, 35);
            this.btnNewHouse.TabIndex = 1;
            this.btnNewHouse.Text = "Yeni Ev Ekle";
            this.btnNewHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewHouse.UseVisualStyleBackColor = false;
            this.btnNewHouse.Click += new System.EventHandler(this.btnNewHouse_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(197, 45);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1223, 538);
            this.pnlMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1420, 583);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormLogo)).EndInit();
            this.pnlLeftBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radImageUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Button btnEditHouse;
        private System.Windows.Forms.Button btnNewHouse;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox lblFormLogo;
        private System.Windows.Forms.Panel panel1;
        private RadiusImageBox radImageUser;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlMain;
    }
}