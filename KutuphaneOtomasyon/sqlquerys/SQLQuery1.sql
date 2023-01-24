create database UmutKutuphane
use UmutKutuphane

create table Kitaplar(
Id int primary key identity(1,1) not null,
Adi nvarchar(150) not null,
YazarAdi nvarchar(150) not null,
YayinEvi nvarchar(50) not null,
KapakTuru nvarchar(15) not null,
Kategori nvarchar(50) not null,
Ozet nvarchar (150) not null,
Dili nvarchar(50) not null,
Boyut nvarchar(15) not null,
SayfaSayisi int not null,
stok int not null,
BarkodNo nvarchar(50) not null,
OnKapakResmiYolu nvarchar(max),
ArkaKapakResmiYolu nvarchar(max),
)
ALTER TABLE [dbo].[Kitaplar]
    ADD CONSTRAINT [CK_Kitaplar_stok] CHECK ([stok]>=(0));

create table Odunc(
id int primary key identity(1,1),
KiralayanAd nvarchar(50) not null,
KiralayanSoyad nvarchar(50) not null,
KiralayanTel nvarchar(50) not null,
KiralayanTc nvarchar(50) not null,
BarkodNo nvarchar(50) not null,
KiralamaTarihi date not null,
TeslimTarihi date not null,

)

girilen barkod numarasına gore tabloda veri olup olmadıgının kontrolu
create proc Sp_KayitVarmi (@BarkodNo int ,@sonuc int output)
as
begin
declare @varmi int
set @varmi =(select count(BarkodNo) from Kitaplar where BarkodNo=@BarkodNo)
if(@varmi = 1 )
begin
select * from Kitaplar where BarkodNo=@BarkodNo
set @sonuc =1

end
else
begin
set @sonuc =0

end
end

--girilen barkod numarasına gore odunc tablosunda veri olup olmadıgının kontrolu
create proc Sp_BarkodNoVarMi (@BarkodNo int ,@sonuc int output)
as
begin
declare @varmi int
set @varmi =(select count(BarkodNo) from Odunc where BarkodNo=@BarkodNo)
if(@varmi = 1 )
begin
select * from Kitaplar where BarkodNo=@BarkodNo
set @sonuc =1

end
else
begin
set @sonuc =0
end
end
