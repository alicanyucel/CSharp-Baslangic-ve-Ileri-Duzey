using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.name = "Efrun";
            M1.surname = "Evdi";
            M1.emailAdres = "efrunevdi@gmail.com";

            int sonuc = M1.yeniKayit(M1);
            if (sonuc > 0)
            {
                Console.WriteLine("Database yeni kayıt eklendi.");
            }

            Ogrenci O1 = new Ogrenci();
            O1.id = 1;
            O1.yeniKayit(O1);
        }
    }
}
