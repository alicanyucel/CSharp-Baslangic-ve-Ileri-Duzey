create database Udemyyy

use Udemyyy
go
create table Musteri
(
ID int identity(1,1) primary key,
Ad nvarchar(40),
Soyad nvarchar(40),
EmailAdres nvarchar(100),
KuponKOD nvarchar(10),
KuponDurum bit,
KuponAktifTarih datetime
)

go 

create proc KayitEKLE
(
@Ad nvarchar(40),
@Soyad nvarchar(40),
@EmailAdres nvarchar(100)
)
as
begin
insert into Musteri (Ad,Soyad,EmailAdres) values (@Ad,@Soyad,@EmailAdres)
end

go 

create proc KuponKODGuncelle
(
@KuponKOD nvarchar(10)
)
as
begin
update Musteri
set 
KuponDurum = 1,
KuponAktifTarih = getdate()
where
KuponKOD = @KuponKOD
end

go 

create proc KuponKODKontrol
(
@KuponKOD nvarchar(10)
)
as
begin
select coalesce(count(*),0) from Musteri where KuponKOD = @KuponKOD 
end

go 

create proc KuponKODAta
(
@ID int,
@KuponKOD nvarchar(10)
)
as
begin
update Musteri
set 
KuponKOD = @KuponKOD
where 
ID = @ID
end

