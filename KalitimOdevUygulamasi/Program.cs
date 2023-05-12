using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar1 = new Bilgisayar();
            // bilgisayar1.Id = 1; // Girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum ...
            bilgisayar1.marka = "Lenova";
            bilgisayar1.model = "z50";
            bilgisayar1.islemci = "I5";
            bilgisayar1.alisFiyat = 1500M;
            bilgisayar1.satisFiyat = 1600M;
            bilgisayar1.kampanyaFiyat = 1000M;
            bilgisayar1.barkod = "1234567890"; // => 

            sanalDatabase.yeniUrunEkle(bilgisayar1);

            Bilgisayar bilgisayar2 = new Bilgisayar();
            // bilgisayar1.Id = 1; // Girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum ...
            bilgisayar2.marka = "Lenova";
            bilgisayar2.model = "z50";
            bilgisayar2.islemci = "I5";
            bilgisayar2.alisFiyat = 1500M;
            bilgisayar2.satisFiyat = 1600M;
            bilgisayar2.kampanyaFiyat = 1000M;
            bilgisayar2.barkod = "1234567890"; // => 

            sanalDatabase.yeniUrunEkle(bilgisayar2);
        }
    }
}
