using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKatmanli_Mimari_Inceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            // UI: UserPreferenceCategory Interface

            BusinessLogicLayer BLL = new BusinessLogicLayer();
            int EKS = BLL.VeriKaydet(1, "Cengiz", "Atilla"); // string.Empty ile işlem başarısız yazdı

            if (EKS > 0)
            {
                Console.WriteLine("İşlem başarılı");
            }

            else
            {
                Console.WriteLine("İşlem başarısız");
            }

            Console.ReadLine();
        }
    }
}
