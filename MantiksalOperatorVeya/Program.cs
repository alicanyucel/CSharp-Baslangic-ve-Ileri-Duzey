using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalOperatorVeya
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mantıksal veya operatörü ||
            // bool donusDegeri = degisken1 == "admin" && degisken2 == "123"
            /*
             * Sart1      Sart2      Sonuc
             * True       True       True
             * True       False      True
             * False      True       True
             * False      False      False
             */

            string anahtar = "SDFSDGSDGSDGSDFSFA";

            bool geriDonus = anahtar == "SDFSDGSDGSDGSDFSFA" || anahtar == "DKGJSDHGAK" || anahtar == "SDİIOGJSDİOIG" || anahtar == "SDPJGIAİOIDHG";
        }
    }
}
