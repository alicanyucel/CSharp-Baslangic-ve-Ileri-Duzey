using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.entities
{
    public class potansiyelMusteri
    {
        public int id { get; set; }
        public string tcKimlikNumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }
        public int cinsiyet { get; set; }
        public string meslek { get; set; }
        public string emailAdres { get; set; }
        public bool emailBildirimOnay { get; set; }
        public string telefon { get; set; }
        public bool telefonBildirimOnay { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int olusturmaMagaza { get; set; }

    }
}
