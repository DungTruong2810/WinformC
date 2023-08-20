using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TruongChiDung_2121110102.BAL;
using TruongChiDung_2121110102.BEL;

namespace TruongChiDung_2121110102.DAL
{
    public class DocGiaDAL : DBConnection
    {
        public List<DocGiaBEL> ReadDocGia()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  DocGia ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<DocGiaBEL> lstTs = new List<DocGiaBEL>();

            while (reader.Read())
            {
                DocGiaBEL ts = new DocGiaBEL();
                ts.MaDocGia = int.Parse(reader["MaDocGia"].ToString());
                ts.HoTen = reader["HoTen"].ToString();
                ts.DiaChi = reader["DiaChi"].ToString();
                ts.GioiTinh = reader["GioiTinh"].ToString();
                lstTs.Add(ts);
            }
            conn.Close();
            return lstTs;
        }
        //public List<DocGiaBEL> Timkiem(DocGiaBEL dg)
        //{
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("select * from DocGia where MaDocGia LIKE '%' + @MaDocGia + '%' ", conn);
        //    cmd.Parameters.Add(new SqlParameter("@MaDocGia", dg.MaDocGia));
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    List<DocGiaBEL> lstCus = new List<DocGiaBEL>();

        //    while (reader.Read())
        //    {
        //        DocGiaBEL dg1 = new DocGiaBEL();
        //        dg1.MaDocGia = int.Parse(reader["MaDocGia"].ToString());
        //        dg1.HoTen = reader["TenDocGia"].ToString();                
        //        lstCus.Add(dg);
        //    }
        //    conn.Close();
        //    return lstCus;
        //}
    }

}
