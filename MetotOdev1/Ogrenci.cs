using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev1
{
    public class ogrenci
    {
        public void ogrenciNotHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3 = 45)
        {
            Console.WriteLine("Öğrencinin bilgileri aşağıdaki gibidir.");
            Console.WriteLine("Ad Soyad : {0} {1}", ad, soyad);

            decimal ortalama = ortalamaHesapla(not1, not2, not3);
            ortalamaNotDegerlendir(ortalama);

            ortalamaNotDegerlendir(ortalamaHesapla(not1, not2, not3));
        }

        void ortalamaNotDegerlendir(decimal ogrenciOrtalama)
        {
            if (ogrenciOrtalama < 45)
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Kaldınız", ogrenciOrtalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Geçtiniz", ogrenciOrtalama);
            }
        }

        private decimal ortalamaHesapla(decimal ogrenciNot1, decimal ogrenciNot2, decimal ogrenciNot3)
        {
            //decimal ortalama = (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;
            //return ortalama;
            return (ogrenciNot1 + ogrenciNot2 + ogrenciNot3) / 3;
        }
    }
}
