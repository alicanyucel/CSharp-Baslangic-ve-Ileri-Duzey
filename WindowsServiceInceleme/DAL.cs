using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceInceleme
{
    public class DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        int ReturnValues;

        public DAL()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB; Initial Catalog=WindowsServisNedir;");
        }

        public int OlayGunluguYeniKayit(string Olay, DateTime OlusturmaTarihi)
        {
            try
            {
                cmd = new SqlCommand("insert into OlayGunlugu (Olay,OlusturmaTarihi) values (@Olay,@OlusturmaTarihi)", con);
                cmd.Parameters.Add("@Olay", SqlDbType.NVarChar).Value = Olay;
                cmd.Parameters.Add("@OlusturmaTarihi", SqlDbType.NVarChar).Value = OlusturmaTarihi;

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return ReturnValues;
        }
    }
}
