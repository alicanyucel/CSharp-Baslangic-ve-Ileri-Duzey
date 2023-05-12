using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object => ToString();
            /*
             * Musteri M1 = new Musteri ();
             * Object => Musteri
             *           M1.ToString();
             *           
             * Namespace.Musteri 
             * 
             */

            Musteri M1 = new Musteri();
            M1.isim = "Cengiz";
            M1.soyisim = "Atiila";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj); // SanalMetotNedir.Musteri
        }
    }
}
