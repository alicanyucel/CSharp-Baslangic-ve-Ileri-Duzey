using BuyukDatalarIleCalismak.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukDatalarIleCalismak.Operasyon
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dataAccessLayer;

        public BusinessLogicLayer()
        {
            dataAccessLayer = new DataAccessLayer();
        }

        public int KayitEkle(string Isim, string Soyisim, string EmailAdres, string TelefonNumarasi, byte[] Resim)
        {
            // Kontrol işlemleri bu adımda yapılır.

            Kisi kisi = new Kisi()
            {
                Isim = Isim,
                Soyisim = Soyisim,
                EmailAdres = EmailAdres,
                TelefonNumarasi = TelefonNumarasi,
                Resim = Resim
            };

            return dataAccessLayer.KayitEkle(kisi);
        }

        public Kisi KisiDetayGetir(int id)
        {
            Kisi kisi = new Kisi();
            // Kontrol işlemlerini yapabiliriz.
            SqlDataReader reader = dataAccessLayer.KisiDetayGetir(id);

            while (reader.Read())
            {
                kisi.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                kisi.Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                kisi.Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                kisi.EmailAdres = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                kisi.TelefonNumarasi = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                kisi.Resim = reader.IsDBNull(5) ? null : (byte[])reader[5];
            }
            reader.Close();
            dataAccessLayer.BaglantiAyarla();

            return kisi;
        }

        public List<Kisi> KisilerListe()
        {
            List<Kisi> Kisiler = new List<Kisi>();
            SqlDataReader reader = dataAccessLayer.KisilerListe();

            while (reader.Read())
            {
                Kisiler.Add(new Kisi()
                {
                    ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    EmailAdres = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    TelefonNumarasi = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    Resim = reader.IsDBNull(5) ? null : (byte[])reader[5]
                });
            }
            reader.Close();
            dataAccessLayer.BaglantiAyarla();

            return Kisiler;
        }
    }
}
