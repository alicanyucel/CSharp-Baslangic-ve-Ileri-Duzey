using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWinForm
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public int CariNumarasi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }

        public Musteri()
        {

        }

        public Musteri(Guid ID, int CariNumarasi)
        {
            this.ID = ID;
            this.CariNumarasi = CariNumarasi;
        }

        public Musteri(Guid ID, int CariNumarasi, string Isim, string Soyisim)
        {
            this.ID = ID;
            this.CariNumarasi = CariNumarasi;
            this.Isim = Isim;
            this.Soyisim = Soyisim;
        }

        public void EkranaYaz()
        {
            Console.WriteLine($"ID : {ID.ToString()} - Cari Numarası : {CariNumarasi.ToString()} Isim Soyisim : {Isim} {Soyisim}");
        }

        public void CariNoGuncelle(int YeniCariNumarasi)
        {
            this.CariNumarasi = YeniCariNumarasi;
        }
    }
}
