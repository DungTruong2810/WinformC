using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.DAL;

namespace TruongChiDung_2121110102.BAL
{
    public class TraSachBAL
    {
        TraSachDAL Tsdal = new TraSachDAL();
        public List<TraSachBEL> ReadTraSach()
        {
            List<TraSachBEL> lstTs = Tsdal.ReadTraSach();
            return lstTs;
        }

        public void AddTraSach(TraSachBEL traSach)
        {
            Tsdal.AddTraSach(traSach);
        }
        public void EditTraSach(TraSachBEL traSach)
        {
            Tsdal.EditTraSach(traSach);
        }
        public void DeleteTraSach(TraSachBEL traSach)
        {
            Tsdal.DeleteTraSach(traSach);
        }

    }
}
