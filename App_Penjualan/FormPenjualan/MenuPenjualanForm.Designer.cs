namespace App_Penjualan.FormPenjualan
{
    partial class MenuPenjualanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPenjualanForm));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.searchKodeBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitleBars = new System.Windows.Forms.Panel();
            this.BaseFormdataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.SubTools = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.inputJumlahBarangBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUang = new System.Windows.Forms.TextBox();
            this.labelKembali = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.TitleBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormdataGridViewData)).BeginInit();
            this.SubTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(629, 32);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kode/Nama Barang";
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Clock.Location = new System.Drawing.Point(354, 7);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(49, 15);
            this.Clock.TabIndex = 18;
            this.Clock.Text = "xx:xx:xx";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMin.BackgroundImage")));
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(701, 2);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(28, 26);
            this.BtnMin.TabIndex = 9;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMax.BackgroundImage")));
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Location = new System.Drawing.Point(735, 2);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(28, 26);
            this.BtnMax.TabIndex = 7;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aplikasi Penjualan";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(769, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 26);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // searchKodeBox
            // 
            this.searchKodeBox.Location = new System.Drawing.Point(187, 32);
            this.searchKodeBox.Name = "searchKodeBox";
            this.searchKodeBox.Size = new System.Drawing.Size(422, 20);
            this.searchKodeBox.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(168, 0);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(482, 32);
            this.labelJudul.TabIndex = 12;
            this.labelJudul.Text = "JUDUL";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonUbah);
            this.panel1.Controls.Add(this.buttonHapus);
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 27;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(672, 22);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(68, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(333, 16);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(104, 36);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonUbah
            // 
            this.buttonUbah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUbah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUbah.BackgroundImage")));
            this.buttonUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.Image = ((System.Drawing.Image)(resources.GetObject("buttonUbah.Image")));
            this.buttonUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUbah.Location = new System.Drawing.Point(80, 16);
            this.buttonUbah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(104, 36);
            this.buttonUbah.TabIndex = 1;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHapus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHapus.BackgroundImage")));
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Image = ((System.Drawing.Image)(resources.GetObject("buttonHapus.Image")));
            this.buttonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapus.Location = new System.Drawing.Point(208, 16);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(104, 37);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.Controls.Add(this.labelJudul);
            this.TitleBar.Location = new System.Drawing.Point(-32, 30);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(864, 33);
            this.TitleBar.TabIndex = 30;
            // 
            // TitleBars
            // 
            this.TitleBars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleBars.Controls.Add(this.Clock);
            this.TitleBars.Controls.Add(this.pictureBox1);
            this.TitleBars.Controls.Add(this.BtnMin);
            this.TitleBars.Controls.Add(this.BtnMax);
            this.TitleBars.Controls.Add(this.label4);
            this.TitleBars.Controls.Add(this.BtnClose);
            this.TitleBars.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBars.Location = new System.Drawing.Point(0, 0);
            this.TitleBars.Name = "TitleBars";
            this.TitleBars.Size = new System.Drawing.Size(800, 30);
            this.TitleBars.TabIndex = 29;
            this.TitleBars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBars_MouseDown);
            // 
            // BaseFormdataGridViewData
            // 
            this.BaseFormdataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BaseFormdataGridViewData.Location = new System.Drawing.Point(25, 166);
            this.BaseFormdataGridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.BaseFormdataGridViewData.Name = "BaseFormdataGridViewData";
            this.BaseFormdataGridViewData.RowHeadersWidth = 51;
            this.BaseFormdataGridViewData.RowTemplate.Height = 24;
            this.BaseFormdataGridViewData.Size = new System.Drawing.Size(475, 193);
            this.BaseFormdataGridViewData.TabIndex = 28;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTambah.BackgroundImage")));
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Image = ((System.Drawing.Image)(resources.GetObject("buttonTambah.Image")));
            this.buttonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambah.Location = new System.Drawing.Point(537, 326);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(96, 33);
            this.buttonTambah.TabIndex = 0;
            this.buttonTambah.Text = "Cetak Nota";
            this.buttonTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // SubTools
            // 
            this.SubTools.BackColor = System.Drawing.Color.DimGray;
            this.SubTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubTools.BackgroundImage")));
            this.SubTools.Controls.Add(this.label3);
            this.SubTools.Controls.Add(this.dateTimePicker1);
            this.SubTools.Controls.Add(this.button1);
            this.SubTools.Controls.Add(this.inputJumlahBarangBox);
            this.SubTools.Controls.Add(this.label2);
            this.SubTools.Controls.Add(this.buttonSearch);
            this.SubTools.Controls.Add(this.searchKodeBox);
            this.SubTools.Controls.Add(this.label1);
            this.SubTools.Location = new System.Drawing.Point(0, 63);
            this.SubTools.Name = "SubTools";
            this.SubTools.Size = new System.Drawing.Size(800, 87);
            this.SubTools.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tanggal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(629, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // inputJumlahBarangBox
            // 
            this.inputJumlahBarangBox.Location = new System.Drawing.Point(187, 58);
            this.inputJumlahBarangBox.Name = "inputJumlahBarangBox";
            this.inputJumlahBarangBox.Size = new System.Drawing.Size(422, 20);
            this.inputJumlahBarangBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Jumlah Barang";
            // 
            // textBoxUang
            // 
            this.textBoxUang.Location = new System.Drawing.Point(634, 258);
            this.textBoxUang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUang.Name = "textBoxUang";
            this.textBoxUang.Size = new System.Drawing.Size(121, 20);
            this.textBoxUang.TabIndex = 39;
            // 
            // labelKembali
            // 
            this.labelKembali.AutoSize = true;
            this.labelKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKembali.Location = new System.Drawing.Point(534, 296);
            this.labelKembali.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKembali.Name = "labelKembali";
            this.labelKembali.Size = new System.Drawing.Size(73, 17);
            this.labelKembali.TabIndex = 38;
            this.labelKembali.Text = "KEMBALI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "BAYAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "TOTAL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 293);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 40;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(634, 217);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 41;
            // 
            // MenuPenjualanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxUang);
            this.Controls.Add(this.labelKembali);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.SubTools);
            this.Controls.Add(this.BaseFormdataGridViewData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.TitleBars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPenjualanForm";
            this.Text = "MenuPenjualanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.TitleBars.ResumeLayout(false);
            this.TitleBars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFormdataGridViewData)).EndInit();
            this.SubTools.ResumeLayout(false);
            this.SubTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClose;
        public System.Windows.Forms.TextBox searchKodeBox;
        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Label labelJudul;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button buttonClose;
        protected System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel TitleBars;
        public System.Windows.Forms.DataGridView BaseFormdataGridViewData;
        protected System.Windows.Forms.Button buttonUbah;
        public System.Windows.Forms.Button buttonHapus;
        protected System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel SubTools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox inputJumlahBarangBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUang;
        private System.Windows.Forms.Label labelKembali;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}