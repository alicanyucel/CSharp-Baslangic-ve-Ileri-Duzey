using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.entities
{
   public class promosyonUrun
    {
        public int id { get; set; }
        public string tanim { get; set; }
        public string aciklama { get; set; }
        public DateTime gecerlilikTarih { get; set; }
        public bool kullanimDurum { get; set; }
    }
}
