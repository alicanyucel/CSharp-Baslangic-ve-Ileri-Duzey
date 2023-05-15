using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    public class Musteri
    {
        #region Field
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string emailAdres { get; set; }
        #endregion

        #region Metot
        public int yeniKayit(Musteri m)
        {
            Console.WriteLine("Database kayıt işlemi tamamlandı");
            return 1;
        }

        public int kayitGunlle(Musteri m)
        {
            Console.WriteLine("Müşteri güncelleme işlemi tamamlandı");
            return 1;
        }

        public int kayitSil(Musteri m)
        {
            Console.WriteLine("Müşteri silme işlemi tamamlandı");
            return 1;
        }
        #endregion
    }
}
