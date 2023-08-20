using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.DAL;

namespace TruongChiDung_2121110102.BAL
{
    public class NhanVienBAL
    {
        NhanVienDAL nvDAL = new NhanVienDAL();
        public List<NhanVienBEL> ReadNhanVien()
        {
            List<NhanVienBEL> nvdal = nvDAL.ReadNhanVien();
            return nvdal;
        }
        public void AddNhanVien (NhanVienBEL nhanVien)
        {
            nvDAL.AddNhanVien(nhanVien);
        }
        public void DeleteNhanVien(NhanVienBEL nhanVien)
        {
            nvDAL.DeleteNhanVien(nhanVien);
        }
        public void EditNhanVien(NhanVienBEL nhanVien)
        {
            nvDAL.EditNhanVien(nhanVien);
        }
    }
}
