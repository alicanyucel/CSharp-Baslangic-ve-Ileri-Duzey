using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemIO;

namespace SystemIO.DirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("D:\\Udemy");
            //KlasorVarlikKontrolu("D:\\Udemy");
            //KlasorSilmeIslemleri("D:\\Udemy");
            //Odev1();
            //KlasorTasima("D:\\Udemy", "D:\\TasimaIslemi\\Udemy");
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo D1 = Directory.CreateDirectory(path);
        }

        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path);
        }

        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path, true); // İçi dodluyken silmedi. true ile sildirdik.
        }

        static void Odev1()
        {
            /*
             * C sürücüsü içerisinde Udemy adında bir klasör oluşturun oluşturmadan önce varlık kontorlü yapın eğer klasor var ise silin daha sonra oluşturun 
             * Eğer klasor yok ise oluşturun fakat bu adımların bilgisini ekrana yazdırın .
             */

            string dosyaYol = @"D:\Udemyy";
            bool kontrol = Directory.Exists(dosyaYol);

            if (kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör sistemde mevcut.");
                Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "E")
                {
                    Directory.Delete(dosyaYol, true);
                    Console.WriteLine("Dosya silme işlemi tamamlandı.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor.");
                    Directory.CreateDirectory(dosyaYol);
                }

                else
                {
                    Console.WriteLine("İşlem bitti.");
                }
            }

            else
            {
                DirectoryInfo DI = Directory.CreateDirectory(dosyaYol);
                if (DI.Exists)
                {
                    Console.WriteLine("Dosya sistemde oluşturuldu.");
                }
            }
        }

        static void KlasorTasima(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }
    }
}

