using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Udemy.WebServisOrnekUygulama.Entities
{
    public class Urun
    {
        public int ID { get; set; }
        public string UrunKimlik { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public int StokAdet { get; set; }
    }
}

//create table Urun
//(
//ID int identity(1,1) primary key,
//UrunKimlik nvarchar(10),
//Tanim nvarchar(100),
//Aciklama nvarchar(255),
//StokAdet int
//)