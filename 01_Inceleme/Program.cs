using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\UdemyLibrary\bin\Debug\netstandard2.0

            Assembly Lib = Assembly.LoadFile(@"C:\Users\efrun\source\repos\C#-Baslangic-ve-Ileri-Duzey\UdemyLibrary\bin\Debug\netstandard2.0\UdemyLibrary.dll");
            Type[] TP = Lib.GetTypes();

            foreach (Type item in TP)
            {
                ConstructorInfo[] CTORS = item.GetConstructors();
                for (int i = 0; i < CTORS.Length; i++)
                {
                    Console.WriteLine(CTORS[i].ToString());
                }

                PropertyInfo[] PRP = item.GetProperties();
                for (int i = 0; i < PRP.Length; i++)
                {
                    Console.WriteLine($"Namespace : {item.Namespace} Isim : {PRP[i].Name} Public : {item.IsPublic} Tam Adı : {item.FullName}");
                }
                Console.ReadLine();
            }
        }
    }
}
