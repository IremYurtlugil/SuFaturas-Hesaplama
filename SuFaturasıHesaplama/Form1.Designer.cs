
namespace SuFaturasıHesaplama
{
    partial class suFaturasi
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
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.lblSonIndex = new System.Windows.Forms.Label();
            this.lblIlkIndex = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtSonIndex = new System.Windows.Forms.TextBox();
            this.txtIlkIndex = new System.Windows.Forms.TextBox();
            this.grbKullanimYeri = new System.Windows.Forms.GroupBox();
            this.rdbtnUmumi = new System.Windows.Forms.RadioButton();
            this.rdbtnMesken = new System.Windows.Forms.RadioButton();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKulSuMiktari = new System.Windows.Forms.Label();
            this.lblFaturaTutari = new System.Windows.Forms.Label();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstSuMiktari = new System.Windows.Forms.ListBox();
            this.lstFaturaTutari = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.grbKullanimYeri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(12, 19);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(56, 13);
            this.lblAdiSoyadi.TabIndex = 0;
            this.lblAdiSoyadi.Text = "Ad Soyad:";
            // 
            // lblSonIndex
            // 
            this.lblSonIndex.AutoSize = true;
            this.lblSonIndex.Location = new System.Drawing.Point(12, 46);
            this.lblSonIndex.Name = "lblSonIndex";
            this.lblSonIndex.Size = new System.Drawing.Size(58, 13);
            this.lblSonIndex.TabIndex = 1;
            this.lblSonIndex.Text = "Son Index:";
            // 
            // lblIlkIndex
            // 
            this.lblIlkIndex.AutoSize = true;
            this.lblIlkIndex.Location = new System.Drawing.Point(12, 72);
            this.lblIlkIndex.Name = "lblIlkIndex";
            this.lblIlkIndex.Size = new System.Drawing.Size(47, 13);
            this.lblIlkIndex.TabIndex = 2;
            this.lblIlkIndex.Text = "Ilk Index";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(76, 12);
            this.txtAdiSoyadi.Multiline = true;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtAdiSoyadi.TabIndex = 3;
            // 
            // txtSonIndex
            // 
            this.txtSonIndex.Location = new System.Drawing.Point(76, 43);
            this.txtSonIndex.Name = "txtSonIndex";
            this.txtSonIndex.Size = new System.Drawing.Size(100, 20);
            this.txtSonIndex.TabIndex = 4;
            // 
            // txtIlkIndex
            // 
            this.txtIlkIndex.Location = new System.Drawing.Point(76, 69);
            this.txtIlkIndex.Name = "txtIlkIndex";
            this.txtIlkIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIlkIndex.TabIndex = 5;
            // 
            // grbKullanimYeri
            // 
            this.grbKullanimYeri.Controls.Add(this.rdbtnMesken);
            this.grbKullanimYeri.Controls.Add(this.rdbtnUmumi);
            this.grbKullanimYeri.Location = new System.Drawing.Point(12, 95);
            this.grbKullanimYeri.Name = "grbKullanimYeri";
            this.grbKullanimYeri.Size = new System.Drawing.Size(200, 100);
            this.grbKullanimYeri.TabIndex = 6;
            this.grbKullanimYeri.TabStop = false;
            this.grbKullanimYeri.Text = "Kullanım Yeri";
            // 
            // rdbtnUmumi
            // 
            this.rdbtnUmumi.AutoSize = true;
            this.rdbtnUmumi.Location = new System.Drawing.Point(7, 45);
            this.rdbtnUmumi.Name = "rdbtnUmumi";
            this.rdbtnUmumi.Size = new System.Drawing.Size(57, 17);
            this.rdbtnUmumi.TabIndex = 0;
            this.rdbtnUmumi.TabStop = true;
            this.rdbtnUmumi.Text = "Umumi";
            this.rdbtnUmumi.UseVisualStyleBackColor = true;
            // 
            // rdbtnMesken
            // 
            this.rdbtnMesken.AutoSize = true;
            this.rdbtnMesken.Location = new System.Drawing.Point(98, 45);
            this.rdbtnMesken.Name = "rdbtnMesken";
            this.rdbtnMesken.Size = new System.Drawing.Size(63, 17);
            this.rdbtnMesken.TabIndex = 1;
            this.rdbtnMesken.TabStop = true;
            this.rdbtnMesken.Text = "Mesken";
            this.rdbtnMesken.UseVisualStyleBackColor = true;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(319, 19);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 7;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblKulSuMiktari
            // 
            this.lblKulSuMiktari.AutoSize = true;
            this.lblKulSuMiktari.Location = new System.Drawing.Point(408, 19);
            this.lblKulSuMiktari.Name = "lblKulSuMiktari";
            this.lblKulSuMiktari.Size = new System.Drawing.Size(75, 13);
            this.lblKulSuMiktari.TabIndex = 8;
            this.lblKulSuMiktari.Text = "Kul. Su Miktarı";
            // 
            // lblFaturaTutari
            // 
            this.lblFaturaTutari.AutoSize = true;
            this.lblFaturaTutari.Location = new System.Drawing.Point(500, 19);
            this.lblFaturaTutari.Name = "lblFaturaTutari";
            this.lblFaturaTutari.Size = new System.Drawing.Size(67, 13);
            this.lblFaturaTutari.TabIndex = 9;
            this.lblFaturaTutari.Text = "Fatura Tutarı";
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.Location = new System.Drawing.Point(311, 35);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(77, 160);
            this.lstAdSoyad.TabIndex = 10;
            // 
            // lstSuMiktari
            // 
            this.lstSuMiktari.FormattingEnabled = true;
            this.lstSuMiktari.Location = new System.Drawing.Point(402, 35);
            this.lstSuMiktari.Name = "lstSuMiktari";
            this.lstSuMiktari.Size = new System.Drawing.Size(81, 160);
            this.lstSuMiktari.TabIndex = 11;
            // 
            // lstFaturaTutari
            // 
            this.lstFaturaTutari.FormattingEnabled = true;
            this.lstFaturaTutari.Location = new System.Drawing.Point(501, 35);
            this.lstFaturaTutari.Name = "lstFaturaTutari";
            this.lstFaturaTutari.Size = new System.Drawing.Size(82, 160);
            this.lstFaturaTutari.TabIndex = 12;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(137, 201);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 13;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // suFaturasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lstFaturaTutari);
            this.Controls.Add(this.lstSuMiktari);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.lblFaturaTutari);
            this.Controls.Add(this.lblKulSuMiktari);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.grbKullanimYeri);
            this.Controls.Add(this.txtIlkIndex);
            this.Controls.Add(this.txtSonIndex);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.lblIlkIndex);
            this.Controls.Add(this.lblSonIndex);
            this.Controls.Add(this.lblAdiSoyadi);
            this.Name = "suFaturasi";
            this.RightToLeftLayout = true;
            this.Text = "Su Faturası";
            this.Load += new System.EventHandler(this.suFaturasi_Load);
            this.grbKullanimYeri.ResumeLayout(false);
            this.grbKullanimYeri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdiSoyadi;
        private System.Windows.Forms.Label lblSonIndex;
        private System.Windows.Forms.Label lblIlkIndex;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtSonIndex;
        private System.Windows.Forms.TextBox txtIlkIndex;
        private System.Windows.Forms.GroupBox grbKullanimYeri;
        private System.Windows.Forms.RadioButton rdbtnMesken;
        private System.Windows.Forms.RadioButton rdbtnUmumi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblKulSuMiktari;
        private System.Windows.Forms.Label lblFaturaTutari;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.ListBox lstSuMiktari;
        private System.Windows.Forms.ListBox lstFaturaTutari;
        private System.Windows.Forms.Button btnHesapla;
    }
}

