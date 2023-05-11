using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticBolumSonuOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.emailAdres = "cengiz.atilla@hotmail.com";
            M1.KullaniciAdi = "cengiz.atilla";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "Ahmet",
                soyisim = "Atilla",
                emailAdres = "ahmet.atilla@hotmail.com",
                KullaniciAdi = "ahmet.atilla",
                sifre = "2"
            };

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
            M3.musteriID = 3;
            M3.isim = "Cengiz";
            M3.soyisim = "Atilla";
            M3.emailAdres = "cengiz.atilla@hotmail.com";
            M3.KullaniciAdi = "cengiz.atilla";
            M3.sifre = "1";

            Musteri.MusteriEkle(M3);
        }
    }
}
