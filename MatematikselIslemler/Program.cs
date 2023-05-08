using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
        YenidenIslemYap:

            matematik.Menu();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.Write("Sayı 1: ");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.Write("Sayı 2: ");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: // Toplama
                    sonuc = matematik.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;

                case 2: // Çıkarma
                    sonuc = matematik.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;

                case 3: // Bölme
                    sonuc = matematik.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;

                case 4: // Çarpma
                    sonuc = matematik.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;

                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen yeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;
            }

            Console.WriteLine("Yeni işlem yapmak istiyor musunuz ? [E/H] ");
            string EH = Console.ReadLine();

            if (EH == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}
