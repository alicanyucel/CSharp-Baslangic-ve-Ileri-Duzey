using MatematikselIslemlerDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MatematikselIslemlerDLL.Islemler Islem = new MatematikselIslemlerDLL.Islemler();
            int Sonuc = Islem.Cikartma(20, 10);
            Console.WriteLine(Sonuc);

            Console.ReadLine();
        }
    }
}
