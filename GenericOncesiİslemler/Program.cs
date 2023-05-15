using GenericOncesiİslemler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOncesiIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add();

            SanalDatabase sanalDatabase = new SanalDatabase();
            sanalDatabase.yeniKayit(1);
            sanalDatabase.yeniKayit(2);
        }
    }
}
