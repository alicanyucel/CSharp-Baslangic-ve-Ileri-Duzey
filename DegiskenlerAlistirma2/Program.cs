using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenAlistirmalar1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba
             * İsminiz :
             * Soyisiminiz :
             * Şehir : 
             * Yaş:
             */
            Console.WriteLine("Merhaba!");

            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz : ");
            string soyisim = Console.ReadLine();

            Console.Write("Şehiriniz : ");
            string sehir = Console.ReadLine();

            Console.Write("Yaşınız : ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Şehir : " + sehir);
            Console.WriteLine("Yaş : " + yas);

            Console.ReadLine();
        }
    }
}
