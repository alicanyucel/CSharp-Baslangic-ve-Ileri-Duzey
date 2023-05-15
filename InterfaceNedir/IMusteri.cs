using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNedir
{
    public interface IMusteri
    {
        //public IMusteri()
        //{

        //} interface içinde yapıcı metot kullanılmaz ... 

        /* Field
         * Metot
         * Delegate
         * vb..
         */

        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }

        int yeniKayit(string name, string surname);
        int kayitDuzenle(int id, string name, string surname);
        int kayitSil(int id);
    }
}
