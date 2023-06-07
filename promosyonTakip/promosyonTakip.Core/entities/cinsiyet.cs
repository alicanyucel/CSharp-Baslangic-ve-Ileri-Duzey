using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.entities
{
    public class cinsiyet
    {
        public int id { get; set; }
        public string tanim { get; set; }

        public override string ToString()
        {
            return tanim;
        }
    }
}
