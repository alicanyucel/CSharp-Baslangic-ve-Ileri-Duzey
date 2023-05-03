using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adını giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifrenizi giriniz : ");
            string sifre = Console.ReadLine();

            // Kullanıcı adı = admin
            // Şifre = 123

            if (kullaniciAdi == "admin" && sifre == "123")
            {
                Console.WriteLine("Merhana, giriş işlemi başarılı");
            }
            
            else
            {
                Console.WriteLine("Giriş başarısız, kullanıcı adı ve şifrenizi kontrol ediniz.");
            }
        }
    }
}
