using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.müsteriNumara = "MSN001";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.emailAdres = "cengiz.atilla@gmail.com";

            sanalDatabase SB = new sanalDatabase();
            MusteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            if (musteriKayitSonuc == MusteriReturnValue.kayitBasarili)
            {

            }

            int enumInt = (int)MusteriReturnValue.kayitBasarisiz;
            Console.WriteLine(enumInt);
        }
    }
}
