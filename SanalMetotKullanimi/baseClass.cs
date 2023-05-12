using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanimi
{
    public class baseClass
    {
        public virtual void EkranaYaz(string data)
        {
            Console.WriteLine(data);
        }

        public baseClass()
        {
            Console.WriteLine("Base Class");
        }
    }
}
