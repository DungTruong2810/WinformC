using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.DAL;

namespace TruongChiDung_2121110102.BAL
{
    public class NhaCungCapBAL
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            List<NhaCungCapBEL> lstCus = dal.ReadNhaCungCap();
            return lstCus;
        }
    }
}
