using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematikselIslemlerDLL;

namespace DLLIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            MatematikselIslemlerDLL.Islemler Islem = new Islemler();
            int Toplam = Islem.Toplama(12, 20);
            Console.WriteLine($"Toplam : {Toplam}");

            Console.ReadLine();
        }
    }
}
