namespace KutuphaneOtomasyon
{
    partial class Kiralama
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
            this.KitapKirala = new System.Windows.Forms.Button();
            this.KitabinBarkodNo = new System.Windows.Forms.TextBox();
            this.KiralayanTc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KitapBarkodNoVeBaziBilgiler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KiralayanAd = new System.Windows.Forms.TextBox();
            this.KiralayanSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KiralayanTel = new System.Windows.Forms.TextBox();
            this.KiralananTarih = new System.Windows.Forms.DateTimePicker();
            this.TeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.KiralamaListeleme = new System.Windows.Forms.DataGridView();
            this.OduncKayitSilme = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.OdenecekUcret = new System.Windows.Forms.Label();
            this.AranacakTur = new System.Windows.Forms.ComboBox();
            this.AramaOduncBilgileri = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KitapBarkodNoVeBaziBilgiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiralamaListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapKirala
            // 
            this.KitapKirala.Location = new System.Drawing.Point(222, 235);
            this.KitapKirala.Name = "KitapKirala";
            this.KitapKirala.Size = new System.Drawing.Size(75, 23);
            this.KitapKirala.TabIndex = 1;
            this.KitapKirala.Text = "Odunc Ver";
            this.KitapKirala.UseVisualStyleBackColor = true;
            this.KitapKirala.Click += new System.EventHandler(this.KitapKirala_Click);
            // 
            // KitabinBarkodNo
            // 
            this.KitabinBarkodNo.Location = new System.Drawing.Point(222, 12);
            this.KitabinBarkodNo.Name = "KitabinBarkodNo";
            this.KitabinBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.KitabinBarkodNo.TabIndex = 3;
            this.KitabinBarkodNo.TextChanged += new System.EventHandler(this.KitabinBarkodNo_TextChanged);
            // 
            // KiralayanTc
            // 
            this.KiralayanTc.Location = new System.Drawing.Point(222, 194);
            this.KiralayanTc.Name = "KiralayanTc";
            this.KiralayanTc.Size = new System.Drawing.Size(100, 23);
            this.KiralayanTc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "kiralama bitiş tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitabın barkod numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "kiralanan tarih";
            // 
            // KitapBarkodNoVeBaziBilgiler
            // 
            this.KitapBarkodNoVeBaziBilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapBarkodNoVeBaziBilgiler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.KitapBarkodNoVeBaziBilgiler.Location = new System.Drawing.Point(409, 27);
            this.KitapBarkodNoVeBaziBilgiler.Name = "KitapBarkodNoVeBaziBilgiler";
            this.KitapBarkodNoVeBaziBilgiler.RowTemplate.Height = 25;
            this.KitapBarkodNoVeBaziBilgiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KitapBarkodNoVeBaziBilgiler.Size = new System.Drawing.Size(279, 150);
            this.KitapBarkodNoVeBaziBilgiler.TabIndex = 14;
            this.KitapBarkodNoVeBaziBilgiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KitapBarkodNoVeBaziBilgiler_CellContentClick);
            this.KitapBarkodNoVeBaziBilgiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KitapBarkodNoVeBaziBilgiler_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "kiralayan soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "kiralayan ad";
            // 
            // KiralayanAd
            // 
            this.KiralayanAd.Location = new System.Drawing.Point(222, 104);
            this.KiralayanAd.Name = "KiralayanAd";
            this.KiralayanAd.Size = new System.Drawing.Size(100, 23);
            this.KiralayanAd.TabIndex = 17;
            // 
            // KiralayanSoyad
            // 
            this.KiralayanSoyad.Location = new System.Drawing.Point(222, 136);
            this.KiralayanSoyad.Name = "KiralayanSoyad";
            this.KiralayanSoyad.Size = new System.Drawing.Size(100, 23);
            this.KiralayanSoyad.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "kiralayan telefon numarası";
            // 
            // KiralayanTel
            // 
            this.KiralayanTel.Location = new System.Drawing.Point(222, 165);
            this.KiralayanTel.Name = "KiralayanTel";
            this.KiralayanTel.Size = new System.Drawing.Size(100, 23);
            this.KiralayanTel.TabIndex = 20;
            // 
            // KiralananTarih
            // 
            this.KiralananTarih.CustomFormat = "";
            this.KiralananTarih.Enabled = false;
            this.KiralananTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.KiralananTarih.Location = new System.Drawing.Point(222, 41);
            this.KiralananTarih.Name = "KiralananTarih";
            this.KiralananTarih.Size = new System.Drawing.Size(100, 23);
            this.KiralananTarih.TabIndex = 21;
            this.KiralananTarih.TabStop = false;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.CustomFormat = "";
            this.TeslimTarihi.Enabled = false;
            this.TeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TeslimTarihi.Location = new System.Drawing.Point(222, 75);
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.Size = new System.Drawing.Size(100, 23);
            this.TeslimTarihi.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kiralayan Tc";
            // 
            // KiralamaListeleme
            // 
            this.KiralamaListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KiralamaListeleme.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.KiralamaListeleme.Location = new System.Drawing.Point(12, 301);
            this.KiralamaListeleme.Name = "KiralamaListeleme";
            this.KiralamaListeleme.RowTemplate.Height = 25;
            this.KiralamaListeleme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KiralamaListeleme.Size = new System.Drawing.Size(676, 224);
            this.KiralamaListeleme.TabIndex = 25;
            this.KiralamaListeleme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KiralamaListeleme_CellClick);
            this.KiralamaListeleme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KiralamaListeleme_CellContentClick);
            this.KiralamaListeleme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KiralamaListeleme_CellDoubleClick);
            // 
            // OduncKayitSilme
            // 
            this.OduncKayitSilme.Location = new System.Drawing.Point(303, 235);
            this.OduncKayitSilme.Name = "OduncKayitSilme";
            this.OduncKayitSilme.Size = new System.Drawing.Size(75, 23);
            this.OduncKayitSilme.TabIndex = 26;
            this.OduncKayitSilme.Text = "Teslim Al";
            this.OduncKayitSilme.UseVisualStyleBackColor = true;
            this.OduncKayitSilme.Click += new System.EventHandler(this.OduncKayitSilme_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Odemeniz gereken ucret";
            // 
            // OdenecekUcret
            // 
            this.OdenecekUcret.AutoSize = true;
            this.OdenecekUcret.Location = new System.Drawing.Point(526, 235);
            this.OdenecekUcret.Name = "OdenecekUcret";
            this.OdenecekUcret.Size = new System.Drawing.Size(0, 15);
            this.OdenecekUcret.TabIndex = 28;
            // 
            // AranacakTur
            // 
            this.AranacakTur.FormattingEnabled = true;
            this.AranacakTur.Items.AddRange(new object[] {
            "Kiralayan Ad",
            "Kiralayan Tc",
            "Kiralayan Tel"});
            this.AranacakTur.Location = new System.Drawing.Point(14, 272);
            this.AranacakTur.Name = "AranacakTur";
            this.AranacakTur.Size = new System.Drawing.Size(121, 23);
            this.AranacakTur.TabIndex = 29;
            // 
            // AramaOduncBilgileri
            // 
            this.AramaOduncBilgileri.Location = new System.Drawing.Point(141, 272);
            this.AramaOduncBilgileri.Name = "AramaOduncBilgileri";
            this.AramaOduncBilgileri.Size = new System.Drawing.Size(262, 23);
            this.AramaOduncBilgileri.TabIndex = 30;
            this.AramaOduncBilgileri.TextChanged += new System.EventHandler(this.AramaOduncBilgileri_TextChanged);
            // 
            // Kiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 537);
            this.Controls.Add(this.AramaOduncBilgileri);
            this.Controls.Add(this.AranacakTur);
            this.Controls.Add(this.OdenecekUcret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OduncKayitSilme);
            this.Controls.Add(this.KiralamaListeleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeslimTarihi);
            this.Controls.Add(this.KiralananTarih);
            this.Controls.Add(this.KiralayanTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KiralayanSoyad);
            this.Controls.Add(this.KiralayanAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KitapBarkodNoVeBaziBilgiler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KiralayanTc);
            this.Controls.Add(this.KitabinBarkodNo);
            this.Controls.Add(this.KitapKirala);
            this.Name = "Kiralama";
            this.Text = "Kiralama";
            this.Load += new System.EventHandler(this.Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapBarkodNoVeBaziBilgiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiralamaListeleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button KitapKirala;
        private TextBox KitabinBarkodNo;
        private TextBox KiralayanTc;
        private Label label2;
        private Label label4;
        private Label label5;
        private DataGridView KitapBarkodNoVeBaziBilgiler;
        private Label label3;
        private Label label6;
        private TextBox KiralayanAd;
        private TextBox KiralayanSoyad;
        private Label label7;
        private TextBox KiralayanTel;
        private DateTimePicker KiralananTarih;
        private DateTimePicker TeslimTarihi;
        private Label label1;
        private DataGridView KiralamaListeleme;
        private Button OduncKayitSilme;
        private Label label8;
        private Label OdenecekUcret;
        private ComboBox AranacakTur;
        private TextBox AramaOduncBilgileri;
    }
}