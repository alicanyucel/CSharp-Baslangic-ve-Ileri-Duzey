using promosyonTakip.Core.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.businessLogicService
{
    public class sistemMagazaServis : baseServis<sistemMagaza>
    {
       
        database.promosyonSepeti db;
        public sistemMagazaServis()
        {
            db = new database.promosyonSepeti();
        }

        public int magazaKullaniciKontrol(string kullaniciAdi, string sifre)
        {
            cmd = new SqlCommand("select id from sistemMagaza where kullaniciAdi = @kullaniciAdi and sifre = @sifre");
            cmd.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = kullaniciAdi;
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifre;
            obj = db.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }


    }
}
