using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static : Nesne örneği alınmadan ulaşabildiğimiz metot, field sınıf... olabilir.
            // Tip M1 = new Tip();
            // Tip.

            // Stack bölge içerisinde pointerımız oluştu.
            StaticOgrenci O1 = new StaticOgrenci();

            // Stack bölgede pointer oluştuğu zamamn static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field, metot static dediğimiz bölgede oluşturuldu.
            StaticOgrenci.Test2();

            O1 = new StaticOgrenci();
            // Stack bölgede pointer => kendisini heap bölgede tamamladı.. Static olmayan tanımlarını tamamladı...
            O1.Test1(); // Nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabildim.


            /* Static Kavramı gerçek hayatta nerelerde kullanılır...
             * 
             * 1 - Helper.cs => Kontroller
             * 2 - Oluşturmuş olduğumuz nesnemiz => Bağımlılığı farklı classlara olduğu için ( proje içerisinde özel olduğu için ) nesne içerisinde static metot tanımları yapılır. 
             * 3 - Class içerisinde bir field ( static ) tanımı yapar ilgili field içerisine bir değer ataması yaparız. Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır değerimizi okuruz.
             * 4 - [ Uygulama ] => [ ozelHelper ] => [ DLL ] 
             * 
             */
        }
    }
}
