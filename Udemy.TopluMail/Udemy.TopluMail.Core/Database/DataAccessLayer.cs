using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.TopluMail.Core.Database
{
    public class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            con = new SqlConnection("Data Source = (localdb)\\MSSQLLOCALDB; Initial Catalog = Udemyyy;");
        }
    }
}
