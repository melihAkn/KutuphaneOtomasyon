# KutuphaneOtomasyon
Özellikler

Ana form

uygulama ilk açıldıgında veritabanındaki tum kitapların listelenip sol tarafta seçili kitap kaydının resmi ve özetinin görülmesi
kitabın turu kitabın adı ve yazarın adına gore arama yapılması

Odunc verme formu

Kitabın barkod numarası,oducn verilen tarih,teslim tarihi,odunc verilen kişinin adı soyadı tc'si telefon numarası bilgilerinin istenmesi
Barkod numarası sol taraftaki tablodan kayıda çift tıklandıgında o kitabın barkod numarasının barkod no alanına getirilmesi
Odunc verilen tarih ve teslim tarihi değiştirilemez olarak ayarlı
Formun altındaki tabloda odunc verilimiş kitapların listesi ve kişinin adına tcsine telefon numarasına göre arama
Eğer teslim tarihini geçmişse geçen her gun için 5 tl ceza uygulanması ve odemeniz gereken ücret yazan alanın yanında yazılması

Kitap İslemleri Formu

Eklenecek olan kitapların kitabın adı,yazarının adı,yayın evi,kapak turu,kategori,barkod no,kitabın özeti,kitabın dili,kitabın boyutu,sayfa sayısı,stok,kitabın Ön resmi,kitabın arka resmi bilgilerinin istenmesi
Formun alt tarafında veritabanında kayıtlı olan kitapların getirilmesi
Zorunlu olarak girlmesi gerekenler
Barkod numarası 9 karakter uzunluğunda olmak zorunda,kitabın arka ve ön resimleri yuklenmeli ve hiçbir bilgi boş girilmemeli


Kurulum Notları

1.Oncelikle dapperi buradan  https://begincodingnow.com/dapper-installation-into-your-project-visual-studio/ veya  bu komut ile Install-Package Dapper kurabilirsiniz.

2.Sqlquerys klasorunun içindeki sqlquerry1.sql dosyasını açıp veritabanını oluşturup,gerekli tabloları oluşturmalısınız.

3.Dal klasorunun içindeki KutuphaneDatabase.cs dosyasını açıp connection stringi bu şekilde public string ConnectionString = @"
        Data Source = Bilgisayarınızdaki_Sunucu_Adı;Initial Catalog =oluşturdugunuz_veritabanı_adı ; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            "; 
düzenlemeniz gerekiyor.
veya visual studioda sql server object explorer sekmesinden sql server altında bulunan servera tıklayıp özelliklerinden connection stringi kopyalayıp initial category kısmına oluşturduğunuz veritabanının adını yazabilirsiniz.

