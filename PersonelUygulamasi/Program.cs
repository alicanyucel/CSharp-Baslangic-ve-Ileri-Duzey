using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "Cengiz";
            P1.Soyisim = "Atilla";
            P1.EmailAdres = "cengiz.atilla";
            P1.Cinsiyet = 717770001; // Bay, 717770002 - Bayan

            Personel P2 = new Personel();
            P2.Isim = "Cengiz";
            P2.Soyisim = "Atilla";
            P2.EmailAdres = "cengiz.atilla";
            P2.Cinsiyet = 717770001; // Bay, 717770002 - Bayan

            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
        }
    }
}
