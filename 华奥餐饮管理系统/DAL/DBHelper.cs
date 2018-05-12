using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        //链接地址
        private static string url = "server=.;uid=sa;pwd=001220;database=EateryDB";

        //增删改
        public static int getExecuteNonQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql,connection);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        //单值查
        public static Object getExecuteScalar(string sql)
        {
            using (SqlConnection connection = new SqlConnection(url))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                return cmd.ExecuteScalar();
            }
        }

        //多查
        public static DataTable getTable(string sql) {
            SqlConnection connection = new SqlConnection(url);
            SqlDataAdapter sda = new SqlDataAdapter(sql,connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
