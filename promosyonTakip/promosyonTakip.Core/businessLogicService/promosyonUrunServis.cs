using promosyonTakip.Core.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.businessLogicService
{
    public class promosyonUrunServis : baseServis<promosyonUrun>
    {
        database.promosyonSepeti db;
        public promosyonUrunServis()
        {
            db = new database.promosyonSepeti();
        }

        public List<promosyonUrun> urunListeGetir()
        {
            liste = new List<promosyonUrun>();
            cmd = new System.Data.SqlClient.SqlCommand("select  top 30 * from promosyonUrun where kullanimDurum = 1 order by NEWID()");
            reader = db.liste(cmd);
            while (reader.Read())
            {
                liste.Add(new promosyonUrun()
                {
                    id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    gecerlilikTarih = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4),

                });
            }
            reader.Close();
            db.baglantiDurumuAyarla();
            return liste;
        }

        public promosyonUrun tekUrunGetir(int id)
        {
            data = new promosyonUrun();
            cmd = new System.Data.SqlClient.SqlCommand("select   * from promosyonUrun where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            reader = db.liste(cmd);
            while (reader.Read())
            {
                data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                data.gecerlilikTarih = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);
                data.kullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4);
            }
            reader.Close();
            db.baglantiDurumuAyarla();
            return data;
        }

        public int urunKullanildiIsaretle(int id)
        {
            cmd = new System.Data.SqlClient.SqlCommand("update  promosyonUrun set kullanimDurum = @kullanimDurum where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@kullanimDurum", SqlDbType.Bit).Value = false;
            return db.ekleDuzenleSil(cmd);
        }
    }
}
