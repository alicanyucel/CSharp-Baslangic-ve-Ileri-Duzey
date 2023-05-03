using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalOperatorVe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mantıksal ve operatörü &&
            // bool donusDegeri = degisken1 == "admin" && degisken2 == "123"
            /*
             * Sart1      Sart2      Sonuc
             * True       True       True
             * True       False      False
             * False      True       False
             * False      False      False
             */

            string kullaniciAdi = "admin";
            string sifre = "123";
            string anahtar = "1";

            bool donenDeger = kullaniciAdi == "admin" && sifre == "123";
            bool donenDeger2 = kullaniciAdi == "admin" && sifre == "123" && anahtar == "1";
        }
    }
}
