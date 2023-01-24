using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
namespace KutuphaneOtomasyon.DAL
{
    
    internal class KutuphaneDatabase
    {
        //var result ifadesine her zaman gerek yok bitince kaldırılacak
        public string ConnectionString = @"
        Data Source = (localdb)\MSSQLLocalDB;Initial Catalog =UmutKutuphane ; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            ";
        
        public int deger;

        public List<BelirliKitapBilgileri> BelirliKitapBilgileriniGetir()
        {       
            //veritabanından Id,Kitabın adı,Yazarının adı,YayınEvi,Kategori,Dili,Ozeti ve sayfa sayısının çekilmesi
            using SqlConnection db = new(ConnectionString);
            var result =db.Query<BelirliKitapBilgileri>("select * from Kitaplar");
            return result.ToList();

        }
        public List<TumKitapBilgileri> TümKitapBilgileriniGetir()
        {
            //veritabanından kitaplar tablosundaki tüm bilgilerin cekilmesi
            using SqlConnection db = new(ConnectionString);
            var result = db.Query<TumKitapBilgileri>("select * from Kitaplar");
            return result.ToList();

        }

        public void OnKapakResmiGetirme(TumKitapBilgileri ResimGetir)
        {
            //ana fromda secilen hücrenin id bilgisine gore veritabanındaki resimyolunun alınması
            using SqlConnection db = new(ConnectionString);
            var result = db.QueryFirstOrDefault<string>("select OnKapakResmiYolu from Kitaplar where Id=@Id", ResimGetir);

            //alınan resimyolunun formdaki picturebox nesnesine yuklenmesi ve nesnenin boyutlarına göre şekillendirilmesi
            UmutKutuphane anaform = (UmutKutuphane)Application.OpenForms["UmutKutuphane"];
            anaform.KitapOnKapak.Load(result);
            anaform.KitapOnKapak.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }
        public List<BelirliKitapBilgileri> AramayaGoreKitapGetir(string aranacakKelime, int tur)
        {
            //formda secilen aranacakture gore yazılan her karakterde veritabanından kayıt getirilmesi
            string aranacaktur="";
            if (tur == 0)
            {
                aranacaktur = "Kategori";
                
            }
            else if (tur == 1)
            {
                
                aranacaktur = "YazarAdi";
            }
            else if (tur == 2)
            {
                aranacaktur = "Adi";
            }


            using SqlConnection db = new(ConnectionString);
            var result = db.Query<BelirliKitapBilgileri>(@"select * from Kitaplar where +"+aranacaktur.ToString()+" like '%" + aranacakKelime + "%'" ) ;
            return result.ToList();
        }

