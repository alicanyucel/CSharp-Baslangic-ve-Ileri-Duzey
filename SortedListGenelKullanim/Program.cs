using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList(); // Değerleri Key değerine göre sıralar.

            sortedList.Add(100, "Yüz");
            sortedList.Add(90, "Doksan");
            sortedList.Add(1, "Bir");
            sortedList.Add(9000, "Dokuzbin");
            // sortedList.Add("A", "B"); Hata olur ya sayı oacak ya da string
        }
    }
}
