using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.GUI;

namespace TruongChiDung_2121110102.DAL
{
    public class NhanVienDAL : DBConnection
    {
        public List<NhanVienBEL> ReadNhanVien()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhanVienBEL> lstNhanVien = new List<NhanVienBEL>();

            while (reader.Read())
            {
                NhanVienBEL nhanvien = new NhanVienBEL();
                nhanvien.MaNhanVien = int.Parse(reader["MaNhanVien"].ToString());
                nhanvien.HoTen = reader["HoTen"].ToString();
                nhanvien.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                nhanvien.GioiTinh = reader["GioiTinh"].ToString();
                nhanvien.DiaChi = reader["DiaChi"].ToString();
                lstNhanVien.Add(nhanvien);
            }
            conn.Close();
            return lstNhanVien;
        }
        public void AddNhanVien(NhanVienBEL nhanvien)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi) " +
                                            "VALUES (@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi)", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien",nhanvien.MaNhanVien));
            cmd.Parameters.Add(new SqlParameter("@HoTen", nhanvien.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", nhanvien.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", nhanvien.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nhanvien.DiaChi));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteNhanVien(NhanVienBEL nhanvien)
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand deleteCmd = new SqlCommand("delete from NhanVien where MaNhanVien = @MaNhanVien", conn);

                deleteCmd.Parameters.Add(new SqlParameter("@MaNhanVien", nhanvien.MaNhanVien));
                
                deleteCmd.ExecuteNonQuery();

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditNhanVien(NhanVienBEL nhanvien)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update NhanVien set HoTen=@HoTen , NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi where MaNhanVien=@MaNhanVien ", conn);
            cmd.Parameters.Add(new SqlParameter("@MaNhanVien", nhanvien.MaNhanVien));
            cmd.Parameters.Add(new SqlParameter("@HoTen", nhanvien.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", nhanvien.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", nhanvien.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", nhanvien.DiaChi));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
