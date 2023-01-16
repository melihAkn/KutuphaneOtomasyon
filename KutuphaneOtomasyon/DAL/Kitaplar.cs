using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon.DAL
{
    internal class BelirliKitapBilgileri
    {

        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? YazarAdi { get; set; }
        public string? YayinEvi { get; set; }
       
        public string? Kategori { get; set; }
        
        public string? Dili { get; set; }
        public string? Ozet { get; set; }
    
        public int SayfaSayisi { get; set; }
       

       
    }
    internal class TumKitapBilgileri
    {
        public int Id { get; set; }
        
        public string? Adi { get; set; }
        public string? YazarAdi { get; set; }
        public string? YayinEvi { get; set; }
        public string? KapakTuru { get; set; }
        public string? Kategori { get; set; }
        public string? Ozet { get; set; }
        public string? Dili { get; set; }
        public string? Boyut { get; set; }
        public string? BarkodNo { get; set; }
        public string? OnKapakResmiYolu { get; set; }   
        public string? ArkaKapakResmiYolu { get; set; } 

        public int SayfaSayisi { get; set; }
        public int Stok { get; set; }
    }
    internal class BarkodNoSorgu
    {
        public string? BarkodNo { get; set; }

    }
    internal class BarkodNoVeBaziBiligler
    {
        public string? BarkodNo { get; set; }
        public string? Adi { get; set; }

    }
  
}
