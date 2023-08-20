using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.BAL;
using TruongChiDung_2121110102.BEL;

namespace TruongChiDung_2121110102.DAL
{
    internal class NhaCungCapDAL : DBConnection
    {
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhaCungCap ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhaCungCapBEL> lstCus = new List<NhaCungCapBEL>();

            while (reader.Read())
            {
                NhaCungCapBEL cus = new NhaCungCapBEL();
                cus.Ma = reader["manhacungcap"].ToString();
                cus.Ten = reader["TenNhaCungCap"].ToString();
                cus.Diachi = reader["DiaChi"].ToString();
                cus.sdt = reader["SoDienThoai"].ToString();
                cus.Email = reader["Email"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
    }
}
