using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yenilikler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Interpolition Kullanımı
            string isim = "Cengiz";
            string soyisim = "Atilla";

            Console.WriteLine("Merhaba " + isim + " " + soyisim);

            string karsilamaMetin = string.Format("Merhaba {0} {1}", isim, soyisim);
            Console.WriteLine(karsilamaMetin);
            Console.WriteLine(string.Format("Merhaba {0} {1}", isim, soyisim));

            Console.WriteLine($"Merhaba {isim} - {soyisim}");

            Console.Clear();
            #endregion

            #region Var anahtar kelimesi 
            string isimsoyisim = "Cengiz Atilla";
            Console.WriteLine(isimsoyisim);

            var meslek = "Bilgisayar Programcısı";
            var kategori = 12;
            kategori = 1;

            #endregion

            #region İsimsiz Tip Kullanımı 
            Musteri m = new Musteri();
            m.isim = "Cengiz";
            m.soyisim = "Atilla";


            var Ogrenci = new
            {
                numara = 1,
                isim = "Cengiz",
                soyisim = "Atilla"
            };

            Console.WriteLine(Ogrenci.isim);

            Console.Clear();
            #endregion

            #region Local Function Kullanimi
            int Toplam = Topla(12, 33);
            Console.WriteLine(Toplam);

            int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

            int Carpim = Carp(10, 3);
            Console.WriteLine(Carpim);

            Console.Clear();
            #endregion

            #region Metot Parametrelerine Default Deger Atamasi
            //int sonuc = Carpim(12);
            //Console.WriteLine(sonuc);
            #endregion

            #region Try Catch When Kullanımı 
            try
            {
                //.. kodlarımız var 
                throw new FormatException("Format ");
            }
            catch (FieldAccessException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (FormatException fe) when (fe.Message == "Format Hatası")
            {
                Console.WriteLine(fe.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Clear();
            #endregion

            #region Auto Property Tanımı
            Araba A1 = new Araba();
            A1.Plaka = "34 ABC 11";
            A1.Marka = "BMW";

            Console.WriteLine(A1.Marka);

            Console.Clear();
            #endregion

            #region Tuple Kullanımı 
            var selamlaDegerlerII = SelamlaII();
            Console.WriteLine(selamlaDegerlerII.isim);
            Console.WriteLine(selamlaDegerlerII.soyisim);

            Tuple<string, string> selamlaDegerler = Selamla();
            Console.WriteLine(selamlaDegerler.Item1);
            Console.WriteLine(selamlaDegerler.Item2);

            Tuple<string, string, int, bool, Araba, string, string> tupleKullanimiI =
            new Tuple<string, string, int, bool, Araba, string, string>("Cengiz", "Atilla", 34, true, new Araba() { }, "İstanbul", "Türkiye");

            Console.WriteLine(tupleKullanimiI.Item2);

            Console.Clear();
            #endregion

            #region Dynamic Kullanımı
            var deger1 = "Cengiz Atilla";
            // deger1 = 1;

            dynamic deger2 = "Cengiz Atilla";
            deger2 = 12;
            deger2 = true;
            deger2 = new
            {
                isim = "Cengiz",
            };

            object o = 12;

            Console.Clear();
            #endregion
        }

        static int Topla(int sayi1, int sayi2)
        {
            //Carp(12, 2);
            return sayi1 + sayi2;
        }

        static int Carpim(int sayi1, int sayi2 = 1)
        {
            return sayi1 * sayi2;
        }

        static Tuple<string, string> Selamla()
        {
            return new Tuple<string, string>("Cengiz", "Atilla");
        }

        static (string isim, string soyisim) SelamlaII()
        {
            return ("Cengiz", "Atilla");
        }
    }
}
