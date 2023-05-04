using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ForGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel kullanım
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ben bir for döngüsüyüm.");
            }
            Console.Clear();
            #endregion
            #region Ekran üzerinde 1 - 10 arasındaki değerleri yazdıralım.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + ". tekrar!");
            }
            Console.Clear();
            #endregion

            #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım.
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine(i + "- Çift Sayıdır!");

                }
            }
            Console.Clear();
            #endregion

            #region Küçük ödev : 1 - 100 arasındaki çift sayıların toplamı nedir?
            int toplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);

            Console.Clear();
            #endregion

            #region Kullanıcı ekran üzerinden bir sayı girişi yapacak (5). Girilen sayının faktöriyel hesabını alıp ekrana yazdıralım.
            Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = 1;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            Console.WriteLine("{0}! = {1} ", sayi, sonuc);

            Console.Clear();
            #endregion
            #region Sonsuz döngü oluşturma
            int sayac = 0;

            for (; ; )
            {
                // break anahtar kelimesi;
                sayac++;
                if (sayac == 2)
                {
                    break;
                }
                Console.WriteLine(sayac);

                // continue anahtar kelimesi
                if (sayac == 3)
                {
                    continue; // Şart sağlanınca döngünün başına atar.
                }
                Console.WriteLine(sayac);

                Console.WriteLine("Merhaba ben bir sonsuz döngüyüm.");
            }

            Console.Clear();
            #endregion

            #region İç içe for döngüsü kullanımı
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Clear();
            #endregion

            #region Ödev : Çarpım Tablosu
            /*
             * 1*1 = 1
             * 1*2 = 2
             * 1*3 = 3
             * 1*4 = 4
             * 1*5 = 5
             * 1*6 = 6
             * 1*7 = 7
             * 1*8 = 8
             * 1*9 = 9
             * 1*10 = 10
             * .
             * .
             * .
             * 2*1 = 2
             * 
             */
            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    int carpimSonuc = i * y;
                    Console.WriteLine("{0} * {1} = {2}", i, y, carpimSonuc);
                }
                Console.WriteLine();
            }
            Console.Clear();
            #endregion
        }
    }
}
