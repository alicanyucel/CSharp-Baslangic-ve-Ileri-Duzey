using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriAdres
    {
        public string adresTip { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Müşteri adres yapıcı metot çalıştı...");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTestMetot");
        }
    }
}
