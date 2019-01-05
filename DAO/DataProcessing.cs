using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKhamTuNhan.DAO
{
    public class DataProcessing
    {
        public DataTable Load(string sql)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=qlphongmachtu;Integrated Security=true");
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Execute(string sql)
        {
            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=qlphongmachtu;Integrated Security=true");
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();

            int kq = cmd.ExecuteNonQuery();

            connection.Close();

            return kq;
        }
    }
}
