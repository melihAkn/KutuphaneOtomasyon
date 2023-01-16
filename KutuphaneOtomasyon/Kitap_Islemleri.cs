using KutuphaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Kitap_Islemleri : Form
    {
        string StrGuncelle = "Güncelle";
        string StrKaydet = "Ekle";
        private int guncellenecekId = 0;
        public Kitap_Islemleri()
        {
            InitializeComponent();
            TumKitaplariListele.DataSource = new KutuphaneDatabase().TümKitapBilgileriniGetir();
            ButtonSil.Visible = false;

         
        }
        
        private void GirilenDeğerleriTemizle()
        {
            //butonlarla kayıt silme guncelleme işlemleri yapıldıktan sonra girilen verilerin temizlenmesi
            KitabınAdi.Clear();
            YazarinAdi.Clear();
            YayinEvi.Clear();
            KapakTuru.Clear();
            Kategori.Clear();
            KitabınOzeti.Clear();
            KitabinDili.Clear();
            KitabınBoyutu.Clear();
            SayfaSayisi.Clear();
            Stok.Clear();
            BarkodNo.Clear();
          





        }
        public void TabloyuGuncelle()
        {
            //veritabanına kayıt eklendikten sonra tablonun verilerinin guncellenmesi
            try
            {
                TumKitaplariListele.DataSource = new KutuphaneDatabase().TümKitapBilgileriniGetir();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Ekle_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //veritabanına eklenecek kayıdın verilerinin textbox nesnelerinden alınıp tabloya eklenmesi
                TumKitapBilgileri kitapIslemleri = new TumKitapBilgileri();
                kitapIslemleri.Adi = KitabınAdi.Text;
                kitapIslemleri.YazarAdi = YazarinAdi.Text;
                kitapIslemleri.YayinEvi = YayinEvi.Text;
                kitapIslemleri.KapakTuru = KapakTuru.Text;
                kitapIslemleri.Kategori = Kategori.Text;
                kitapIslemleri.Ozet = KitabınOzeti.Text;
                kitapIslemleri.Dili = KitabinDili.Text;
                kitapIslemleri.Boyut = KitabınBoyutu.Text;
                kitapIslemleri.BarkodNo = BarkodNo.Text;
                kitapIslemleri.SayfaSayisi = Convert.ToInt32(SayfaSayisi.Text);
                kitapIslemleri.Stok = Convert.ToInt32(Stok.Text);
                kitapIslemleri.OnKapakResmiYolu = OnKapakDosyaYolu;
                kitapIslemleri.ArkaKapakResmiYolu = ArkaKapakDosyaYolu;
                
                if (Button_Ekle_Guncelle.Text.Equals(StrKaydet))
                {
                    new KutuphaneDatabase().KitapEkleme(kitapIslemleri);


                    GirilenDeğerleriTemizle();
                    
                    
                }

                else if (Button_Ekle_Guncelle.Text.Equals(StrGuncelle))
                {
                    kitapIslemleri.Id = guncellenecekId;             
                    new KutuphaneDatabase().KitapGuncelleme(kitapIslemleri);
                    GirilenDeğerleriTemizle();
                    ButtonSil.Visible = false;
                    Button_Ekle_Guncelle.Text = StrKaydet;
                    
                }
                TabloyuGuncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonSil_Click(object sender, EventArgs e)
        {
            
            TumKitapBilgileri kitapIslemleri = new TumKitapBilgileri();
            kitapIslemleri.Id = guncellenecekId;
            new KutuphaneDatabase().KitapSilme(kitapIslemleri);
            GirilenDeğerleriTemizle();
            TabloyuGuncelle();
            ButtonSil.Visible = false;
            Button_Ekle_Guncelle.Text = StrKaydet;



        }

        private void TumKitaplariListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridwiev nesnesinde hücreye çift tıklanınca tablodaki değerlerin textboxlara eklenmesi ve guncelleme ve silme işlemlerinin yapılması
            ButtonSil.Visible = true;
            Button_Ekle_Guncelle.Text = StrGuncelle;
            guncellenecekId = (int)TumKitaplariListele[0, e.RowIndex].Value;

            KitabınAdi.Text = TumKitaplariListele[1, e.RowIndex].Value.ToString();
            YazarinAdi.Text = TumKitaplariListele[2, e.RowIndex].Value.ToString();
            YayinEvi.Text =TumKitaplariListele[3,e.RowIndex].Value.ToString();
            KapakTuru.Text = TumKitaplariListele[4,e.RowIndex].Value.ToString();
            Kategori.Text =TumKitaplariListele[5,e.RowIndex].Value.ToString();

            BarkodNo.Text = TumKitaplariListele[9, e.RowIndex].Value.ToString();

            KitabınOzeti.Text =TumKitaplariListele[6,e.RowIndex].Value.ToString();
            KitabinDili.Text =TumKitaplariListele[7,e.RowIndex].Value.ToString();
            KitabınBoyutu.Text =TumKitaplariListele[8,e.RowIndex].Value.ToString(); 
            SayfaSayisi.Text =TumKitaplariListele[12,e.RowIndex].Value.ToString();
            Stok.Text =TumKitaplariListele[13,e.RowIndex].Value.ToString();
            
            KitabinArkaResmi.Load((string)TumKitaplariListele[10, e.RowIndex].Value);
            ArkaKapakDosyaYolu= (string)TumKitaplariListele[10, e.RowIndex].Value;
            KitabinArkaResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            OnKapakDosyaYolu = (string)TumKitaplariListele[10, e.RowIndex].Value;

            KitabinOnResmi.Load((string)TumKitaplariListele[11, e.RowIndex].Value);
            KitabinOnResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Kitap_Islemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            //kitap işlemleri formu kapandıgında ana formdaki datagridwievin verilerinin guncellenmesi
            UmutKutuphane anaform = (UmutKutuphane)Application.OpenForms["UmutKutuphane"];
            anaform.BelirliKitaplar.DataSource = new KutuphaneDatabase().BelirliKitapBilgileriniGetir();
        }

    

        private void Kitap_Islemleri_Load(object sender, EventArgs e)
        {

        }
        public string OnKapakDosyaYolu="" ;
        private void OnKapakDeğistir_Click(object sender, EventArgs e)
        {
            //kitabın resminin dosya yoluyla secilmesi
            OpenFileDialog OnKapak = new OpenFileDialog();
            OnKapak.InitialDirectory = "C:\\Users\\melih\\OneDrive\\Masaüstü\\Melih_Akinci_221103063\\Melih_Akinci_221103063\\KitapOnArkaKapakResimleri";
            OnKapak.Filter = "jpg files (*.jpg)|*.txt|All files (*.*)|*.*";
            OnKapak.FilterIndex = 2;
            OnKapak.RestoreDirectory = true;

            if (OnKapak.ShowDialog() == DialogResult.OK)
            {
               
                 OnKapakDosyaYolu = OnKapak.FileName;
            }
        
            KitabinOnResmi.Load(OnKapak.FileName);
            KitabinOnResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public string ArkaKapakDosyaYolu="";
        private void ArkaKapakDegistir_Click(object sender, EventArgs e)
        {
            //kitabın resminin dosya yoluyla secilmesi
            OpenFileDialog ArkaKapak = new OpenFileDialog();
            ArkaKapak.InitialDirectory = "C:\\Users\\melih\\OneDrive\\Masaüstü\\Melih_Akinci_221103063\\Melih_Akinci_221103063\\KitapOnArkaKapakResimleri";
            ArkaKapak.Filter = "jpg files (*.jpg)|*.txt|All files (*.*)|*.*";
            ArkaKapak.FilterIndex = 2;
            ArkaKapak.RestoreDirectory = true;

            if (ArkaKapak.ShowDialog() == DialogResult.OK)
            {
                //Kullanıcı tarafından seçilen dosya yolu alınır
                ArkaKapakDosyaYolu = ArkaKapak.FileName;
               
            }
            KitabinArkaResmi.Load(ArkaKapak.FileName);
            KitabinArkaResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void TumKitaplariListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
