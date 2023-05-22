using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNedir
{
    class Program
    {
        delegate void MatematikselIslemler(int Sayi1, int Sayi2);

        static void Toplama(int Sayi1, int Sayi2)
        {
            int Sonuc = Sayi1 + Sayi2;
            Console.WriteLine("Toplam işleminin sonucu = {0}", Sonuc);
        }

        static void Cikartma(int Sayi1, int Sayi2)
        {
            int Sonuc = Sayi1 - Sayi2;
            Console.WriteLine("Toplam işleminin sonucu = {0}", Sonuc);
        }

        static void Carpma(int Sayi1, int Sayi2)
        {
            int Sonuc = Sayi1 * Sayi2;
            Console.WriteLine("Toplam işleminin sonucu = {0}", Sonuc);
        }

        static void Main(string[] args)
        {
            //Toplama(10, 20);
            //Cikartma(20, 2);
            //Carpma(20, 2);

            MatematikselIslemler M1 = new MatematikselIslemler(Toplama);
            M1 += Cikartma;
            M1 += Carpma;

            // M1.Invoke(30, 2);

            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();

            foreach (var item in IsaretEdilenMetotlar) // Methodları ekrana yazdırdık
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Carpma;
            foreach (var item in M1.GetInvocationList()) // Methodları ekrana yazdırdık
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Cikartma; // İşaret etmeyi kaldırdık

            foreach (var item in M1.GetInvocationList()) // Methodları ekrana yazdırdık
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 += Carpma; // İşaret ettirdik

            foreach (var item in M1.GetInvocationList()) // Methodları ekrana yazdırdık
            {
                Console.WriteLine(item.Method.Name);
            }

            Console.ReadLine();
        }
    }
}
