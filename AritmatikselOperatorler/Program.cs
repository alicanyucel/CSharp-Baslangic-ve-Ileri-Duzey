using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toplama Operatörü 
            // + 
            // int + int ( Toplama işlemi yapar ) 

            int s1 = 10;
            int s2 = 15;
            int toplamInt = s1 + s2;

            byte s3 = 10;
            byte s4 = 10;
            int toplamByte = s3 + s4;

            // string + int ( string )

            string metin1 = "Merhaba ";
            int s5 = 10;
            string toplamStr1 = metin1 + s5;

            // int + string ( string )

            string toplamStr2 = s5 + metin1;

            // string + string ( string )

            string metin2 = " Dünya";
            string toplamStr3 = metin1 + metin2;
        }
    }
}
