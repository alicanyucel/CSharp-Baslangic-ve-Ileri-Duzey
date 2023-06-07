using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.entities
{
    public class sistemMagaza
    {
        public int id { get; set; }
        public string tanim { get; set; }
        public string adres { get; set; }
        public string yetkiliKisi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
