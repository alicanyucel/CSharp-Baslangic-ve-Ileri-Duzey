using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselIslemler
{
    public class Matematik
    {
        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("*** MENÜ ***");
            Console.WriteLine("1) Toplama");
            Console.WriteLine("2) Çıkarma");
            Console.WriteLine("3) Bölme");
            Console.WriteLine("4) Çarpma");

            Console.Write("Lütfen işlem seçiniz ... ");
        }

        public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", kullaniciSayi1, operators, kullaniciSayi2, sonuc);
        }

        // Toplama
        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        // Çıkarma
        public decimal cikartmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        // Bölme
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Bölme işlemi 0 ile gerçekleştirilemez.");
            }
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        // Çarpma
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }
    }
}
