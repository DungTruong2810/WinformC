using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongChiDung_2121110102.BEL;
using TruongChiDung_2121110102.DAL;

namespace TruongChiDung_2121110102.BAL
{
    internal class MuonSachBAL
    {
        MuonSachDAL DAL = new MuonSachDAL();

        public List<MuonSachBEL> ReadMuonSach()
        {
            List<MuonSachBEL> lstms = DAL.ReadMuonSach();
            return lstms;   
        }
        public List<MuonSachBEL> Timkiem(MuonSachBEL cus)
        {
            List<MuonSachBEL> lstCus = DAL.Timkiem(cus);
            return lstCus;
        }
        public void AddMuonSach(MuonSachBEL muonSach)
        {
            DAL.AddMuonSach(muonSach);
        }
        public void DeleteSanPham(MuonSachBEL muonSach)
        {
            DAL.DeleteSanPham(muonSach);
        }
        public void EditMuonSach(MuonSachBEL muonSach)
        {
            DAL.EditMuonSach(muonSach);
        }
        //public List<MuonSachBEL> Timkiem(MuonSachBEL muonSach)
        //{
        //    List<MuonSachBEL> lstDAl = DAL.Timkiem(muonSach);
        //    return lstDAl;
        //}
    }
}
