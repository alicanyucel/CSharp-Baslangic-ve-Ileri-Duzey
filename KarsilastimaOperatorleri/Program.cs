using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastimaOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 100;
            int s2 = 150;

            // Büyük mü karşılaştırması >
            // bool donusDegeri = degisken1 > degisken2 TRUE - FALSE

            bool sonuc1 = s1 > s2;
            bool sonuc2 = s2 > s1;

            // Küçük mü karşılaştırması <
            // bool donusDegeri = degisken1 < degisken2 TRUE - FALSE

            bool sonuc3 = s1 < s2;
            bool sonuc4 = s2 < s1;

            // Atama operatörü = 
            // Degisken = AtanacakDeger

            decimal decimalSayi1 = 10.9M;

            // Eşit mi karşılaştırması == !=

            bool esitKontrol1 = s1 == s2;
            bool esitkontrol2 = s1 != s2;

            // Büyük eşit mi karşılaştırması >=
            // bool donusDegeri = degisken1 >= degisken2

            bool buyukEsitSonuc = s1 >= s2;
            bool buyukEsitSonuc2 = s2 >= s1;

            // Küçük eşit mi karşılaştırması <=
            // bool donusDegeri = degisken1 <= degisken2

            bool kucukEsitSonuc = s1 <= s2;
            bool kucukEsitSonuc2 = s2 <= s1;

            // is operatörü
            // bool donusDegeri = degisken is değikenTipi

            object o1 = s1;
            Console.WriteLine(o1);
            s1 = (int)o1;
            // s1 = (byte)o1; HATA!

            bool isKontrol = o1 is int;
            bool isKontrol2 = o1 is byte;

            // as operatörü

            string isimSoyisim = "Cengiz Atilla";
            object objectString = isimSoyisim;
            string sonucStr = objectString as string;
        }
    }
}
