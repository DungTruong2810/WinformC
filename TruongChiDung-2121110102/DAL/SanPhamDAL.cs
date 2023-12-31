﻿using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongChiDung_2121110102.BEL;

namespace TruongChiDung_2121110102.DAL
{
    internal class SanPhamDAL : DBConnection
    {
        public List<SanPhamBEL> ReadSanPham()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  SanPham ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus = new SanPhamBEL();
                cus.Ma = reader["MaSanPham"].ToString();
                cus.Ten = reader["TenSanPham"].ToString();
                cus.Gia = int.Parse(reader["GiaBan"].ToString());
                cus.Soluong = int.Parse(reader["SoLuongTonKho"].ToString());
                cus.Ncc = reader["NhaCungCap"].ToString();
                cus.Anh = reader["Anh"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void EditSanPham(SanPhamBEL cus)
        {

            SqlConnection conn = CreateConnection();    
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("update SanPham set TenSanPham=@TenSanPham ,SoLuongTonKho=@SoLuongTonKho,GiaBan=@GiaBan , NhaCungCap=@NhaCungCap, Anh=@Anh where MaSanPham=@MaSanPham", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", cus.Gia));
            cmd.Parameters.Add(new SqlParameter("@SoLuongTonKho", cus.Soluong));
            cmd.Parameters.Add(new SqlParameter("@NhaCungCap", cus.Ncc));
            cmd.Parameters.Add(new SqlParameter("@Anh", cus.Anh));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteSanPham(SanPhamBEL cus)
        {
            if (string.IsNullOrEmpty(cus.Ma))
            {
                // Xử lý trường hợp khi cus.Ma trống hoặc null
                return;
            }

                    using (SqlConnection conn = CreateConnection())
                    {
                        conn.Open();



                    // Xóa sản phẩm
                    using (SqlCommand deleteCmd = new SqlCommand("delete from SanPham where MaSanPham = @MaSanPham", conn))
                    {
                        deleteCmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
                        deleteCmd.ExecuteNonQuery();

                        conn.Close();
                    }

                }
        }



        public void AddSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into SanPham values(@TenSanPham,@GiaBan,@SoLuongTonKho,@NhaCungCap,@Anh)", conn);
            cmd.Parameters.Add(new SqlParameter("@TenSanPham", cus.Ten));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", cus.Gia));
            cmd.Parameters.Add(new SqlParameter("@SoLuongTonKho", cus.Soluong));
            cmd.Parameters.Add(new SqlParameter("@NhaCungCap", cus.Ncc));
            cmd.Parameters.Add(new SqlParameter("@Anh", cus.Anh));
            cmd.ExecuteNonQuery();
            conn.Close();
  
        }
        public List<SanPhamBEL> Timkiem(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham where MaSanPham LIKE '%' + @MaSanPham + '%' ", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus1 = new SanPhamBEL();
                cus1.Ma = reader["Masanpham"].ToString();
                cus1.Ten = reader["TenSanPham"].ToString();
                cus1.Gia = int.Parse(reader["GiaBan"].ToString());
                cus1.Soluong = int.Parse(reader["SoLuongTonKho"].ToString());
                cus1.Ncc = reader["NhaCungCap"].ToString();
                cus1.Anh = reader["Anh"].ToString();
                lstCus.Add(cus1);
            }
            conn.Close();
            return lstCus;
        }
        public List<SanPhamBEL> Timkiem1(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham where MaSanPham = @MaSanPham ", conn);
            cmd.Parameters.Add(new SqlParameter("@MaSanPham", cus.Ma));
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus1 = new SanPhamBEL();
                cus1.Ma = reader["Masanpham"].ToString();
                cus1.Ten = reader["TenSanPham"].ToString();
                cus1.Gia = int.Parse(reader["GiaBan"].ToString());
                cus1.Soluong = int.Parse(reader["SoLuongTonKho"].ToString());
                cus1.Ncc = reader["NhaCungCap"].ToString();
                cus1.Anh = reader["Anh"].ToString();
                lstCus.Add(cus1);
            }
            conn.Close();
            return lstCus;
        }

    }
}