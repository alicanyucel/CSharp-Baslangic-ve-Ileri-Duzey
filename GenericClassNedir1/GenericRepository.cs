using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir1
{
    public class GenericRepository<T> where T : class // T class olmak zorunda
    {
        public GenericRepository()
        {
            // context : EF DBFirst
        }

        public virtual List<T> Getir()
        {
            // Gelen T tipini database üzerinde sorgulamak ve elde etmiş olduğum kayıtları generic koleksiyon olarak bir üst katmana dönmek ...
            return null;
        }

        public virtual void yeniKayitEkle(T data)
        {
            // Bize gelen T tipi içerisindeki bilgiyi T tipinin işaret etmiş olduğu tabloya ekliyoruz.
        }
    }
}
