using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.WebServisTestConsole.WebServisReferansAdres;

namespace Udemy.WebServisTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServisReferansAdres.WebService1 merhaba = new WebServisReferansAdres.WebService1();
            string donenDeger = merhaba.HelloWorld("Efrun", "Evdi");
            merhaba.MerhabaDunya(new ogrenci()
            {
                id = 1,
                isim = "Efrun",
                soyisim = "Evdi"
            });

            Console.WriteLine(donenDeger);
        }
    }
}
