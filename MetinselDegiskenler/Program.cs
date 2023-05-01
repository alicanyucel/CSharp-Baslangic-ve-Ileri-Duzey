using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinselDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string isimSoyisim = "Cengiz Atilla";
            Console.WriteLine(isimSoyisim);

            isimSoyisim = "Mustafa Taş";
            Console.WriteLine(isimSoyisim);

            string buyukKarakter = isimSoyisim.ToUpper();
            string kucukKarakter = isimSoyisim.ToLower();
            string belirliBirBolum = isimSoyisim.Substring(2, 4);
        }
    }
}
