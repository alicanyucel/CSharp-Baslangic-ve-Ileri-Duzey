using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerAlistirma3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru 1 : String olarak verilen değeri bool tipini dönüştürün.
            string metin1 = "True";
            bool sb1 = bool.Parse(metin1);
            bool sb2 = Convert.ToBoolean(metin1);

            // Soru 2 : Int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştürün.
            int s1 = 100;
            byte byteDegisken = (byte)s1;
            float floatDegisken = s1;

            // Soru 3 : Byte değişken içerisinde olan tipi Decimal değişken tipine dönüştürün.
            byte b1 = 10;
            decimal d1 = b1;
        }
    }
}
