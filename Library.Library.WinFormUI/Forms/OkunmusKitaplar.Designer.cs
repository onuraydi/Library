namespace Library.Library.WinFormUI
{
    partial class OkunmusKitaplar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkunmusKitaplar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblNotlar = new DevExpress.XtraEditors.LabelControl();
            this.rtbNotlar = new System.Windows.Forms.RichTextBox();
            this.lblSayfa = new DevExpress.XtraEditors.LabelControl();
            this.lblYayinEvi = new DevExpress.XtraEditors.LabelControl();
            this.lblTur = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblYazar = new DevExpress.XtraEditors.LabelControl();
            this.lblKitapAd = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txedID = new DevExpress.XtraEditors.TextEdit();
            this.txedSayfa = new DevExpress.XtraEditors.TextEdit();
            this.txedYayinEvi = new DevExpress.XtraEditors.TextEdit();
            this.txedTur = new DevExpress.XtraEditors.TextEdit();
            this.txedYazar = new DevExpress.XtraEditors.TextEdit();
            this.txedKitapAdi = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedSayfa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedYayinEvi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedYazar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedKitapAdi.Properties)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 685F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1207, 685);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.groupControl1.Controls.Add(this.lblYayinEvi);
            this.groupControl1.Controls.Add(this.lblTur);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Controls.Add(this.txedID);
            this.groupControl1.Controls.Add(this.txedSayfa);
            this.groupControl1.Controls.Add(this.txedYayinEvi);
            this.groupControl1.Controls.Add(this.txedTur);
            this.groupControl1.Controls.Add(this.txedYazar);
            this.groupControl1.Controls.Add(this.lblYazar);
            this.groupControl1.Controls.Add(this.txedKitapAdi);
            this.groupControl1.Controls.Add(this.lblKitapAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(968, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(236, 679);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // lblNotlar
            // 
            this.lblNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotlar.Appearance.Options.UseFont = true;
            this.lblNotlar.Location = new System.Drawing.Point(5, 285);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(53, 22);
            this.lblNotlar.TabIndex = 16;
            this.lblNotlar.Text = "Notlar:";
            // 
            // rtbNotlar
            // 
            this.rtbNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotlar.Location = new System.Drawing.Point(88, 285);
            this.rtbNotlar.Name = "rtbNotlar";
            this.rtbNotlar.Size = new System.Drawing.Size(139, 136);
            this.rtbNotlar.TabIndex = 15;
            this.rtbNotlar.Text = "";
            // 
            // lblSayfa
            // 
            this.lblSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSayfa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayfa.Appearance.Options.UseFont = true;
            this.lblSayfa.Location = new System.Drawing.Point(5, 248);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(49, 22);
            this.lblSayfa.TabIndex = 12;
            this.lblSayfa.Text = "Sayfa:";
            // 
            // lblYayinEvi
            // 
            this.lblYayinEvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYayinEvi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYayinEvi.Appearance.Options.UseFont = true;
            this.lblYayinEvi.Location = new System.Drawing.Point(5, 202);
            this.lblYayinEvi.Name = "lblYayinEvi";
            this.lblYayinEvi.Size = new System.Drawing.Size(77, 22);
            this.lblYayinEvi.TabIndex = 11;
            this.lblYayinEvi.Text = "Yayın Evi:";
            // 
            // lblTur
            // 
            this.lblTur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTur.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.Appearance.Options.UseFont = true;
            this.lblTur.Location = new System.Drawing.Point(5, 156);
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
            // lblYazar
            // 
            this.lblYazar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYazar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazar.Appearance.Options.UseFont = true;
            this.lblYazar.Location = new System.Drawing.Point(5, 110);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(48, 22);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKitapAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapAd.Appearance.Options.UseFont = true;
            this.lblKitapAd.Location = new System.Drawing.Point(5, 64);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(77, 22);
            this.lblKitapAd.TabIndex = 0;
            this.lblKitapAd.Text = "Kitap Adı:";
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
            this.dataGridView1.Size = new System.Drawing.Size(959, 679);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(88, 591);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(143, 44);
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
            this.BtnSil.Location = new System.Drawing.Point(88, 541);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(143, 44);
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
            this.BtnGuncelle.Location = new System.Drawing.Point(88, 491);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(143, 44);
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
            this.BtnEkle.Location = new System.Drawing.Point(88, 441);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(143, 44);
            this.BtnEkle.TabIndex = 18;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txedID
            // 
            this.txedID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedID.Location = new System.Drawing.Point(88, 9);
            this.txedID.Name = "txedID";
            this.txedID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedID.Properties.Appearance.Options.UseFont = true;
            this.txedID.Size = new System.Drawing.Size(139, 40);
            this.txedID.TabIndex = 8;
            // 
            // txedSayfa
            // 
            this.txedSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedSayfa.Location = new System.Drawing.Point(88, 239);
            this.txedSayfa.Name = "txedSayfa";
            this.txedSayfa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedSayfa.Properties.Appearance.Options.UseFont = true;
            this.txedSayfa.Size = new System.Drawing.Size(139, 40);
            this.txedSayfa.TabIndex = 6;
            // 
            // txedYayinEvi
            // 
            this.txedYayinEvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedYayinEvi.Location = new System.Drawing.Point(88, 193);
            this.txedYayinEvi.Name = "txedYayinEvi";
            this.txedYayinEvi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedYayinEvi.Properties.Appearance.Options.UseFont = true;
            this.txedYayinEvi.Size = new System.Drawing.Size(139, 40);
            this.txedYayinEvi.TabIndex = 5;
            // 
            // txedTur
            // 
            this.txedTur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedTur.Location = new System.Drawing.Point(88, 147);
            this.txedTur.Name = "txedTur";
            this.txedTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedTur.Properties.Appearance.Options.UseFont = true;
            this.txedTur.Size = new System.Drawing.Size(139, 40);
            this.txedTur.TabIndex = 4;
            // 
            // txedYazar
            // 
            this.txedYazar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedYazar.Location = new System.Drawing.Point(88, 101);
            this.txedYazar.Name = "txedYazar";
            this.txedYazar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedYazar.Properties.Appearance.Options.UseFont = true;
            this.txedYazar.Size = new System.Drawing.Size(139, 40);
            this.txedYazar.TabIndex = 3;
            // 
            // txedKitapAdi
            // 
            this.txedKitapAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txedKitapAdi.Location = new System.Drawing.Point(88, 55);
            this.txedKitapAdi.Name = "txedKitapAdi";
            this.txedKitapAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedKitapAdi.Properties.Appearance.Options.UseFont = true;
            this.txedKitapAdi.Size = new System.Drawing.Size(139, 40);
            this.txedKitapAdi.TabIndex = 1;
            // 
            // OkunmusKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OkunmusKitaplar";
            this.Text = "OkunmusKitaplar";
            this.Load += new System.EventHandler(this.OkunmusKitaplar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedSayfa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedYayinEvi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedYazar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedKitapAdi.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblYayinEvi;
        private DevExpress.XtraEditors.LabelControl lblTur;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txedID;
        private DevExpress.XtraEditors.TextEdit txedSayfa;
        private DevExpress.XtraEditors.TextEdit txedYayinEvi;
        private DevExpress.XtraEditors.TextEdit txedTur;
        private DevExpress.XtraEditors.TextEdit txedYazar;
        private DevExpress.XtraEditors.LabelControl lblYazar;
        private DevExpress.XtraEditors.TextEdit txedKitapAdi;
        private DevExpress.XtraEditors.LabelControl lblKitapAd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}