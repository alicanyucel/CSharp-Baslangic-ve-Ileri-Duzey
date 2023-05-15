using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOncesiİslemler
{
    public class SanalDatabase
    {
        private ArrayList list = new ArrayList();

        public SanalDatabase()
        {
            list = new ArrayList();
        }

        public void yeniKayit(int data)
        {
            list.Add(data);
        }
    }
}