        public void KitapEkleme(TumKitapBilgileri kitapIslemleri)
        {
            //eğer barkodno 9 karakterliyse kitaplar tablosuna kayıt eklenmesi 
            using SqlConnection db = new(ConnectionString);
            try
            {

            
            var result = db.Execute(@"if(len(@BarkodNo)=9)
                                    begin
                                    insert into kitaplar values(@Adi,@YazarAdi,@YayinEvi,@KapakTuru,@Kategori,@Ozet,@Dili,@Boyut,@SayfaSayisi,@stok,@BarkodNo,@OnKapakResmiYolu,@ArkaKapakResmiYolu)
                                    end
                                    ", kitapIslemleri);
            if (result == 1)
            {
                    
                MessageBox.Show("Kayıt başarı ile eklendi");
                    

                }
                else
            {
                MessageBox.Show("barkod numarası 9 karakter olmak zorunda");
            }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void KitapGuncelleme(TumKitapBilgileri kitapIslemleri)
        {
        using SqlConnection db = new(ConnectionString);
            try
            {
                var result = db.Execute(@"if(len(@BarkodNo)=9)
                                    begin
                                    update kitaplar set Adi=@Adi,YazarAdi=@YazarAdi,YayinEvi=@YayinEvi,KapakTuru=@KapakTuru,Kategori=@Kategori,Ozet=@Ozet,Dili=@Dili,Boyut=@Boyut,BarkodNo=@BarkodNo,SayfaSayisi=@SayfaSayisi,stok=@stok,OnKapakResmiYolu=@OnKapakResmiYolu,ArkaKapakResmiYolu=@ArkaKapakResmiYolu where Id=@Id
                                    end
                                    ", kitapIslemleri);

                if (result == 1)
                {
                    MessageBox.Show("kayıt başarılı şekilde guncellendi");
                }
                else
                {
                    MessageBox.Show("barkod numarası 10 karakter olmak zorunda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void KitapSilme(TumKitapBilgileri kitapIslemleri)
        {

                using SqlConnection db = new(ConnectionString);
            var sql = "exec Sp_BarkodNoVarMi @BarkodNo, @sonuc";
            var values = new { BarkodNo = Sorgu.BarkodNo, sonuc = 0 };
            var results = db.Query(sql, values).ToList();
            results.ForEach(r => Console.WriteLine($"{r.sonuc}"));
            deger = results.Count();

            if(deger> 0 )
            {
                MessageBox.Show("odunc verilmiş kitap silinemez");
            }
            else
            {
                db.Execute(@"delete kitaplar where Id=@Id", kitapIslemleri);
                MessageBox.Show("kayıt başarı ile silindi");
            }
        }
        
        public void BarkodEslesmeVeKayitEkleme(BarkodNoSorgu BarkodSorgu, Odunc OduncIslemleri)
        {
            //girilen barkod numarası veritabanında kayıtlı olup olmadığının kontrolu
            using SqlConnection db = new(ConnectionString);
            var sql = "exec Sp_KayitVarmi @BarkodNo, @sonuc";
            var values = new { BarkodNo = BarkodSorgu.BarkodNo, sonuc = 0 };
            var results = db.Query(sql, values).ToList();
            results.ForEach(r => Console.WriteLine($"{r.sonuc}"));
            deger = results.Count();
           if(deger > 0 )
            {
                
                try
                {
                    //kitap odunc verildiği zaman stok azaltılması
                    var stokAzaltma = db.Execute(@"update Kitaplar set stok-=1 where BarkodNo=@BarkodNo", OduncIslemleri);
                    
                   //kitap odunc verilirken odunc alan kişinin tc sinin 11 karakterden az yada fazla olmamasının,telefon numarasının 10 karakterden az yada fazla olmamasının kontrol edilmesi
                   //aynı tc numarasına sahip 4 ten fazla kayıt eklenmesinin engellenmesi
                    var result = db.Execute(@"
                                              
                                              IF ((SELECT COUNT(*) from odunc WHERE KiralayanTc = @KiralayanTc) < 4 and len(@KiralayanTc)=11 and len(@KiralayanTel)=10  )
                                              BEGIN
                                                 insert into Odunc values(@KiralayanAd,@KiralayanSoyad,@KiralayanTel,@KiralayanTc,@BarkodNo,@KiralamaTarihi,@TeslimTarihi)
                                              END
                                            



                                              ", OduncIslemleri);
                
                    if (result==-1)
                    {
                        MessageBox.Show("bir kişi sadece 4 farklı kitap ödünç alabilir veya girdiğiniz bilgiler yanlış");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarı ile eklendi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("veritananında girdiğiniz barkod numarasıyla eşleşen bir kayıt yok");
            }
            
        }
        public List<BarkodNoVeBaziBiligler> BarkodNoVeBaziBilgileriGetir()
        {  
            using SqlConnection db = new(ConnectionString);
            var result = db.Query<BarkodNoVeBaziBiligler>("select * from Kitaplar");
            return result.ToList();
        }

        public List<Odunc> OduncBilgileriniGetir()
        {
            using SqlConnection db = new(ConnectionString);
            var result = db.Query<Odunc>("select * from Odunc");
            return result.ToList();
        }
        public void OduncGuncelleme(GuncellenecekOduncBilgileri OduncIslemleri)
        {
            using SqlConnection db = new(ConnectionString);
            var result = db.Execute(@"update Odunc set KiralayanAd=@KiralayanAd, KiralayanSoyad=@KiralayanSoyad,KiralayanTel=@KiralayanTel,KiralayanTc=@KiralayanTc where Id=@Id  ",OduncIslemleri);
        }
        public void OduncSilme(GuncellenecekOduncBilgileri sil,Odunc OduncIslemleri)
        {
            using SqlConnection db = new(ConnectionString);
            var result = db.Execute(@"delete from Odunc where Id=@Id",sil);
            var stokAzaltma = db.Execute(@"update Kitaplar set stok+=1 where BarkodNo=@BarkodNo", OduncIslemleri);
        }
        public List<Odunc> AramayaGoreOduncGetir(string aranacakKelime, int tur)
        {

            string aranacaktur = "";
            if (tur == 0)
            {
                aranacaktur = "KiralayanAd";

            }
            else if (tur == 1)
            {

                aranacaktur = "KiralayanTc";
            }
            else if (tur == 2)
            {
                aranacaktur = "KiralayanTel";
            }


            using SqlConnection db = new(ConnectionString);
            var result = db.Query<Odunc>(@"select * from Odunc where +" + aranacaktur.ToString() + " like '%" + aranacakKelime + "%'");
            //var result = db.Query<BelirliKitapBilgileri>(@"select * from Kitaplar where +" + aranacaktur.ToString() + " like '%" + aranacakKelime + "%'");
            return result.ToList();
        }
    }
}

