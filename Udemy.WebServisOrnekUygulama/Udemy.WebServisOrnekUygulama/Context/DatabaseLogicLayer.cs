using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Udemy.WebServisOrnekUygulama.Entities;

namespace Udemy.WebServisOrnekUygulama.Context
{
    public class DatabaseLogicLayer : IDisposable
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValueInt;
        OutputType ReturnValueOutputType;

        public DatabaseLogicLayer()
        {
            con = new SqlConnection(
                "Data Source = (localdb)\\MSSQLLOCALDB; " +
                "Initial Catalog = WebServisKullanimi;"
                );

        }

        public void BaglantiIslemleri()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            else
            {
                con.Close();
            }
        }

        public OutputType UrunKayitYeni(Urun U)
        {
            cmd = new SqlCommand(("insert into Urun values (@UrunKimlik, @Tanim, @Aciklama, @StokAdet)"), con);
            cmd.Parameters.Add("@UrunKimlik", SqlDbType.NVarChar).Value = U.UrunKimlik;
            cmd.Parameters.Add("@Tanim", SqlDbType.NVarChar).Value = U.Tanim;
            cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = U.Aciklama;
            cmd.Parameters.Add("@StokAdet", SqlDbType.Int).Value = U.StokAdet;

            BaglantiIslemleri();
            ReturnValueOutputType = cmd.ExecuteNonQuery() > 0 ? OutputType.IslemBasarili : OutputType.IslemBasarisiz;
            BaglantiIslemleri();

            return ReturnValueOutputType;
        }

        public OutputType UrunKimlikKontrol(string UrunKimlik)
        {
            cmd = new SqlCommand("select count(1) from Urun where UrunKimlik = @UrunKimlik", con);
            cmd.Parameters.Add("@UrunKimlik", SqlDbType.NVarChar).Value = UrunKimlik;

            BaglantiIslemleri();
            ReturnValueOutputType = ((int)cmd.ExecuteScalar()) > 0 ? OutputType.KayitliUrun : OutputType.YeniUrun;
            BaglantiIslemleri();

            return ReturnValueOutputType;
        }

        public OutputType UrunKayitDuzenle(Urun U)
        {
            cmd = new SqlCommand("update Urun set Tanim = @Tanim, Aciklama = @Aciklama, StokAdet = @StokAdet where UrunKimlik = @UrunKimlik", con);
            cmd.Parameters.Add("@UrunKimlik", SqlDbType.NVarChar).Value = U.UrunKimlik;
            cmd.Parameters.Add("@Tanim", SqlDbType.NVarChar).Value = U.Tanim;
            cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = U.Aciklama;
            cmd.Parameters.Add("@StokAdet", SqlDbType.Int).Value = U.StokAdet;

            BaglantiIslemleri();
            ReturnValueOutputType = cmd.ExecuteNonQuery() > 0 ? OutputType.IslemBasarili : OutputType.IslemBasarisiz;
            BaglantiIslemleri();

            return ReturnValueOutputType;
        }

        public OutputType UrunKayitSil(string UrunKimlik)
        {
            cmd = new SqlCommand("delete Urun where UrunKimlik = @UrunKimlik", con);
            cmd.Parameters.Add("@UrunKimlik", SqlDbType.NVarChar).Value = UrunKimlik;

            BaglantiIslemleri();
            ReturnValueOutputType = cmd.ExecuteNonQuery() > 0 ? OutputType.IslemBasarili : OutputType.IslemBasarisiz;
            BaglantiIslemleri();

            return ReturnValueOutputType;
        }

        public List<Urun> UrunKayitListe()
        {
            List<Urun> UrunListe = new List<Urun>();

            cmd = new SqlCommand("select * from Urun", con);

            BaglantiIslemleri();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                UrunListe.Add(new Urun()
                {
                    ID = reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    Tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    UrunKimlik = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    StokAdet = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                });
            }
            reader.Close();

            BaglantiIslemleri();

            return UrunListe;
        }

        public Urun UrunKayitListe(string UrunKimlik)
        {
            Urun BulunanUrun = null;

            cmd = new SqlCommand("select * from Urun where UrunKimlik = @UrunKimlik", con);
            cmd.Parameters.Add("@UrunKimlik", SqlDbType.NVarChar).Value = UrunKimlik;

            BaglantiIslemleri();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BulunanUrun = new Urun()
                {
                    ID = reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    Tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    UrunKimlik = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    StokAdet = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                };
            }
            reader.Close();

            BaglantiIslemleri();

            return BulunanUrun;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}