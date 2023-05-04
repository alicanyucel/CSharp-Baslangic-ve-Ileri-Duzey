using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalar5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Kullanıcı Kodu :
            * 
            * Kullanıcı Kodu = AA - BB - CC
            * Admin yetkisine sahipsiniz.
            * Kullanıcı Kodu = DD
            * Güçlü kullanıcı yetkisinie sahipsiniz.
            * Kullanıcı Kodu = FF - EE - GG
            * Standart kullanıcı yetkisine sahipsiniz
            * 
            * Farklı bir giriş olursa : Hatalı kullanıcı kodu
            */

            Console.WriteLine("Kullanıcı Kodu : ");
            string kullaniciKodu = Console.ReadLine();

            switch (kullaniciKodu)
            {
                case "A":
                case "B":
                case "C":
                    Console.WriteLine("Admin yetkisine sahipsiniz.");
                    break;
                case "D":
                    Console.WriteLine("Güçlü kullanıcı yetkisinie sahipsiniz.");
                    break;
                case "E":
                case "F":
                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz.");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu.");
                    break;
            }
        }
    }
}
