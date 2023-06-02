create database UdemyNlogDatabase
GO
use UdemyNlogDatabase
GO

create table LOGME
(
ID int identity(1,1) primary key,
Levels nvarchar(20),
Mesaj nvarchar(max),
OlusturmaTarih datetime
)

GO 

create proc LOGMEKAYDET
(
@Levels nvarchar(20),
@Mesaj nvarchar(max)
)
as
begin
insert into LOGME (Levels,Mesaj,OlusturmaTarih) values (@Levels,@Mesaj,getdate())
end