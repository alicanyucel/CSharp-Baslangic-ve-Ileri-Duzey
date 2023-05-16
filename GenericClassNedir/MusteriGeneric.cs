using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir
{
    public class MusteriGeneric<T>
    {
        public T id { get; set; }
        public T musteriNumarasi { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime DogumTarihi { get; set; }

        public T musteriNumarasiAl()
        {
            return musteriNumarasi;
        }
    }
}
