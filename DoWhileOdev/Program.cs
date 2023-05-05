using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Odev 1 : Kullanıcıyı do while içerisine alın ve kullanıcı adı ve password sorun. Kullanıcı adı : Demo Şifre : Demo eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri sormaya devam edin.

            // Demo - demo - DeMo

            string kullaniciAdi = string.Empty;
            string sifre = string.Empty;
            int sayac = 0;

            do
            {
                // Sayaç ile kontrol etmemiz önemli bunun nedeni do while içerisinde herhangi bir if koşulu ile şartlarımızı kontrol etmedik while ( şart ) blogu içerisinde kontrollerimizi yaptığımız için değerin hatalı veya doğru olduğunu sayaç adındaki bu değişken üzerinden kontrol ettik.
                if (sayac > 0)
                {
                    Console.WriteLine("Kullacısı adı veya şifreniz kontrol ediniz.");
                }

                Console.Write("Kullanıcı adınızı giriniz. ");
                kullaniciAdi = Console.ReadLine();

                Console.Write("Şifre girişi yapınız. ");
                sifre = Console.ReadLine();

                sayac++;
            } while (kullaniciAdi.ToLower() != "demo" || sifre.ToLower() != "demo");
            Console.WriteLine("Başarılı kullanıcı girişi");

            #endregion

            #region Odev 2 : Kullanıcıdan 1 ile X arasında bir sayı girmesini isteyin. Daha sonra sistem kullanıcının girmiş olduğu 1 ile X değerleri arasında bir sayı tahmini yapsın. Daha sonra kullanıcu sistemin tahmin etmiş olduğu sayıyı bulmaya çalışssın. Bulamaz ise yeniden yeniden sorsun. Ne zaman kullanıcı ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız desin. 

            int tahmin = 0;
            int uretilenSayi = 0;
            int sayac2 = 0;

            Console.Write("Tahmin oyunu 1 ile kaç arasında olsun ? : ");
            int maxValue = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            rnd.Next(1, maxValue);
            uretilenSayi = rnd.Next(1, maxValue);

            do
            {
                sayac2++;
                Console.Write("{0}. Deneme ) Üretilen sayıyı tahmin ediniz :", sayac2);
                tahmin = int.Parse(Console.ReadLine());
            } while (tahmin != uretilenSayi);
            Console.WriteLine("{0} .Deneme ) Sayıyı tahmin ettiniz. Tebrikler!!", sayac2);
            #endregion
        }
    }
}
