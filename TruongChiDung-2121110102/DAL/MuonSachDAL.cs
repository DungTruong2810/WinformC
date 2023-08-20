using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.GUI;
using TruongChiDung_2121110102.BEL;
using DocumentFormat.OpenXml.Office.Word;
using System.Windows.Forms;
using System.Globalization;

namespace TruongChiDung_2121110102.DAL
{
    public class MuonSachDAL : DBConnection
    {
        public List<MuonSachBEL> Timkiem(MuonSachBEL muonSach)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham where MaSanPham = @MaPhieuMuon  ", conn);
            cmd.Parameters.Add(new SqlParameter("@MaPhieuMuon", muonSach.MaPhieuMuon));
            SqlDataReader reader = cmd.ExecuteReader();

            List<MuonSachBEL> lstCus = new List<MuonSachBEL>();

            while (reader.Read())
            {
                MuonSachBEL cus1 = new MuonSachBEL();
                muonSach.MaPhieuMuon = int.Parse(reader["MaPhieuMuon"].ToString());
                muonSach.TenDocGia = reader["TenDocGia"].ToString();
                muonSach.MaSanPham = int.Parse(reader["MaSanPham"].ToString());
                muonSach.SoLuong = int.Parse(reader["SoLuong"].ToString());
                muonSach.NgayMuon = DateTime.Parse(reader["NgayMuon"].ToString());
                lstCus.Add(cus1);
            }
            conn.Close();
            return lstCus;
        }
        public List<MuonSachBEL> ReadMuonSach()
        {

                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MuonSach", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<MuonSachBEL> lstMuonSach = new List<MuonSachBEL>();

            while (reader.Read())
            {
                MuonSachBEL muonSach = new MuonSachBEL();
                muonSach.MaPhieuMuon = int.Parse(reader["MaPhieuMuon"].ToString());
                muonSach.TenDocGia = reader["TenDocGia"].ToString();
                muonSach.MaSanPham = int.Parse(reader["MaSanPham"].ToString());
                muonSach.SoLuong = int.Parse(reader["SoLuong"].ToString());
                muonSach.NgayMuon = DateTime.Parse(reader["NgayMuon"].ToString());
                //muonSach.NgayHenTra= DateTime.Parse(reader["ngayHenTra"].ToString());

                lstMuonSach.Add(muonSach);
            }
            conn.Close();
            return lstMuonSach;
        }

        public void AddMuonSach(MuonSachBEL muonSach)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO MuonSach (MaPhieuMuon, MaSanPham, NgayMuon, SoLuong, TenDocGia) " +
                                            "VALUES (@MaPhieuMuon,  @MaSanPham, @NgayMuon, @SoLuong, @TenDocGia)", conn);

            cmd.Parameters.AddWithValue("@MaPhieuMuon", muonSach.MaPhieuMuon);
            cmd.Parameters.AddWithValue("@TenDocGia", muonSach.TenDocGia);
            cmd.Parameters.AddWithValue("@MaSanPham", muonSach.MaSanPham);
            cmd.Parameters.AddWithValue("@SoLuong", muonSach.SoLuong);
            cmd.Parameters.AddWithValue("@NgayMuon", muonSach.NgayMuon);
            //cmd.Parameters.AddWithValue("@NgayHenTra", muonSach.NgayHenTra);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteSanPham(MuonSachBEL muonSach)
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand deleteCmd = new SqlCommand("delete from MuonSach where MaPhieuMuon = @MaPhieuMuon", conn);
                    
                    deleteCmd.Parameters.Add(new SqlParameter("@MaPhieuMuon", muonSach.MaPhieuMuon));
                    deleteCmd.ExecuteNonQuery();

                    conn.Close();


                }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditMuonSach(MuonSachBEL muonSach)
        {
            try
            {
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update MuonSach set TenDocGia=@TenDocGia,NgayMuon=@NgayMuon,SoLuong=@SoLuong where MaPhieuMuon=@MaPhieuMuon ", conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", muonSach.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@TenDocGia", muonSach.TenDocGia);
            cmd.Parameters.AddWithValue("@SoLuong", muonSach.SoLuong);
            cmd.Parameters.AddWithValue("@NgayMuon", muonSach.NgayMuon);
                //cmd.Parameters.AddWithValue("@NgayHenTra", muonSach.NgayHenTra);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
           catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public List<MuonSachBEL> Timkiem(MuonSachBEL muonSach)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("select * from MuonSach where MaPhieuMuon LIKE '%' + @MaPhieuMuon + '%' ", conn);
        //    cmd.Parameters.Add(new SqlParameter("@MaPhieuMuon", muonSach.MaPhieuMuon));
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    List<MuonSachBEL> lstDAL = new List<MuonSachBEL>();

        //    while (reader.Read())
        //    {
        //        MuonSachBEL DAl = new MuonSachBEL();
        //        DAl.MaPhieuMuon = int.Parse(reader["MaPhieuMuon"].ToString());
        //        DAl.MaDocGia = int.Parse(reader["MaDocGia"].ToString());
        //        DAl.TenDocGia = reader["TenDocGia"].ToString();
        //        DAl.SoLuong = int.Parse(reader["SoLuong"].ToString());
        //        DAl.NgayMuon =DateTime.Parse( reader["NgayMuon"].ToString());
        //        lstDAL.Add(DAl);
        //    }
        //    conn.Close();
        //    return lstDAL;
        //}
    }
}
