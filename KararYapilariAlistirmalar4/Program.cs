using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalar4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Not ortalaması sistemine hoşgeldiniz !
             * 
             * İsim ve Soyisim : Cengiz Atilla
             * Not1 : 50
             * Not1 : 40
             * Not1 : 60
             * 
             * Ortalama 45 değerinden küçük ise : Kaldınız.
             * Ortalama 45 değerine eşit veya 70 değerinden küçük ise : Orta ile geçtiniz.
             * Ortalama 70 değerine eşit veya 90 değerinden küçük ise : İyi ile geçtiniz.
             * Ortalama 90 ile 100 arasında ise ( 100 dahil ) : Başarılı Tebrikler.
             * Ortalama 100 den büyük ise : Notlarınızı kontrol ediniz.
             */

            Console.WriteLine("Not ortalaması sistemine hoşgeldiniz !");
            Console.Write("İsim Soyisim :");
            string isimSoyisim = Console.ReadLine();

            Console.Write("Not 1 : ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Not 2 : ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Not 3 : ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            decimal ortalama = (not1 + not2 + not3) / 3;

            if (ortalama < 45)
            {
                Console.WriteLine("Kaldınız.");
            }

            else if (ortalama >= 45 && ortalama < 70)
            {
                Console.WriteLine("Orta ile geçtiniz.");
            }

            else if (ortalama >= 70 && ortalama < 90)
            {
                Console.WriteLine("İyi ile geçtiniz.");
            }

            else if (ortalama >= 90 && ortalama < 100)
            {
                Console.WriteLine("Başarılı Tebrikler.");
            }

            else
            {
                Console.WriteLine("Notlarınızı kontrol ediniz.");
            }

            Console.WriteLine("Uygulama Sonu");
        }
    }
}
