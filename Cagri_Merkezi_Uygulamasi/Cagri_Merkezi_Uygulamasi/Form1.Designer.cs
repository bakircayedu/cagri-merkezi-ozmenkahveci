
namespace Cagri_Merkezi_Uygulamasi
{
    partial class frmCagriMerkezi
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblMusteriTuru = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtMusteriTuru = new System.Windows.Forms.TextBox();
            this.grpCagriOlusturucu = new System.Windows.Forms.GroupBox();
            this.btnCagriOlustur = new System.Windows.Forms.Button();
            this.btnKayıtlar = new System.Windows.Forms.Button();
            this.tabMusteriler = new System.Windows.Forms.TabControl();
            this.tabBireyselMT_1 = new System.Windows.Forms.TabPage();
            this.listBireyselMT_1 = new System.Windows.Forms.DataGridView();
            this.tabBireyselMT_2 = new System.Windows.Forms.TabPage();
            this.listBireyselMT_2 = new System.Windows.Forms.DataGridView();
            this.tabTicariMT_1 = new System.Windows.Forms.TabPage();
            this.listTicariMT_1 = new System.Windows.Forms.DataGridView();
            this.tabTicariMT_2 = new System.Windows.Forms.TabPage();
            this.listTicariMT_2 = new System.Windows.Forms.DataGridView();
            this.btnSiralaArama = new System.Windows.Forms.Button();
            this.btnSiralaNo = new System.Windows.Forms.Button();
            this.grpHattaBagla = new System.Windows.Forms.GroupBox();
            this.btnHattaBagla = new System.Windows.Forms.Button();
            this.txtMusteriNoGir = new System.Windows.Forms.TextBox();
            this.lblMusteriNoGir = new System.Windows.Forms.Label();
            this.grpCagriOlusturucu.SuspendLayout();
            this.tabMusteriler.SuspendLayout();
            this.tabBireyselMT_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBireyselMT_1)).BeginInit();
            this.tabBireyselMT_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBireyselMT_2)).BeginInit();
            this.tabTicariMT_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTicariMT_1)).BeginInit();
            this.tabTicariMT_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTicariMT_2)).BeginInit();
            this.grpHattaBagla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(32, 34);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(88, 13);
            this.lblMusteriNo.TabIndex = 0;
            this.lblMusteriNo.Text = "Müşteri Numarası";
            // 
            // lblMusteriTuru
            // 
            this.lblMusteriTuru.AutoSize = true;
            this.lblMusteriTuru.Location = new System.Drawing.Point(32, 71);
            this.lblMusteriTuru.Name = "lblMusteriTuru";
            this.lblMusteriTuru.Size = new System.Drawing.Size(66, 13);
            this.lblMusteriTuru.TabIndex = 1;
            this.lblMusteriTuru.Text = "Müşteri Türü";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(136, 31);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriNo.TabIndex = 2;
            // 
            // txtMusteriTuru
            // 
            this.txtMusteriTuru.Location = new System.Drawing.Point(136, 68);
            this.txtMusteriTuru.Name = "txtMusteriTuru";
            this.txtMusteriTuru.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTuru.TabIndex = 3;
            // 
            // grpCagriOlusturucu
            // 
            this.grpCagriOlusturucu.Controls.Add(this.btnCagriOlustur);
            this.grpCagriOlusturucu.Controls.Add(this.lblMusteriNo);
            this.grpCagriOlusturucu.Controls.Add(this.btnKayıtlar);
            this.grpCagriOlusturucu.Controls.Add(this.txtMusteriTuru);
            this.grpCagriOlusturucu.Controls.Add(this.lblMusteriTuru);
            this.grpCagriOlusturucu.Controls.Add(this.txtMusteriNo);
            this.grpCagriOlusturucu.Location = new System.Drawing.Point(24, 25);
            this.grpCagriOlusturucu.Name = "grpCagriOlusturucu";
            this.grpCagriOlusturucu.Size = new System.Drawing.Size(328, 169);
            this.grpCagriOlusturucu.TabIndex = 4;
            this.grpCagriOlusturucu.TabStop = false;
            this.grpCagriOlusturucu.Text = "Çağrı Oluştur";
            // 
            // btnCagriOlustur
            // 
            this.btnCagriOlustur.Location = new System.Drawing.Point(198, 125);
            this.btnCagriOlustur.Name = "btnCagriOlustur";
            this.btnCagriOlustur.Size = new System.Drawing.Size(124, 38);
            this.btnCagriOlustur.TabIndex = 4;
            this.btnCagriOlustur.Text = "Çağrı Oluştur";
            this.btnCagriOlustur.UseVisualStyleBackColor = true;
            this.btnCagriOlustur.Click += new System.EventHandler(this.btnCagriOlustur_Click);
            // 
            // btnKayıtlar
            // 
            this.btnKayıtlar.Location = new System.Drawing.Point(13, 125);
            this.btnKayıtlar.Name = "btnKayıtlar";
            this.btnKayıtlar.Size = new System.Drawing.Size(135, 38);
            this.btnKayıtlar.TabIndex = 5;
            this.btnKayıtlar.Text = "Varsayılan Kayıtları Yükle";
            this.btnKayıtlar.UseVisualStyleBackColor = true;
            this.btnKayıtlar.Click += new System.EventHandler(this.btnKayıtlar_Click);
            // 
            // tabMusteriler
            // 
            this.tabMusteriler.Controls.Add(this.tabBireyselMT_1);
            this.tabMusteriler.Controls.Add(this.tabBireyselMT_2);
            this.tabMusteriler.Controls.Add(this.tabTicariMT_1);
            this.tabMusteriler.Controls.Add(this.tabTicariMT_2);
            this.tabMusteriler.Location = new System.Drawing.Point(128, 327);
            this.tabMusteriler.Name = "tabMusteriler";
            this.tabMusteriler.SelectedIndex = 0;
            this.tabMusteriler.Size = new System.Drawing.Size(576, 285);
            this.tabMusteriler.TabIndex = 6;
            // 
            // tabBireyselMT_1
            // 
            this.tabBireyselMT_1.Controls.Add(this.listBireyselMT_1);
            this.tabBireyselMT_1.Location = new System.Drawing.Point(4, 22);
            this.tabBireyselMT_1.Name = "tabBireyselMT_1";
            this.tabBireyselMT_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBireyselMT_1.Size = new System.Drawing.Size(568, 259);
            this.tabBireyselMT_1.TabIndex = 0;
            this.tabBireyselMT_1.Text = "Bireysel Müşteri Temsilcisi 1";
            this.tabBireyselMT_1.UseVisualStyleBackColor = true;
            // 
            // listBireyselMT_1
            // 
            this.listBireyselMT_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBireyselMT_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBireyselMT_1.Location = new System.Drawing.Point(3, 3);
            this.listBireyselMT_1.Name = "listBireyselMT_1";
            this.listBireyselMT_1.Size = new System.Drawing.Size(562, 253);
            this.listBireyselMT_1.TabIndex = 9;
            // 
            // tabBireyselMT_2
            // 
            this.tabBireyselMT_2.Controls.Add(this.listBireyselMT_2);
            this.tabBireyselMT_2.Location = new System.Drawing.Point(4, 22);
            this.tabBireyselMT_2.Name = "tabBireyselMT_2";
            this.tabBireyselMT_2.Padding = new System.Windows.Forms.Padding(3);
            this.tabBireyselMT_2.Size = new System.Drawing.Size(568, 259);
            this.tabBireyselMT_2.TabIndex = 1;
            this.tabBireyselMT_2.Text = "Bireysel Müşteri Temsilcisi 2";
            this.tabBireyselMT_2.UseVisualStyleBackColor = true;
            // 
            // listBireyselMT_2
            // 
            this.listBireyselMT_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBireyselMT_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBireyselMT_2.Location = new System.Drawing.Point(3, 3);
            this.listBireyselMT_2.Name = "listBireyselMT_2";
            this.listBireyselMT_2.Size = new System.Drawing.Size(562, 253);
            this.listBireyselMT_2.TabIndex = 0;
            // 
            // tabTicariMT_1
            // 
            this.tabTicariMT_1.Controls.Add(this.listTicariMT_1);
            this.tabTicariMT_1.Location = new System.Drawing.Point(4, 22);
            this.tabTicariMT_1.Name = "tabTicariMT_1";
            this.tabTicariMT_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicariMT_1.Size = new System.Drawing.Size(568, 259);
            this.tabTicariMT_1.TabIndex = 2;
            this.tabTicariMT_1.Text = "Ticari Müşteri Temsilcisi 1";
            this.tabTicariMT_1.UseVisualStyleBackColor = true;
            // 
            // listTicariMT_1
            // 
            this.listTicariMT_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTicariMT_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTicariMT_1.Location = new System.Drawing.Point(3, 3);
            this.listTicariMT_1.Name = "listTicariMT_1";
            this.listTicariMT_1.Size = new System.Drawing.Size(562, 253);
            this.listTicariMT_1.TabIndex = 0;
            // 
            // tabTicariMT_2
            // 
            this.tabTicariMT_2.Controls.Add(this.listTicariMT_2);
            this.tabTicariMT_2.Location = new System.Drawing.Point(4, 22);
            this.tabTicariMT_2.Name = "tabTicariMT_2";
            this.tabTicariMT_2.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicariMT_2.Size = new System.Drawing.Size(568, 259);
            this.tabTicariMT_2.TabIndex = 3;
            this.tabTicariMT_2.Text = "Ticari Müşteri Temsilcisi 2";
            this.tabTicariMT_2.UseVisualStyleBackColor = true;
            // 
            // listTicariMT_2
            // 
            this.listTicariMT_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTicariMT_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTicariMT_2.Location = new System.Drawing.Point(3, 3);
            this.listTicariMT_2.Name = "listTicariMT_2";
            this.listTicariMT_2.Size = new System.Drawing.Size(562, 253);
            this.listTicariMT_2.TabIndex = 0;
            // 
            // btnSiralaArama
            // 
            this.btnSiralaArama.Location = new System.Drawing.Point(138, 298);
            this.btnSiralaArama.Name = "btnSiralaArama";
            this.btnSiralaArama.Size = new System.Drawing.Size(122, 23);
            this.btnSiralaArama.TabIndex = 7;
            this.btnSiralaArama.Text = "Aramaya Göre Sırala";
            this.btnSiralaArama.UseVisualStyleBackColor = true;
            this.btnSiralaArama.Click += new System.EventHandler(this.btnSiralaArama_Click);
            // 
            // btnSiralaNo
            // 
            this.btnSiralaNo.Location = new System.Drawing.Point(266, 298);
            this.btnSiralaNo.Name = "btnSiralaNo";
            this.btnSiralaNo.Size = new System.Drawing.Size(184, 23);
            this.btnSiralaNo.TabIndex = 8;
            this.btnSiralaNo.Text = "Müşteri Numarasına Göre Sırala";
            this.btnSiralaNo.UseVisualStyleBackColor = true;
            this.btnSiralaNo.Click += new System.EventHandler(this.btnSiralaNo_Click);
            // 
            // grpHattaBagla
            // 
            this.grpHattaBagla.Controls.Add(this.btnHattaBagla);
            this.grpHattaBagla.Controls.Add(this.txtMusteriNoGir);
            this.grpHattaBagla.Controls.Add(this.lblMusteriNoGir);
            this.grpHattaBagla.Location = new System.Drawing.Point(476, 25);
            this.grpHattaBagla.Name = "grpHattaBagla";
            this.grpHattaBagla.Size = new System.Drawing.Size(348, 169);
            this.grpHattaBagla.TabIndex = 9;
            this.grpHattaBagla.TabStop = false;
            this.grpHattaBagla.Text = "Görüşmeyi Başlat";
            // 
            // btnHattaBagla
            // 
            this.btnHattaBagla.Location = new System.Drawing.Point(210, 125);
            this.btnHattaBagla.Name = "btnHattaBagla";
            this.btnHattaBagla.Size = new System.Drawing.Size(132, 38);
            this.btnHattaBagla.TabIndex = 2;
            this.btnHattaBagla.Text = "Belirtilen Müşteriyle Görüş";
            this.btnHattaBagla.UseVisualStyleBackColor = true;
            this.btnHattaBagla.Click += new System.EventHandler(this.btnHattaBagla_Click);
            // 
            // txtMusteriNoGir
            // 
            this.txtMusteriNoGir.Location = new System.Drawing.Point(175, 34);
            this.txtMusteriNoGir.Name = "txtMusteriNoGir";
            this.txtMusteriNoGir.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriNoGir.TabIndex = 1;
            // 
            // lblMusteriNoGir
            // 
            this.lblMusteriNoGir.AutoSize = true;
            this.lblMusteriNoGir.Location = new System.Drawing.Point(41, 34);
            this.lblMusteriNoGir.Name = "lblMusteriNoGir";
            this.lblMusteriNoGir.Size = new System.Drawing.Size(127, 13);
            this.lblMusteriNoGir.TabIndex = 0;
            this.lblMusteriNoGir.Text = "Müşteri Numarasını Giriniz";
            // 
            // frmCagriMerkezi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 624);
            this.Controls.Add(this.grpHattaBagla);
            this.Controls.Add(this.btnSiralaNo);
            this.Controls.Add(this.btnSiralaArama);
            this.Controls.Add(this.tabMusteriler);
            this.Controls.Add(this.grpCagriOlusturucu);
            this.Name = "frmCagriMerkezi";
            this.Text = "Çağrı Merkezi";
            this.grpCagriOlusturucu.ResumeLayout(false);
            this.grpCagriOlusturucu.PerformLayout();
            this.tabMusteriler.ResumeLayout(false);
            this.tabBireyselMT_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBireyselMT_1)).EndInit();
            this.tabBireyselMT_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBireyselMT_2)).EndInit();
            this.tabTicariMT_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTicariMT_1)).EndInit();
            this.tabTicariMT_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTicariMT_2)).EndInit();
            this.grpHattaBagla.ResumeLayout(false);
            this.grpHattaBagla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblMusteriTuru;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtMusteriTuru;
        private System.Windows.Forms.GroupBox grpCagriOlusturucu;
        private System.Windows.Forms.Button btnCagriOlustur;
        private System.Windows.Forms.Button btnKayıtlar;
        private System.Windows.Forms.TabControl tabMusteriler;
        private System.Windows.Forms.TabPage tabBireyselMT_1;
        private System.Windows.Forms.TabPage tabBireyselMT_2;
        private System.Windows.Forms.TabPage tabTicariMT_1;
        private System.Windows.Forms.TabPage tabTicariMT_2;
        private System.Windows.Forms.Button btnSiralaArama;
        private System.Windows.Forms.Button btnSiralaNo;
        private System.Windows.Forms.DataGridView listBireyselMT_1;
        private System.Windows.Forms.DataGridView listBireyselMT_2;
        private System.Windows.Forms.DataGridView listTicariMT_1;
        private System.Windows.Forms.DataGridView listTicariMT_2;
        private System.Windows.Forms.GroupBox grpHattaBagla;
        private System.Windows.Forms.Button btnHattaBagla;
        private System.Windows.Forms.TextBox txtMusteriNoGir;
        private System.Windows.Forms.Label lblMusteriNoGir;
    }
}

