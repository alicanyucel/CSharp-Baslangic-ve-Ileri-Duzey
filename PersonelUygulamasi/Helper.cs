using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    public static class Helper
    {
        // Static olarak işaretlenmiş classlar örneklenemez.
        //  Helper H1 = new Helper();

        /*
         * public void Test()
           {

           }
         * 
         * Static olan classlar içerisinde standart metotlar kullanılamaz. ( Static olmayan metotlar )
         */

        /* 
         * public string Tanim { get; set; }
         * Static olan classlar içerisinde static olmayan field tanımları yapılmaz.
         */

        //public Helper()
        //{
            // Her nesne örneği alındığında uygulama standart yapıcı metotu çalıştırır.
        //}

        static Helper()
        {
            // Uygulama içerisinde istenildiği kadar çarılsınlar sadece ilk çağrılmada çalışırlar.
            Console.WriteLine("Helper => Static Class => Static Ctor");
        }

        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            // Email gönderme işlemleri devam edecek...
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }

    }
}
