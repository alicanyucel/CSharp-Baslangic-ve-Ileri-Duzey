using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalar2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sistem içerisine giriş yapabilcek kullanıcı kodları
             * 
             * ABC - 123 - 236 - CMK
             * Kullanıcı girişi başarılı
             * 
             * Sistem içerisine girişi yasaklanmış kullanıcı kodları
             * 
             * HHH - BBB - MMM
             * 
             * Kullanıcı girişiniz kilitlenmiştir.
             * 
             * Bunların dışında ise,
             * 
             * Hatalı kullanıcı kodu
             */

            Console.Write("Lütfen kullanıcı kodunuzu giriniz : ");
            string kullaniciKodu = Console.ReadLine();
            kullaniciKodu = kullaniciKodu.ToUpper();

            if (kullaniciKodu == "ABC" || kullaniciKodu == "123" || kullaniciKodu == "236" || kullaniciKodu == "CMK")
            {
                Console.WriteLine("Giriş işleminiz başarılı.");
            }

            else if (kullaniciKodu == "HHH" || kullaniciKodu == "BBB" || kullaniciKodu == "MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
            }

            else
            {
                Console.WriteLine("Hatalı kullanıcı kodu girdiniz.");
            }
        }
    }
}
