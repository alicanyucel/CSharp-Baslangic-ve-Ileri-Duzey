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
    public class potansiyelMusteriServis : baseServis<potansiyelMusteri>
    {
        database.promosyonSepeti db;
        public potansiyelMusteriServis()
        {
            db = new database.promosyonSepeti();
        }

        public int kayitYeni(potansiyelMusteri data)
        {
            cmd = new SqlCommand("insert into potansiyelMusteri values (@tcKimlikNumara,@isim,@soyisim,@dogumTarih,@cinsiyet,@meslek,@emailAdres,@emailBildirimOnay,@telefon,@telefonBildirimOnay,@olusturmaTarih,@olusturmaMagaza)");
            cmd.Parameters.Add("@tcKimlikNumara", SqlDbType.NVarChar).Value = data.tcKimlikNumara;
            cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = data.isim;
            cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = data.soyisim;
            cmd.Parameters.Add("@dogumTarih", SqlDbType.DateTime).Value = data.dogumTarih;
            cmd.Parameters.Add("@cinsiyet", SqlDbType.Int).Value = data.cinsiyet;
            cmd.Parameters.Add("@meslek", SqlDbType.NVarChar).Value = data.meslek;
            cmd.Parameters.Add("@emailAdres", SqlDbType.NVarChar).Value = data.emailAdres;
            cmd.Parameters.Add("@emailBildirimOnay", SqlDbType.Bit).Value = data.emailBildirimOnay;
            cmd.Parameters.Add("@telefon", SqlDbType.NVarChar).Value = data.telefon;
            cmd.Parameters.Add("@telefonBildirimOnay", SqlDbType.Bit).Value = data.telefonBildirimOnay;
            cmd.Parameters.Add("@olusturmaTarih", SqlDbType.DateTime).Value = data.olusturmaTarih;
            cmd.Parameters.Add("@olusturmaMagaza", SqlDbType.Int).Value = data.olusturmaMagaza;
            sonuc = db.ekleDuzenleSil(cmd);
            return sonuc;
        }

        public int TCSorgula(string tcKimlikNumara)
        {
            cmd = new SqlCommand("select id from  potansiyelMusteri where tcKimlikNumara = @tcKimlikNumara");
            cmd.Parameters.Add("@tcKimlikNumara", SqlDbType.NVarChar).Value = tcKimlikNumara;
            obj = db.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
