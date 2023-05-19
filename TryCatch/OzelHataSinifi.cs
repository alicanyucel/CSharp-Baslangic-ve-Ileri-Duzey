using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class OzelHataSinifi : Exception
    {
        public OzelHataSinifi()
        {
            Console.WriteLine("Özel hata sınıfı oluştu.");
        }
    }
}
