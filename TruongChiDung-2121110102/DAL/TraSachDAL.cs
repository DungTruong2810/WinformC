using DocumentFormat.OpenXml.Spreadsheet;
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
    public class TraSachDAL : DBConnection
    {
        public List<TraSachBEL> ReadTraSach()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  TraSach ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<TraSachBEL> lstTs = new List<TraSachBEL>();

            while (reader.Read())
            {
                TraSachBEL ts = new TraSachBEL();
                ts.MaPhieuTra =int.Parse(reader["MaPhieuTra"].ToString());
                ts.MaDocGia = int.Parse(reader["MaDocGia"].ToString());
                ts.MaSanPham = reader["MaSanPham"].ToString();
                ts.NgayTra = DateTime.Parse(reader["NgayTra"].ToString());
                lstTs.Add(ts);
            }
            conn.Close();
            return lstTs;
        }
        public void EditTraSach(TraSachBEL traSach)
        {

            SqlConnection conn = CreateConnection();
            conn.Open();
           
            SqlCommand cmd = new SqlCommand("update TraSach set MaDocGia=@MaDocGia ,MaSanPham=@MaSanPham,NgayTra=@NgayTra where MaPhieuTra=@MaPhieuTra", conn);
            cmd.Parameters.AddWithValue("@MaPhieuTra", traSach.MaPhieuTra);
            cmd.Parameters.AddWithValue("@MaDocGia", traSach.MaDocGia);
            cmd.Parameters.AddWithValue("@MaSanPham", traSach.MaSanPham);
            cmd.Parameters.AddWithValue("@NgayTra", traSach.NgayTra);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void AddTraSach(TraSachBEL traSach)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            // Kiểm tra ràng buộc trùng ID trước khi thêm
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM TraSach WHERE MaPhieuTra = @MaPhieuTra", conn);
            checkCmd.Parameters.AddWithValue("@MaPhieuTra", traSach.MaPhieuTra);
            int existingCount = (int)checkCmd.ExecuteScalar();

            if (existingCount > 0)
            {
                // Thực hiện xử lý khi đã tồn tại ID
                // Ví dụ: thông báo lỗi cho người dùng
                Console.WriteLine("Mã phiếu trả đã tồn tại trong cơ sở dữ liệu.");
            }
            else
            {
                // Thêm dữ liệu mới khi không có ràng buộc trùng ID
                SqlCommand cmd = new SqlCommand("INSERT INTO TraSach (MaPhieuTra, MaDocGia, MaSanPham, NgayTra) " +
                                                "VALUES (@MaPhieuTra, @MaDocGia, @MaSanPham, @NgayTra)", conn);

                cmd.Parameters.AddWithValue("@MaPhieuTra", traSach.MaPhieuTra);
                cmd.Parameters.AddWithValue("@MaDocGia", traSach.MaDocGia);
                cmd.Parameters.AddWithValue("@MaSanPham", traSach.MaSanPham);
                cmd.Parameters.AddWithValue("@NgayTra", traSach.NgayTra);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Thêm dữ liệu thành công.");
            }

            conn.Close();
        }

        public void DeleteTraSach (TraSachBEL traSach)
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand deleteCmd = new SqlCommand("delete from TraSach where MaPhieuTra = @MaPhieuTra", conn);

                deleteCmd.Parameters.Add(new SqlParameter("@MaPhieuTra", traSach.MaPhieuTra));
                deleteCmd.ExecuteNonQuery();

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
