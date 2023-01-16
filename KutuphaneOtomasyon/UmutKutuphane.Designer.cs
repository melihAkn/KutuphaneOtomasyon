namespace KutuphaneOtomasyon
{
    partial class UmutKutuphane
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Arama_Kitap_Yazar_Tur = new System.Windows.Forms.TextBox();
            this.Kitap_Yazar_Tur = new System.Windows.Forms.ComboBox();
            this.BelirliKitaplar = new System.Windows.Forms.DataGridView();
            this.KitapOnKapak = new System.Windows.Forms.PictureBox();
            this.KitapOzet = new System.Windows.Forms.RichTextBox();
            this.Kirala = new System.Windows.Forms.Button();
            this.Kitap_Islemleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BelirliKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapOnKapak)).BeginInit();
            this.SuspendLayout();
            // 
            // Arama_Kitap_Yazar_Tur
            // 
            this.Arama_Kitap_Yazar_Tur.Location = new System.Drawing.Point(140, 12);
            this.Arama_Kitap_Yazar_Tur.Name = "Arama_Kitap_Yazar_Tur";
            this.Arama_Kitap_Yazar_Tur.Size = new System.Drawing.Size(578, 23);
            this.Arama_Kitap_Yazar_Tur.TabIndex = 0;
            this.Arama_Kitap_Yazar_Tur.TextChanged += new System.EventHandler(this.Arama_Kitap_Yazar_Tur_TextChanged);
            // 
            // Kitap_Yazar_Tur
            // 
            this.Kitap_Yazar_Tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kitap_Yazar_Tur.FormattingEnabled = true;
            this.Kitap_Yazar_Tur.Items.AddRange(new object[] {
            "kitap türü",
            "yazar adı",
            "kitap adı"});
            this.Kitap_Yazar_Tur.Location = new System.Drawing.Point(3, 12);
            this.Kitap_Yazar_Tur.Name = "Kitap_Yazar_Tur";
            this.Kitap_Yazar_Tur.Size = new System.Drawing.Size(131, 23);
            this.Kitap_Yazar_Tur.TabIndex = 1;
            this.Kitap_Yazar_Tur.SelectedIndexChanged += new System.EventHandler(this.Kitap_Yazar_Tur_SelectedIndexChanged);
            // 
            // BelirliKitaplar
            // 
            this.BelirliKitaplar.AllowUserToAddRows = false;
            this.BelirliKitaplar.AllowUserToDeleteRows = false;
            this.BelirliKitaplar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BelirliKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BelirliKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BelirliKitaplar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BelirliKitaplar.Location = new System.Drawing.Point(3, 41);
            this.BelirliKitaplar.MultiSelect = false;
            this.BelirliKitaplar.Name = "BelirliKitaplar";
            this.BelirliKitaplar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BelirliKitaplar.RowTemplate.Height = 25;
            this.BelirliKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BelirliKitaplar.Size = new System.Drawing.Size(815, 546);
            this.BelirliKitaplar.TabIndex = 2;
            this.BelirliKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BelirliKitaplar_CellClick);
            this.BelirliKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BelirliKitaplar_CellContentClick);
            this.BelirliKitaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BelirliKitaplar_CellDoubleClick);
            // 
            // KitapOnKapak
            // 
            this.KitapOnKapak.Location = new System.Drawing.Point(824, 41);
            this.KitapOnKapak.Name = "KitapOnKapak";
            this.KitapOnKapak.Size = new System.Drawing.Size(148, 202);
            this.KitapOnKapak.TabIndex = 3;
            this.KitapOnKapak.TabStop = false;
            this.KitapOnKapak.Click += new System.EventHandler(this.KitapOnKapak_Click);
            // 
            // KitapOzet
            // 
            this.KitapOzet.Location = new System.Drawing.Point(824, 304);
            this.KitapOzet.Name = "KitapOzet";
            this.KitapOzet.Size = new System.Drawing.Size(148, 168);
            this.KitapOzet.TabIndex = 4;
            this.KitapOzet.Text = "";
            this.KitapOzet.TextChanged += new System.EventHandler(this.KitapOzet_TextChanged);
            // 
            // Kirala
            // 
            this.Kirala.Location = new System.Drawing.Point(824, 478);
            this.Kirala.Name = "Kirala";
            this.Kirala.Size = new System.Drawing.Size(75, 39);
            this.Kirala.TabIndex = 5;
            this.Kirala.Text = "Kirala";
            this.Kirala.UseVisualStyleBackColor = true;
            this.Kirala.Click += new System.EventHandler(this.Kirala_Click);
            // 
            // Kitap_Islemleri
            // 
            this.Kitap_Islemleri.Location = new System.Drawing.Point(905, 478);
            this.Kitap_Islemleri.Name = "Kitap_Islemleri";
            this.Kitap_Islemleri.Size = new System.Drawing.Size(67, 39);
            this.Kitap_Islemleri.TabIndex = 8;
            this.Kitap_Islemleri.Text = "Kitap İşlemleri";
            this.Kitap_Islemleri.UseVisualStyleBackColor = true;
            this.Kitap_Islemleri.Click += new System.EventHandler(this.Kitap_Islemleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kitabın özeti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kitabın Resmi";
            // 
            // UmutKutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kitap_Islemleri);
            this.Controls.Add(this.Kirala);
            this.Controls.Add(this.KitapOzet);
            this.Controls.Add(this.KitapOnKapak);
            this.Controls.Add(this.BelirliKitaplar);
            this.Controls.Add(this.Kitap_Yazar_Tur);
            this.Controls.Add(this.Arama_Kitap_Yazar_Tur);
            this.Name = "UmutKutuphane";
            this.Text = "Umut Kutuphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BelirliKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapOnKapak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Arama_Kitap_Yazar_Tur;
        private ComboBox Kitap_Yazar_Tur;
        private RichTextBox KitapOzet;
        private Button Kirala;
        private Button Kitap_Islemleri;
        private Label label1;
        private Label label2;
        public DataGridView BelirliKitaplar;
        public PictureBox KitapOnKapak;
    }
}