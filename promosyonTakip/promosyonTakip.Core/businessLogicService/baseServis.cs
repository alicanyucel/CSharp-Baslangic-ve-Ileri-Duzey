using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.businessLogicService
{
    public class baseServis<T>
    {
        public SqlCommand cmd;
        public SqlDataReader reader;
        public int sonuc;
        public object obj;
        public List<T> liste;
        public T data;
    }
}
