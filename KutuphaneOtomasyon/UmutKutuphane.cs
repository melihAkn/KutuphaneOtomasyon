using KutuphaneOtomasyon.DAL;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class UmutKutuphane : Form
    {
        public UmutKutuphane()
        {
            
            InitializeComponent();
        }
        public int a = 0;

        public void Form1_Load(object sender, EventArgs e)
        {
            Kitap_Yazar_Tur.SelectedIndex = 0;
            BelirliKitaplar.DataSource = new KutuphaneDatabase().BelirliKitapBilgileriniGetir();
            BelirliKitaplar.RowHeadersVisible= false;
            if(BelirliKitaplar.FirstDisplayedCell == null)
            {

            }
            else
            {
                KitapOzet.Text = BelirliKitaplar[5, a].Value.ToString();

                TumKitapBilgileri ResimGetir = new TumKitapBilgileri();

                ResimGetir.Id = (int)BelirliKitaplar[0, a].Value;

                new KutuphaneDatabase().OnKapakResmiGetirme(ResimGetir);
            }


        }

    
        private void Arama_Kitap_Yazar_Tur_TextChanged(object sender, EventArgs e)
        {
            BelirliKitaplar.DataSource = new KutuphaneDatabase().AramayaGoreKitapGetir(Arama_Kitap_Yazar_Tur.Text, Kitap_Yazar_Tur.SelectedIndex);


            
        }

        private void Kitap_Yazar_Tur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

        private void KitapOzet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kirala_Click(object sender, EventArgs e)
        {
            //butona týklayýnca odunc verme formunun açýlmasý
            Kiralama Kiralama = new();
            Kiralama.ShowDialog();

        }

        private void Kitap_Islemleri_Click(object sender, EventArgs e)
        {

            //butona týklayýnca kitap iþlemleri formunun açýlmasý
            Kitap_Islemleri KitapIslemleri = new();
            KitapIslemleri.ShowDialog();

        }
        private void BelirliKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BelirliKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string deger = "";

        private void BelirliKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            KitapOzet.Text = BelirliKitaplar[5, e.RowIndex].Value.ToString();       
            
            

            TumKitapBilgileri ResimGetir=new TumKitapBilgileri();
             
            ResimGetir.Id = (int)BelirliKitaplar[0, e.RowIndex].Value;
            
            new KutuphaneDatabase().OnKapakResmiGetirme(ResimGetir);
           
            
        }

        private void KitapOnKapak_Click(object sender, EventArgs e)
        {

        }
    }
}