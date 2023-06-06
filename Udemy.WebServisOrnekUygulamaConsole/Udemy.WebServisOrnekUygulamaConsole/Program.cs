using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.WebServisOrnekUygulamaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adım 1 : Yeni bir ürün ekleme işlemi;

            Random rnd = new Random();
            UrunWebServis.Guvenlik WebServisGuvenlik = new UrunWebServis.Guvenlik();

            WebServisGuvenlik.PrivateValue = rnd.Next(0, int.MaxValue);
            WebServisGuvenlik.TokenTime = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
            WebServisGuvenlik.ClientKey = "E4A2B952-E203-4586-ADC4-D79FE01E3C2F" + WebServisGuvenlik.PrivateValue.ToString() + WebServisGuvenlik.TokenTime;
            WebServisGuvenlik.ClientKey = SHA.SHA256Olustur(WebServisGuvenlik.ClientKey);

            UrunWebServis.UrunServis _WebServis = new UrunWebServis.UrunServis();
            UrunWebServis.OutputType ReturnType = _WebServis.UrunKayitYeni(new UrunWebServis.Urun()
            {
                ID = 1,
                Tanim = "Telefon",
                Aciklama = "Akıllı Telefon",
                StokAdet = 100,
                UrunKimlik = "ABCDEFG"
            }, WebServisGuvenlik);

            Console.ReadLine();
        }
    }
}
