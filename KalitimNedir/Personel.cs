using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public class Personel : temelTip
    {
        public DateTime isBaslangicTarih { get; set; }
        public DateTime isBitisTarih { get; set; }
        public int izinGunSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel nesnesinin yapıcı metotu çalıştı.");
        }
    }
}
