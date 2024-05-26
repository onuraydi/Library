namespace Library.Library.WinFormUI.Forms
{
    partial class Dergiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dergiler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblNotlar = new DevExpress.XtraEditors.LabelControl();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.lblSayfa = new DevExpress.XtraEditors.LabelControl();
            this.lblSayi = new DevExpress.XtraEditors.LabelControl();
            this.lblTur = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.txedID = new DevExpress.XtraEditors.TextEdit();
            this.txedSayfa = new DevExpress.XtraEditors.TextEdit();
            this.txedSayi = new DevExpress.XtraEditors.TextEdit();
            this.txedTur = new DevExpress.XtraEditors.TextEdit();
            this.txedDergiAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblDergiAd = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txedID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedSayfa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedSayi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedDergiAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1226, 650);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.lblNotlar);
            this.groupControl1.Controls.Add(this.rtbNotlar);
            this.groupControl1.Controls.Add(this.lblSayfa);
            this.groupControl1.Controls.Add(this.lblSayi);
            this.groupControl1.Controls.Add(this.lblTur);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Controls.Add(this.txedID);
            this.groupControl1.Controls.Add(this.txedSayfa);
            this.groupControl1.Controls.Add(this.txedSayi);
            this.groupControl1.Controls.Add(this.txedTur);
            this.groupControl1.Controls.Add(this.txedDergiAdi);
            this.groupControl1.Controls.Add(this.lblDergiAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(983, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(240, 644);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(88, 544);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(147, 44);
            this.BtnTemizle.TabIndex = 19;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(88, 494);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(147, 44);
            this.BtnSil.TabIndex = 20;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(88, 444);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(147, 44);
            this.BtnGuncelle.TabIndex = 19;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(88, 394);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(147, 44);
            this.BtnEkle.TabIndex = 18;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblNotlar
            // 
            this.lblNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotlar.Appearance.Options.UseFont = true;
            this.lblNotlar.Location = new System.Drawing.Point(6, 239);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(53, 22);
            this.lblNotlar.TabIndex = 16;
            this.lblNotlar.Text = "Notlar:";
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotlar.Location = new System.Drawing.Point(88, 239);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(143, 136);
            this.rtbNotlar.TabIndex = 15;
            this.rtbNotlar.Text = "";
            // 
            // lblSayfa
            // 
            this.lblSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSayfa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayfa.Appearance.Options.UseFont = true;
            this.lblSayfa.Location = new System.Drawing.Point(6, 202);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(49, 22);
            this.lblSayfa.TabIndex = 12;
            this.lblSayfa.Text = "Sayfa:";
            // 
            // lblSayi
            // 
            this.lblSayi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSayi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayi.Appearance.Options.UseFont = true;
            this.lblSayi.Location = new System.Drawing.Point(5, 156);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(38, 22);
            this.lblSayi.TabIndex = 11;
            this.lblSayi.Text = "Sayı:";
            // 
            // lblTur
            // 
            this.lblTur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTur.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.Appearance.Options.UseFont = true;
            this.lblTur.Location = new System.Drawing.Point(6, 110);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(33, 22);
            this.lblTur.TabIndex = 10;
            this.lblTur.Text = "Tür:";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(5, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 22);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // txedID
            // 
            this.txedID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedID.Location = new System.Drawing.Point(88, 9);
            this.txedID.Name = "txedID";
            this.txedID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedID.Properties.Appearance.Options.UseFont = true;
            this.txedID.Size = new System.Drawing.Size(143, 40);
            this.txedID.TabIndex = 8;
            // 
            // txedSayfa
            // 
            this.txedSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedSayfa.Location = new System.Drawing.Point(88, 193);
            this.txedSayfa.Name = "txedSayfa";
            this.txedSayfa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedSayfa.Properties.Appearance.Options.UseFont = true;
            this.txedSayfa.Size = new System.Drawing.Size(143, 40);
            this.txedSayfa.TabIndex = 6;
            // 
            // txedSayi
            // 
            this.txedSayi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedSayi.Location = new System.Drawing.Point(88, 147);
            this.txedSayi.Name = "txedSayi";
            this.txedSayi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedSayi.Properties.Appearance.Options.UseFont = true;
            this.txedSayi.Size = new System.Drawing.Size(143, 40);
            this.txedSayi.TabIndex = 5;
            // 
            // txedTur
            // 
            this.txedTur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedTur.Location = new System.Drawing.Point(88, 101);
            this.txedTur.Name = "txedTur";
            this.txedTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedTur.Properties.Appearance.Options.UseFont = true;
            this.txedTur.Size = new System.Drawing.Size(143, 40);
            this.txedTur.TabIndex = 4;
            // 
            // txedDergiAdi
            // 
            this.txedDergiAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedDergiAdi.Location = new System.Drawing.Point(88, 55);
            this.txedDergiAdi.Name = "txedDergiAdi";
            this.txedDergiAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedDergiAdi.Properties.Appearance.Options.UseFont = true;
            this.txedDergiAdi.Size = new System.Drawing.Size(143, 40);
            this.txedDergiAdi.TabIndex = 1;
            // 
            // lblDergiAd
            // 
            this.lblDergiAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDergiAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDergiAd.Appearance.Options.UseFont = true;
            this.lblDergiAd.Location = new System.Drawing.Point(5, 64);
            this.lblDergiAd.Name = "lblDergiAd";
            this.lblDergiAd.Size = new System.Drawing.Size(78, 22);
            this.lblDergiAd.TabIndex = 0;
            this.lblDergiAd.Text = "Dergi Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(974, 644);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Dergiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dergiler";
            this.Text = "Dergiler";
            this.Load += new System.EventHandler(this.Dergiler_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txedID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedSayfa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedSayi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedDergiAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl lblNotlar;
        private System.Windows.Forms.RichTextBox rtbNotlar;
        private DevExpress.XtraEditors.LabelControl lblSayfa;
        private DevExpress.XtraEditors.LabelControl lblSayi;
        private DevExpress.XtraEditors.LabelControl lblTur;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txedID;
        private DevExpress.XtraEditors.TextEdit txedSayfa;
        private DevExpress.XtraEditors.TextEdit txedSayi;
        private DevExpress.XtraEditors.TextEdit txedTur;
        private DevExpress.XtraEditors.TextEdit txedDergiAdi;
        private DevExpress.XtraEditors.LabelControl lblDergiAd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}