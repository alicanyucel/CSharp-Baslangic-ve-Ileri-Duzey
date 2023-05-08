using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack S1 = new Stack(); // Son giren ilk çıkar

            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object O1 = S1.Pop(); // Değeri gönderip siler
            object O2 = S1.Peek(); // Değeri gönderip silmez.
        }
    }
}
