using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.database
{
    public class promosyonSepeti
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        int returnInt;
        object returnObj;

        public promosyonSepeti()
        {
            con = new SqlConnection(connectionStringOlustur());
        }

        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "promosyonSepeti";
            builder.UserID = "sa";
            builder.Password = "1";
            return builder.ConnectionString;
        }

        public void baglantiDurumuAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }

        public int ekleDuzenleSil(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiDurumuAyarla();
            returnInt = cmd.ExecuteNonQuery();
            baglantiDurumuAyarla();
            return returnInt;
        }

        public SqlDataReader liste(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiDurumuAyarla();
            return cmd.ExecuteReader();
        }

        public object kolonGetir(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiDurumuAyarla();
            returnObj = cmd.ExecuteScalar();
            baglantiDurumuAyarla();
            return returnObj;
        }
    }
}
