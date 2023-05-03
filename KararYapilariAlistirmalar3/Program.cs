using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalar3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Menü
             * 1 - Toplama
             * 2 - Çıkarma
             * 3 - Çarpma
             * 4 - Bölme
             * Seçiniz : -
             * 
             * Kurallar : 4. Seçenek içerisinde bölen 0 olamak kontrolü yapılacak.
             */

            Console.WriteLine("Menü");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");

            Console.Write("İşlem seçiniz : ");
            string kullaniciSecim = Console.ReadLine();


            if (kullaniciSecim == "1" || kullaniciSecim == "2" || kullaniciSecim == "3" || kullaniciSecim == "4")
            {
                Console.Write("Sayı 1 değerini giriniz : ");
                decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Sayı 2 değerini giriniz : ");
                decimal sayi2 = Convert.ToDecimal(Console.ReadLine());


                if (kullaniciSecim == "1")
                {
                    Console.WriteLine("Toplam : " + (sayi1 + sayi2));
                }
                else if (kullaniciSecim == "2")
                {
                    Console.WriteLine("Fark : " + (sayi1 - sayi2));
                }
                else if (kullaniciSecim == "3")
                {
                    Console.WriteLine("Çarpım : " + (sayi1 * sayi2));
                }
                else if (kullaniciSecim == "4")
                {
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Bölen değer 0 olamaz...");
                    }
                    else
                    {
                        Console.WriteLine("Bölüm : " + (sayi1 / sayi2));
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz değerleri kontrol ediniz.");
                }
            }
            else
            {
                Console.WriteLine("Lütfen menüden bir değer seçtiğinizden emin olun.");
            }

            Console.ReadLine();
        }
    }
}
