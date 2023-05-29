using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHASifrelemeIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string SifrelenecekData = "Efrun Evdi";

            Console.WriteLine(SHA.SHA256Sifrele(SifrelenecekData));

            //Console.WriteLine(SHA.SHA512Sifrele(SifrelenecekData));

        }
    }
}
