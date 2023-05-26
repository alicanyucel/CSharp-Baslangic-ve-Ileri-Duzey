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
                ConstructorInfo[] CTORS = item.GetConstructors(); // ifadesi, belirtilen bir nesnenin (türün) tüm yapıcılarını (constructors) döndüren bir yöntem çağrısıdır.
                for (int i = 0; i < CTORS.Length; i++)
                {
                    Console.WriteLine(CTORS[i].ToString());
                }

                Console.Clear();

                PropertyInfo[] PRP = item.GetProperties(); //  belirtilen bir nesnenin (türün) tüm özelliklerini (properties) döndüren bir yöntem çağrısıdır.
                for (int i = 0; i < PRP.Length; i++)
                {
                    Console.WriteLine($"Namespace : {item.Namespace} Isim : {PRP[i].Name} Public : {item.IsPublic} Tam Adı : {item.FullName}");
                }

                Console.Clear();

                MethodInfo[] MTH = item.GetMethods(); //  belirtilen bir nesnenin (türün) tüm metotlarını (methods) döndüren bir yöntem çağrısıdır.
                for (int i = 0; i < MTH.Length; i++)
                {
                    Console.WriteLine($"Method Adı : {MTH[i].Name}");
                }

                Console.ReadLine();
            }
        }
    }
}
