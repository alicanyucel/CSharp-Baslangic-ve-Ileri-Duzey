using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
    public class Musteri : IMusteri
    {
        int _id;
        string _name;
        string _surname;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int kayitDuzenle(int id, string name, string surname)
        {
            Console.WriteLine("Kayıt düzenlendi.");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Kayıt silindi.");
            return 1;
        }

        public int yeniKayit(string name, string surname)
        {
            Console.WriteLine("Kayıt eklendi.");
            return 1;
        }
    }
}
