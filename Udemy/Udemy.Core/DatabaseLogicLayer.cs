using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;
namespace Udemy.Core
{
    public class DatabaseLogicLayer
    {
        List<RehberKayit> Kayitlarim;
        public DatabaseLogicLayer()
        {
            Kayitlarim = new List<RehberKayit>();
            VeriTabaniKontrol();
        }

        private void VeriTabaniKontrol()
        {
            bool KlasorKontrol = Directory.Exists(@"c:\TelefonRehberiDB\");
            if (!KlasorKontrol)
            {
                Directory.CreateDirectory(@"c:\TelefonRehberiDB\");

                Kullanici Demo = new Kullanici();
                Demo.ID = Guid.NewGuid();
                Demo.KullaniciAdi = "Demo";
                Demo.Sifre = "Demo";

                List<Kullanici> Kullanicilarim = new List<Kullanici>();
                Kullanicilarim.Add(Demo);

                string JsonKullaniciText = Newtonsoft.Json.JsonConvert.SerializeObject(Kullanicilarim);
                File.WriteAllText(@"C:\TelefonRehberiDB\kullanici.json", JsonKullaniciText);

            }

        }

        public int YeniKayit(RehberKayit K)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir(); // Class seviyesinde oluşturmuş olduğum koleksiyonum içerisine datamı doldurdum ( varsa ) yoksa zaten bellekte hiç bir değeri yoktu o sekilde yeni değer eklenmek üzere bekliyor. 
                Kayitlarim.Add(K); // Koleksiyonumuza değerimizi ekledik. 
                JsonDBGuncelle(); // var ise üzerine yazdı , yoksa yeni json oluşturdu.
                Sonuc = 1;
            }
            catch (Exception)
            {
                // Log
                Sonuc = 0;
            }
            return Sonuc;
        }

        public int KayitGuncelle(RehberKayit K)
        {
            int Sonuc = 0;

            try
            {
                RehberKayitlariGetir();
                int Index = Kayitlarim.FindIndex(I => I.ID == K.ID);
                if (Index > -1)
                {
                    Kayitlarim[Index].Isim = K.Isim;
                    Kayitlarim[Index].Soyisim = K.Soyisim;
                    Kayitlarim[Index].TelefonI = K.TelefonI;
                    Kayitlarim[Index].TelefonII = K.TelefonII;
                    Kayitlarim[Index].TelefonIII = K.TelefonIII;
                    Kayitlarim[Index].EmailAdres = K.EmailAdres;
                    Kayitlarim[Index].Adres = K.Adres;
                    Kayitlarim[Index].Website = K.Website;
                    Kayitlarim[Index].Aciklama = K.Aciklama;
                }
                JsonDBGuncelle();

                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return Sonuc;
        }

        public int KayitSil(Guid ID)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit SilinecekDeger = Kayitlarim.Find(I => I.ID == ID);
                if (SilinecekDeger != null)
                {
                    Kayitlarim.Remove(SilinecekDeger);

                }
                JsonDBGuncelle();

                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return Sonuc;
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            if (File.Exists(@"C:\TelefonRehberiDB\Rehber.json"))
            {
                string JsonDBText = File.ReadAllText(@"C:\TelefonRehberiDB\Rehber.json");
                Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDBText);
            }
            return Kayitlarim;
        }

        public int KullaniciKontrol(Kullanici kullanici)
        {
            int KullaniciSonuc = 0;
            if (File.Exists(@"C:\TelefonRehberiDB\kullanici.json"))
            {
                string JsonKullaniciText = File.ReadAllText(@"C:\TelefonRehberiDB\kullanici.json");
                List<Kullanici> Kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                KullaniciSonuc = Kullanicilar.FindAll(I => I.KullaniciAdi == kullanici.KullaniciAdi && I.Sifre == kullanici.Sifre).ToList().Count();

            }
            return KullaniciSonuc;
        }

        #region Yardimci Metotlar

        private void JsonDBGuncelle()
        {
            if (Kayitlarim != null && Kayitlarim.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"C:\TelefonRehberiDB\Rehber.json", JsonDB);
            }
        }

        #endregion
    }
}
