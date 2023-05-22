using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTeknolojisi
{
    public class Musteri
    {
        public int musteriNumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarihi { get; set; }

        public string ulke { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }

        public string emailAdres { get; set; }
        public string telefonNumara { get; set; }
    }
}
