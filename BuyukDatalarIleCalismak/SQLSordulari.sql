create database BuyukDatalarIleCalismak
go
use BuyukDatalarIleCalismak
go
Create table Kisiler
(
ID int identity(1,1) primary key,
Isim nvarchar(30),
Soyisim nvarchar(30),
EmailAdres nvarchar(30),
TelefonNumarasi nvarchar(20),
Resim varbinary(max)
)
go
create proc KisiEkle
(
@Isim nvarchar(30),
@Soyisim nvarchar(30),
@EmailAdres nvarchar(30),
@TelefonNumarasi nvarchar(20),
@Resim varbinary(max)
)
as
begin
insert into Kisiler (Isim,Soyisim,EmailAdres,TelefonNumarasi,Resim) values ( @Isim,@Soyisim,@EmailAdres,@TelefonNumarasi,@Resim)
end

select * from Kisiler where ID=@ID