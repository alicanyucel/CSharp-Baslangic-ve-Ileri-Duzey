using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch (ifade)
             * {
             * case kontrol1 :
             * case kontrol3 :
             * çalışacak olan işlemler
             * break;
             * case kontrol2 :
             * calışacak olan işlemler
             * break;
             * default:
             * çalışacak olan işlemler
             * break;
             * }
             */

            // Ocak Şubat Mart Nisan ... Cengiz
            Console.Write("Hangi Ay:");
            string kullaniciGelen = Console.ReadLine();

            switch (kullaniciGelen)
            {
                case "Ocak":
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                case "Nisan":
                    Console.WriteLine("04");
                    break;
                case "Mayıs":
                    Console.WriteLine("05");
                    break;
                case "Haziran":
                    Console.WriteLine("06");
                    break;
                case "Temmuz":
                    Console.WriteLine("07");
                    break;
                case "Ağustos":
                    Console.WriteLine("08");
                    break;
                case "Eylül":
                    Console.WriteLine("09");
                    break;
                case "Ekim":
                    Console.WriteLine("10");
                    break;
                case "Kasım":
                    Console.WriteLine("11");
                    break;
                case "Aralık":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
