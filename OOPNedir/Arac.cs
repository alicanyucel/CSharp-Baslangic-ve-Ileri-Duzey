using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYili;
        public decimal Km;
        public int YakitTipi;
        public int VitesTipi;
        public decimal AlisFiyati;
        public decimal SatisFiyati;
        public decimal MaxIndirimTutari;
        public decimal Fiyat;

        public Arac()
        {

        }

        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }

        public Arac(string _marka, string _model, int _modelyili)
        {
            Marka = _marka;
            Model = _model;
            ModelYili = _modelyili;
        }

        public Arac(string _marka, string _model, int _modelyili, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYili = _modelyili;
            this.Km = _km;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yılı {2}", Marka, Model, ModelYili);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyati - MaxIndirimTutari;
            if (_fiyat < fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi yaptınız.");
            }

            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi.");
            }
        }
    }
}
