using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxInceleme
{
    public class Urun
    {
        public int id { get; set; }
        public string urunResim { get; set; }
        public string urunAdi { get; set; }
        public string urunKategori { get; set; }
        public int stokAdet { get; set; }
        public string yazar { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return urunAdi;
        }
    }
}
