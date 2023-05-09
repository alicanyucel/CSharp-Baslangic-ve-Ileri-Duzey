using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    public class Musteri
    {
        /*
         * TcKimlik Numarası
         * İsim
         * Soyisim
         * Cinsiyet
         */

        // Yapıcı Metot CTOR

        public Musteri()
        {
            //TCkimliknumara = "123456791";
        }

        public Musteri(string _TCkimliknumara)
        {
            TCkimliknumara = _TCkimliknumara;
        }

        public Musteri(string _TCkimliknumara, string _isim)
        {
            TCkimliknumara = _TCkimliknumara;
            isim = _isim;
        }

        public Musteri(string _TCkimliknumara, string _isim, string _soyisim)
        {
            TCkimliknumara = _TCkimliknumara;
            isim = _isim;
            soyisim = _soyisim;
        }

        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; // 717770001 : Bay - 717770001 : Bayan

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimliknumara);

            return kontrol;
        }

        internal bool MusteriKontrolDatabase(string tckimliknumarasi)
        {
            // Database gidilir müşterinin tc kimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır...

            return true;
        }
    }
}
