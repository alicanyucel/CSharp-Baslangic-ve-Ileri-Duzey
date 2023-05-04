using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsü Genel Kullanımı 
            //while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmasına devam eder. 
            //{
            //    /*
            //     * 1 - While ( False ) 
            //     * 2 - Break; 
            //     */
            //}

            #endregion

            #region Örnek Kullanım 1 : Ekrana 1 - 10 a kadar sayıların değerlerini yazdıralım. 

            // For döngüsü ile bu işlemin cevabı
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // While döngüsü ile bu işlemin cevabı
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            Console.Clear();

            #endregion

            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım .
            /*
             * 3
             * 2
             * 1
             * 0
             */

            Console.Write("Lütfen bir sayı giriniz : ");
            string kullanicidanGelenDeger = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            int ornekKullanimSayac = int.Parse(kullanicidanGelenDeger);

            while (ornekKullanimSayac != -1)
            {
                Console.WriteLine(ornekKullanimSayac);
                ornekKullanimSayac = ornekKullanimSayac - 1;
                //ornekKullanimSayac--;
            }

            Console.WriteLine("Örnek 1 işlemi tamamlandı.");

            Console.Clear();
            #endregion

            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0 dan kucuk bir değer girişi yapılırsa toplama işlemini bitirelim ve ekrana toplam sonucu yazalım. 

            Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz. ");
            Console.WriteLine("Not : -1  değeri işlemlerinizi dururur.");

            int ornekKullanimToplam = 0;
            while (true)
            {
                string Ornek2KullaniciGelenDeger = Console.ReadLine();
                int Ornek2KulGelenDegerInt = int.Parse(Ornek2KullaniciGelenDeger);
                if (Ornek2KulGelenDegerInt < 0)
                    break;
                else
                    ornekKullanimToplam = ornekKullanimToplam + Ornek2KulGelenDegerInt;
            }

            Console.WriteLine("Toplam Değer : {0}", ornekKullanimToplam);

            #endregion

            #region Ödev : Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım. 

            int tahminAdet = 1;
            Random rnd = new Random();
            int sistemUretSayi = rnd.Next(1, 10);

            while (true)
            {
                Console.Write("{0} . deneme - Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz :", tahminAdet);
                string rndKullaniciGelen = Console.ReadLine();

                int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);

                // if (int.Parse(rndKullaniciGelen) == sistemUretSayi)
                if (rndKullaniciGelenInt == sistemUretSayi)
                {
                    // tahminAdet++;
                    Console.WriteLine("{0}. denemenizde değeri buldunuz Tebrikler !", tahminAdet);
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} . denemeniz , Tahmin edemediniz lütfen yeniden deneyin ...", tahminAdet);
                    tahminAdet++;
                }
            }
            Console.Clear();
            #endregion
        }
    }
}
