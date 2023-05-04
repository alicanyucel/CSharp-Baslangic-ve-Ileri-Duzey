using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariIf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * &&
             * ||
             */

            /*
             * if(şart veya şartlar)
             * {
             *   // Eğer şart veya şartlar sağlandı ise yapılacak işlemler
             * }
             * else if(şart veya şartlar)
             * {...}
             * else if(şart veya şartlar)
             * {...}
             * else if(şart veya şartlar)
             * {...}
             * .
             * .
             * .
             * else
             * {
             *   // Şart veya şartlar doğru değil ise yapılacak işlemler
             * }
             */



            Console.Write("Sayı 1 değerini giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sayı 2 değerini giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal toplam = sayi1 + sayi2;

            bool toplamKontrol = toplam > 50;

            //if (toplamKontrol)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");
            //}

            if (toplam >= 100)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 100'den büyük veya eşittir.");
            }

            else if (toplam >= 50)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyük veya eşittir.");
            }

            else
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den küçüktür.");
            }

            Console.WriteLine("Kod1");
            Console.WriteLine("Kod2");
        }
    }
}
