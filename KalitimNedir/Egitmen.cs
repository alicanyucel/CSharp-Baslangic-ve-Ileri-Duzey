using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public class Egitmen : temelTip
    {
        public string brans { get; set; }
        public string bransSeviye { get; set; }

        public DateTime isBaslangicTarih { get; set; }
        public DateTime isBitisTarih { get; set; }
        public int izinGunSayisi { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin yapıcı metotu çalıştı.");
            // IdAtamaIslemi
        }
    }
}
