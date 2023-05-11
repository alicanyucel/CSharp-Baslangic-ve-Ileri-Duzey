using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public class temelTip
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarası { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime güncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public temelTip()
        {
            Console.WriteLine("Temel tip nesnesinin yapıcı metotu çalıştı.");
            IdAtamaIslemi();
        }

        private void IdAtamaIslemi()
        {
            Random random = new Random();
            this.id = random.Next(1000, 9000);
        }
    }
}
