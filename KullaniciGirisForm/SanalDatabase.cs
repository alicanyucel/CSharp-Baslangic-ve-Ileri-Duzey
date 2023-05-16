using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisForm
{
    public class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();

        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                id = 1,
                isim = "Cengiz",
                soyisim = "Atilla",
                kullaniciAdi = "cengiz.atilla",
                sifre = "1",
                aciklama = "Cengiz Atilla kullanıcı bilgisi"
            });

            KullaniciTablo.Add(new Kullanici()
            {
                id = 2,
                isim = "Efrun",
                soyisim = "Evdi",
                kullaniciAdi = "efrun.evdi",
                sifre = "2",
                aciklama = "Efrun Evdi kullanıcı bilgisi"
            });
        }
    }
}
