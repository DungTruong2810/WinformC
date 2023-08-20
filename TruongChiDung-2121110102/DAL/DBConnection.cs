using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongChiDung_2121110102.DAL
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection();
        public SqlConnection CreateConnection()
        {
            conn.ConnectionString = @"Data Source= LAPTOP-I0VTS5J2\SQLEXPRESS  ;Initial Catalog= QLSACH1 ; User Id=sa; Password=sa";
            return conn;
        }
        public DataTable GetData(string sql)
        {

            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(rs);
            return rs;
        }
    }
}
