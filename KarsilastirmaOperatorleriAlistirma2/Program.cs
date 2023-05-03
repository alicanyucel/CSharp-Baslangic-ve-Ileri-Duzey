using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleriAlistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı adı : admin
            // Şifre : 123

            // Kullanıcı adınızı giriniz :
            // Şifrenizi giriniz :

            Console.Write("Kullanıcı adınızı giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifrenizi giriniz : ");
            string sifre = Console.ReadLine();

            bool kullaniciAdiKontrol1 = kullaniciAdi == "admin";
            bool kullaniciAdiKontrol2 = kullaniciAdi != "admin";

            bool sifreKontrol1 = sifre == "123";
            bool sifreKontrol2 = sifre != "123";
        }
    }
}
