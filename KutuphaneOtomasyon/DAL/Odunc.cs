using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
    internal class Odunc
    {
        public int Id { get; set; }
        public string? KiralayanAd { get; set; }
        public string? KiralayanSoyad { get; set; }
        public string? KiralayanTel { get; set; }
        public string? KiralayanTc { get; set; }
        public string? BarkodNo { get; set; }
        public DateTime KiralamaTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }

    }
    internal class GuncellenecekOduncBilgileri
    {
        public int Id { get; set; }
        public string? KiralayanAd { get; set; }
        public string? KiralayanSoyad { get; set; }
        public string? KiralayanTel { get; set; }
        public string? KiralayanTc { get; set; }

    }
}
