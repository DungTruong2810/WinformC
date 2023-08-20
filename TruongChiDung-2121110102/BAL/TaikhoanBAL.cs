using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.DAL;

namespace TruongChiDung_2121110102.BAL
{
    public class TaikhoanBAL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();
        public List<TaikhoanBEL> ReadTaiKhoan()
        {
            List<TaikhoanBEL> lstCus = dal.ReadTaiKhoan();
            return lstCus;
        }

        public void NewTaiKhoan(TaikhoanBEL cus)
        {
            dal.NewTaiKhoan(cus);
        }
        public void EditTaikhoan(TaikhoanBEL cus)
        {
            dal.EditTaikhoan(cus);
        }
    }
}
