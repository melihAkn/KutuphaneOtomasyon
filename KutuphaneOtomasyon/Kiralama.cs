using KutuphaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KutuphaneOtomasyon
{
    public partial class Kiralama : Form
    {
        public string StrKaydet = "Odunc Ver";
        public string StrGuncelle = "Guncelle";
        public int SecilenId=0;
       
        public Kiralama()
        {
            InitializeComponent();
            //kitaplar odunc verilirken en fazla 15 gun sureyle verilir 
            //teslim tarihi suanki tarihten itibaren 15 gun ilerisine guncellenir
            TeslimTarihi.Value = KiralananTarih.Value.AddDays(15);
            KitapBarkodNoVeBaziBilgiler.DataSource = new KutuphaneDatabase().BarkodNoVeBaziBilgileriGetir();
            KiralamaListeleme.DataSource = new KutuphaneDatabase().OduncBilgileriniGetir();
            OduncKayitSilme.Visible= false;

        }
        public void TabloyuGuncelle()
        {
            try
            {
                KiralamaListeleme.DataSource = new KutuphaneDatabase().OduncBilgileriniGetir();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GirilenDeğerleriTemizle()
        {
            KiralayanAd.Clear();
            KiralayanSoyad.Clear();
            KiralayanTel.Clear();
            KiralayanTc.Clear();
            KitabinBarkodNo.Clear();
        
        }

        private void KitapBarkodNoVeBaziBilgiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kiralama_Load(object sender, EventArgs e)
        {
            UcretHesapla();
            AranacakTur.SelectedIndex = 0;
        }

        private void KitapBarkodNoVeBaziBilgiler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           KitabinBarkodNo.Text=KitapBarkodNoVeBaziBilgiler[0, e.RowIndex].Value.ToString();
        }
    
    

    private void KiralamaListeleme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OduncKayitSilme.Visible = true;
            KitapKirala.Text = StrGuncelle;         
            KitabinBarkodNo.Enabled= false;

            KiralayanAd.Text = KiralamaListeleme[1, e.RowIndex].Value.ToString();
            KiralayanSoyad.Text = KiralamaListeleme[2, e.RowIndex].Value.ToString();
            KiralayanTel.Text = KiralamaListeleme[3, e.RowIndex].Value.ToString();
            KiralayanTc.Text = KiralamaListeleme[4, e.RowIndex].Value.ToString();
            KitabinBarkodNo.Text = KiralamaListeleme[5, e.RowIndex].Value.ToString();
            KiralananTarih.Value = DateTime.Parse(KiralamaListeleme[6, e.RowIndex].Value.ToString());
            TeslimTarihi.Value = DateTime.Parse(KiralamaListeleme[7, e.RowIndex].Value.ToString());
            SecilenId = (int)KiralamaListeleme[0, e.RowIndex].Value;
            
            
        }

        private void KitapKirala_Click(object sender, EventArgs e)
        {
            try
            {
                if (KitapKirala.Text == StrKaydet)
                {

               //veritabanındaki odunc tablosuna eklenecek verilerin textboxlardan alınması
                Odunc ekleme = new Odunc();
                ekleme.KiralayanAd = KiralayanAd.Text;
                ekleme.KiralayanSoyad = KiralayanSoyad.Text;
                ekleme.KiralayanTel = KiralayanTel.Text;
                ekleme.KiralayanTc = KiralayanTc.Text;
                ekleme.BarkodNo = KitabinBarkodNo.Text;
                ekleme.KiralamaTarihi = KiralananTarih.Value;
                ekleme.TeslimTarihi = TeslimTarihi.Value;

                BarkodNoSorgu barkodS = new BarkodNoSorgu();
                barkodS.BarkodNo = KitabinBarkodNo.Text;
                new KutuphaneDatabase().BarkodEslesmeVeKayitEkleme(barkodS, ekleme);
                }
                else if(KitapKirala.Text == StrGuncelle)
                {
                    GuncellenecekOduncBilgileri OduncGuncelleme = new GuncellenecekOduncBilgileri();
                    OduncGuncelleme.Id = SecilenId;
                    OduncGuncelleme.KiralayanAd = KiralayanAd.Text;
                    OduncGuncelleme.KiralayanSoyad = KiralayanSoyad.Text;
                    OduncGuncelleme.KiralayanTc = KiralayanTc.Text;
                    OduncGuncelleme.KiralayanTel = KiralayanTel.Text;

                    new KutuphaneDatabase().OduncGuncelleme(OduncGuncelleme);
                    KiralananTarih.Value = DateTime.Now;
                    TeslimTarihi.Value = KiralananTarih.Value.AddDays(15);






                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            GirilenDeğerleriTemizle();
            TabloyuGuncelle();
            KitabinBarkodNo.Enabled = true;
            KitapKirala.Text = StrKaydet;
            OduncKayitSilme.Visible = false;
        }

        private void OduncKayitSilme_Click(object sender, EventArgs e)
        {
            GuncellenecekOduncBilgileri sil=new GuncellenecekOduncBilgileri();
            Odunc dene = new Odunc();
            sil.Id = SecilenId;

            dene.BarkodNo = KitabinBarkodNo.Text;

            new KutuphaneDatabase().OduncSilme(sil,dene);
           
            GirilenDeğerleriTemizle();
            TabloyuGuncelle();
            OduncKayitSilme.Visible= false;
            KitabinBarkodNo.Enabled = true;
            KiralananTarih.Value = DateTime.Now;
            TeslimTarihi.Value = KiralananTarih.Value.AddDays(15);
        }

        private void KiralamaListeleme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private void UcretHesapla()
        {
            //odunc verilen kitap teslim tarihini gecen her gun için 5 lira ceza uygulanması
            if (KiralamaListeleme.FirstDisplayedCell == null)
            {

            }
            else
            {
                DateTime selectedDate;
                selectedDate = DateTime.Now;
                selectedDate = DateTime.Parse(KiralamaListeleme[7, a].Value.ToString());

                TimeSpan fark = DateTime.Now - selectedDate;

                if (Convert.ToInt32(fark.Days) > 0)
                {
                    int deger = 0;
                    deger = Convert.ToInt32(fark.Days) * 5;
                    OdenecekUcret.Text = Convert.ToString(deger) + "tl";



                }
                else
                {
                    OdenecekUcret.Text = "0 tl";
                }
            }
           

             
            }
        
        public int a = 0;
        private void KiralamaListeleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            UcretHesapla();
  
        }

        private void AramaOduncBilgileri_TextChanged(object sender, EventArgs e)
        {
            //textboxa girilen değere ve dropdownlist içerisinden seçilen değere gore odunc tablosundan veri getirme
            KiralamaListeleme.DataSource = new KutuphaneDatabase().AramayaGoreOduncGetir(AramaOduncBilgileri.Text, AranacakTur.SelectedIndex);
        }

        private void KitabinBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
