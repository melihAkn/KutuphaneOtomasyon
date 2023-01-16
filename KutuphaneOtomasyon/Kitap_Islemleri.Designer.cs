namespace KutuphaneOtomasyon
{
    partial class Kitap_Islemleri
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
            this.TumKitaplariListele = new System.Windows.Forms.DataGridView();
            this.KitabınAdi = new System.Windows.Forms.TextBox();
            this.KitabınOzeti = new System.Windows.Forms.TextBox();
            this.YayinEvi = new System.Windows.Forms.TextBox();
            this.YazarinAdi = new System.Windows.Forms.TextBox();
            this.KitabinDili = new System.Windows.Forms.TextBox();
            this.Button_Ekle_Guncelle = new System.Windows.Forms.Button();
            this.ButtonSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SayfaSayisi = new System.Windows.Forms.TextBox();
            this.KitabınBoyutu = new System.Windows.Forms.TextBox();
            this.Kategori = new System.Windows.Forms.TextBox();
            this.KapakTuru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.TextBox();
            this.KitabinOnResmi = new System.Windows.Forms.PictureBox();
            this.KitabinArkaResmi = new System.Windows.Forms.PictureBox();
            this.OnKapakDeğistir = new System.Windows.Forms.Button();
            this.ArkaKapakDegistir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BarkodNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TumKitaplariListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitabinOnResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitabinArkaResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // TumKitaplariListele
            // 
            this.TumKitaplariListele.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TumKitaplariListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TumKitaplariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TumKitaplariListele.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TumKitaplariListele.Location = new System.Drawing.Point(12, 229);
            this.TumKitaplariListele.Name = "TumKitaplariListele";
            this.TumKitaplariListele.RowTemplate.Height = 25;
            this.TumKitaplariListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TumKitaplariListele.Size = new System.Drawing.Size(1055, 385);
            this.TumKitaplariListele.TabIndex = 0;
            this.TumKitaplariListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TumKitaplariListele_CellContentClick);
            this.TumKitaplariListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TumKitaplariListele_CellDoubleClick);
            // 
            // KitabınAdi
            // 
            this.KitabınAdi.Location = new System.Drawing.Point(83, 12);
            this.KitabınAdi.Name = "KitabınAdi";
            this.KitabınAdi.Size = new System.Drawing.Size(234, 23);
            this.KitabınAdi.TabIndex = 1;
            // 
            // KitabınOzeti
            // 
            this.KitabınOzeti.Location = new System.Drawing.Point(580, 7);
            this.KitabınOzeti.Multiline = true;
            this.KitabınOzeti.Name = "KitabınOzeti";
            this.KitabınOzeti.Size = new System.Drawing.Size(187, 86);
            this.KitabınOzeti.TabIndex = 2;
            // 
            // YayinEvi
            // 
            this.YayinEvi.Location = new System.Drawing.Point(83, 70);
            this.YayinEvi.Name = "YayinEvi";
            this.YayinEvi.Size = new System.Drawing.Size(234, 23);
            this.YayinEvi.TabIndex = 3;
            // 
            // YazarinAdi
            // 
            this.YazarinAdi.Location = new System.Drawing.Point(83, 41);
            this.YazarinAdi.Name = "YazarinAdi";
            this.YazarinAdi.Size = new System.Drawing.Size(234, 23);
            this.YazarinAdi.TabIndex = 4;
            // 
            // KitabinDili
            // 
            this.KitabinDili.Location = new System.Drawing.Point(580, 104);
            this.KitabinDili.Name = "KitabinDili";
            this.KitabinDili.Size = new System.Drawing.Size(100, 23);
            this.KitabinDili.TabIndex = 5;
            // 
            // Button_Ekle_Guncelle
            // 
            this.Button_Ekle_Guncelle.Location = new System.Drawing.Point(12, 187);
            this.Button_Ekle_Guncelle.Name = "Button_Ekle_Guncelle";
            this.Button_Ekle_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Button_Ekle_Guncelle.TabIndex = 6;
            this.Button_Ekle_Guncelle.Text = "Ekle";
            this.Button_Ekle_Guncelle.UseVisualStyleBackColor = true;
            this.Button_Ekle_Guncelle.Click += new System.EventHandler(this.Button_Ekle_Guncelle_Click);
            // 
            // ButtonSil
            // 
            this.ButtonSil.Location = new System.Drawing.Point(93, 187);
            this.ButtonSil.Name = "ButtonSil";
            this.ButtonSil.Size = new System.Drawing.Size(75, 23);
            this.ButtonSil.TabIndex = 7;
            this.ButtonSil.Text = "Sil";
            this.ButtonSil.UseVisualStyleBackColor = true;
            this.ButtonSil.Click += new System.EventHandler(this.ButtonSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kitabın Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yazarın Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "yayın Evi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kapak turu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kategori";
            // 
            // SayfaSayisi
            // 
            this.SayfaSayisi.Location = new System.Drawing.Point(580, 162);
            this.SayfaSayisi.Name = "SayfaSayisi";
            this.SayfaSayisi.Size = new System.Drawing.Size(100, 23);
            this.SayfaSayisi.TabIndex = 13;
            // 
            // KitabınBoyutu
            // 
            this.KitabınBoyutu.Location = new System.Drawing.Point(580, 133);
            this.KitabınBoyutu.Name = "KitabınBoyutu";
            this.KitabınBoyutu.Size = new System.Drawing.Size(100, 23);
            this.KitabınBoyutu.TabIndex = 14;
            // 
            // Kategori
            // 
            this.Kategori.Location = new System.Drawing.Point(83, 128);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(234, 23);
            this.Kategori.TabIndex = 15;
            // 
            // KapakTuru
            // 
            this.KapakTuru.Location = new System.Drawing.Point(83, 99);
            this.KapakTuru.Name = "KapakTuru";
            this.KapakTuru.Size = new System.Drawing.Size(234, 23);
            this.KapakTuru.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sayfa Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kitabın boyutu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Kitabın Dili";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kitabın ozeti";
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(580, 188);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(100, 23);
            this.Stok.TabIndex = 23;
            // 
            // KitabinOnResmi
            // 
            this.KitabinOnResmi.Location = new System.Drawing.Point(789, 7);
            this.KitabinOnResmi.Name = "KitabinOnResmi";
            this.KitabinOnResmi.Size = new System.Drawing.Size(143, 184);
            this.KitabinOnResmi.TabIndex = 24;
            this.KitabinOnResmi.TabStop = false;
            // 
            // KitabinArkaResmi
            // 
            this.KitabinArkaResmi.Location = new System.Drawing.Point(953, 7);
            this.KitabinArkaResmi.Name = "KitabinArkaResmi";
            this.KitabinArkaResmi.Size = new System.Drawing.Size(143, 184);
            this.KitabinArkaResmi.TabIndex = 25;
            this.KitabinArkaResmi.TabStop = false;
            // 
            // OnKapakDeğistir
            // 
            this.OnKapakDeğistir.Location = new System.Drawing.Point(789, 197);
            this.OnKapakDeğistir.Name = "OnKapakDeğistir";
            this.OnKapakDeğistir.Size = new System.Drawing.Size(143, 23);
            this.OnKapakDeğistir.TabIndex = 26;
            this.OnKapakDeğistir.Text = "Ön kapak değiştir";
            this.OnKapakDeğistir.UseVisualStyleBackColor = true;
            this.OnKapakDeğistir.Click += new System.EventHandler(this.OnKapakDeğistir_Click);
            // 
            // ArkaKapakDegistir
            // 
            this.ArkaKapakDegistir.Location = new System.Drawing.Point(953, 197);
            this.ArkaKapakDegistir.Name = "ArkaKapakDegistir";
            this.ArkaKapakDegistir.Size = new System.Drawing.Size(143, 23);
            this.ArkaKapakDegistir.TabIndex = 27;
            this.ArkaKapakDegistir.Text = "Arka kapak değiştir";
            this.ArkaKapakDegistir.UseVisualStyleBackColor = true;
            this.ArkaKapakDegistir.Click += new System.EventHandler(this.ArkaKapakDegistir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Barkod No";
            // 
            // BarkodNo
            // 
            this.BarkodNo.Location = new System.Drawing.Point(83, 157);
            this.BarkodNo.Name = "BarkodNo";
            this.BarkodNo.Size = new System.Drawing.Size(234, 23);
            this.BarkodNo.TabIndex = 29;
            // 
            // Kitap_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1108, 638);
            this.Controls.Add(this.BarkodNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ArkaKapakDegistir);
            this.Controls.Add(this.OnKapakDeğistir);
            this.Controls.Add(this.KitabinArkaResmi);
            this.Controls.Add(this.KitabinOnResmi);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KapakTuru);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.KitabınBoyutu);
            this.Controls.Add(this.SayfaSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSil);
            this.Controls.Add(this.Button_Ekle_Guncelle);
            this.Controls.Add(this.KitabinDili);
            this.Controls.Add(this.YazarinAdi);
            this.Controls.Add(this.YayinEvi);
            this.Controls.Add(this.KitabınOzeti);
            this.Controls.Add(this.KitabınAdi);
            this.Controls.Add(this.TumKitaplariListele);
            this.Name = "Kitap_Islemleri";
            this.Text = "Kitap_Islemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kitap_Islemleri_FormClosed);
            this.Load += new System.EventHandler(this.Kitap_Islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TumKitaplariListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitabinOnResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitabinArkaResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TumKitaplariListele;
        private TextBox KitabınAdi;
        private TextBox KitabınOzeti;
        private TextBox YayinEvi;
        private TextBox YazarinAdi;
        private TextBox KitabinDili;
        private Button Button_Ekle_Guncelle;
        private Button ButtonSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox SayfaSayisi;
        private TextBox KitabınBoyutu;
        private TextBox Kategori;
        private TextBox KapakTuru;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox Stok;
        private PictureBox KitabinOnResmi;
        private PictureBox KitabinArkaResmi;
        private Button OnKapakDeğistir;
        private Button ArkaKapakDegistir;
        private Label label7;
        private TextBox BarkodNo;
    }
}