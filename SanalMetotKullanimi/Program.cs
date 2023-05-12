using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.EkranaYaz("Hangisi"); // Urun

            Urun U1 = new Urun();
            U1.EkranaYaz("Merhaba");

            baseClass B1 = new baseClass();
            B1.EkranaYaz("Merhaba");

            /*
             * virtual anahtar kelimesi, bir sınıfın bir yöntemini türetilmiş sınıflar tarafından yeniden uygulanabilen bir sanal yöntem haline getirir. Bu, üst sınıftaki sanal yöntemin, alt sınıflar tarafından yeniden uygulanmasına izin verir. Bir yöntem virtual olarak işaretlenirse, alt sınıflar, üst sınıfın aynı ad ve imzaya sahip bir yöntemini override anahtar kelimesini kullanarak geçersiz kılabilirler.
             * 
             * override anahtar kelimesi, bir alt sınıftaki yöntemi, üst sınıftaki sanal yöntemi geçersiz kılacak şekilde işaretler. Bir yöntem override olarak işaretlenirse, alt sınıf, aynı ad, parametreler ve geri dönüş türüne sahip bir yöntemi uygulamak zorundadır.
             * 
             * virtual ve override anahtar kelimeleri, C# programlama dilinde çok biçimlilik ve kalıtım kavramlarına dayalı olarak nesne yönelimli programlamada önemli bir yer tutarlar. Bu anahtar kelimeler, kodun daha esnek ve yeniden kullanılabilir olmasını sağlar ve aynı zamanda sınıf hiyerarşisindeki yöntemlerin davranışını değiştirmeye olanak tanır.
             */
        }
    }
}
