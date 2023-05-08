using System; // Bir kütüphane dosyasını uygulamamızın içerisine eklemektir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotGenelTanim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzun bir şekilde yazım.
            System.Console.WriteLine("Merhaba");

            //using kısmında kütüphane eklenmiş hali ile yazımı
            Console.WriteLine("Merhaba");

            Selamla(); // F11 Selam Metotunun içine girer.

            Ogrenci O1 = new Ogrenci();
            //O1.selamlaOgrenci();
            O1.OgrenciMetot2();

        }

        static void Selamla()
        {
            Console.WriteLine("Selam !");
        }
    }
}
