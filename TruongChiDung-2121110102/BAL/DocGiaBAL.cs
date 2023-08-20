using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.DAL;

namespace TruongChiDung_2121110102.BAL
{
    public class DocGiaBAL
    {
        DocGiaDAL dgdal = new DocGiaDAL();
        public List<DocGiaBEL> ReadDocGia()
        {
            List<DocGiaBEL> lstDg = dgdal.ReadDocGia();
            return lstDg;
        }
        //public List<DocGiaBEL> Timkiem(DocGiaBEL dg)
        //{
        //    List<DocGiaBEL> LstDG = dgdal.Timkiem(dg);
        //    return LstDG;
        //}
    }

}
