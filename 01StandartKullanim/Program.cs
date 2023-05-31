using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01StandartKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            BLL.OgrenciYeniKayit("Cengiz", "Atilla", "11B");
        }
    }
}
