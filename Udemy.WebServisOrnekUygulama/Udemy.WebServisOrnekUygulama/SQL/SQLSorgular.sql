create database WebServisKullanimi

go

use WebServisKullanimi

go

create table Urun
(
ID int identity(1,1) primary key,
UrunKimlik nvarchar(10),
Tanim nvarchar(100),
Aciklama nvarchar(255),
StokAdet int
)