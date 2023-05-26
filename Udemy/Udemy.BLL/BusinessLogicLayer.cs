using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;

namespace Udemy.BLL
{
    public class BusinessLogicLayer
    {
        Udemy.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }

        public int KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            int Sonuc = 0;
            if (!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = KullaniciAdi;
                kullanici.Sifre = Sifre;
                Sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                Sonuc = -100; // Eksik parametre hatası 
            }
            return Sonuc;
        }

        public int YeniKayit(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string TelefonIII, string Adres, string EmailAdres, string Website, string Aciklama)
        {
            int Sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.TelefonIII = TelefonIII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = Website;
                Kayit.Aciklama = Aciklama;

                Sonuc = DLL.YeniKayit(Kayit);
            }
            else
            {
                Sonuc = -100; // Eksik parametre hatası
            }
            return Sonuc;
        }
    }
}
