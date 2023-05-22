using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegetaIsımsizMetotKullanimi
{
    class Program
    {
        delegate void EkranaYaz(string Isim, string Soyisim);

        static void Main(string[] args)
        {
            // Var olan bir metodu kullanarak delegate içine ekleme
            EkranaYaz TestI = new EkranaYaz(TestMethod);

            // İsimsiz metot kullanımı
            EkranaYaz TestII = new EkranaYaz(delegate (string Isim, string Soyisim)
            {
                Console.WriteLine($"{Isim} {Soyisim}");
            });

            // Lambda Expression Kullanımı
            EkranaYaz TestIII = (Isim, Soyisim) =>
            {
                Console.WriteLine($"{Isim} {Soyisim}");
            };

            TestI("Cengiz", "Atilla");
            TestII("Mustafa", "Kaya");
            TestIII("Nuran", "Genç");
        }

        static void TestMethod(string Isim, string Soyisim)
        {
            Console.WriteLine($"{Isim} {Soyisim}");
        }
    }
}
