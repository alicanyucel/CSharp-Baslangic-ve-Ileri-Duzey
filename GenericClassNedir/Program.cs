using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.TcKimlikNumarasi = "12345678901";
            M1.musteriNumarasi = "MS123";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.DogumTarihi = DateTime.Parse("02.11.1984");


            MusteriGeneric<int> musteriGeneric1 = new MusteriGeneric<int>();
            musteriGeneric1.id = 1;
            musteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> musteriGeneric2 = new MusteriGeneric<Guid>();
            musteriGeneric2.musteriNumarasiAl();


        }
    }
}
