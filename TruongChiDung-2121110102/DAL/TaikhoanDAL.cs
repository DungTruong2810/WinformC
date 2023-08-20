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
    internal class TaiKhoanDAL : DBConnection
    {
        public List<TaikhoanBEL> ReadTaiKhoan()
    {
        SqlConnection conn = CreateConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from TaiKhoan ", conn);
        SqlDataReader reader = cmd.ExecuteReader();

        List<TaikhoanBEL> lstCus = new List<TaikhoanBEL>();

        while (reader.Read())
        {
            TaikhoanBEL cus = new TaikhoanBEL();
            cus.Id = reader["id"].ToString();
            cus.Tentk = reader["TENTAIKHOAN"].ToString();
            cus.Matkhau = reader["MATKHAU"].ToString();
            cus.Email = reader["EMAIL"].ToString();
            lstCus.Add(cus);
        }
        conn.Close();
        return lstCus;
    }
    public void EditTaikhoan(TaikhoanBEL cus)
    {
        SqlConnection conn = CreateConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand("update TAIKHOAN set MatKhau=@Matkhau where TenTaiKhoan=@TenTaiKhoan and Email=@Email", conn);
        cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", cus.Tentk));
        cmd.Parameters.Add(new SqlParameter("@Matkhau", cus.Matkhau));
        cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));

        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public void DeleteCustomer(CustomerBEL cus)
    {
        SqlConnection conn = CreateConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand("delete from CUSTOMER where id=@id", conn);
        cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public void NewTaiKhoan(TaikhoanBEL cus)
    {
        SqlConnection conn = CreateConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into TAIKHOAN values(@id,@TenTaiKhoan,@Matkhau,@Email)", conn);
        cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
        cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", cus.Tentk));
        cmd.Parameters.Add(new SqlParameter("@Matkhau", cus.Matkhau));
        cmd.Parameters.Add(new SqlParameter("@Email", cus.Email));
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}
}
