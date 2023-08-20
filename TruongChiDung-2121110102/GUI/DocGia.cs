using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongChiDung_2121110102.BAL;
using TruongChiDung_2121110102.BEL;

namespace TruongChiDung_2121110102.GUI
{
    public partial class DocGia : Form
    {
        TraSachBAL tsBal = new TraSachBAL();
        MuonSachBAL msBAL = new MuonSachBAL();
        public DocGia()
        {
            InitializeComponent();
        }

        private void docgiatest_Load(object sender, EventArgs e)
        {
            List<TraSachBEL> lstCus = tsBal.ReadTraSach();

            foreach (TraSachBEL traSach in lstCus)
            {
                dgvTS.Rows.Add(traSach.MaPhieuTra, traSach.MaDocGia, traSach.MaSanPham, traSach.NgayTra);
            }
            List<MuonSachBEL> lstCus2 = msBAL.ReadMuonSach();

            foreach (MuonSachBEL muonSach in lstCus2)
            {
                dgvms.Rows.Add(muonSach.MaPhieuMuon, muonSach.TenDocGia, muonSach.SoLuong, muonSach.NgayMuon);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DanhMuc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        //private void tbID_TextChanged(object sender, EventArgs e)
        //{
        //    dgvms.Rows.Clear();
        //    DocGiaBEL dg = new DocGiaBEL();
        //    dg.MaDocGia = search.Text;
        //    List<DocGiaBEL> lstCus = msBAL.Timkiem(cus);
        //    foreach (DocGiaBEL c in lstCus)
        //    {
        //        dgvms.Rows.Add(c.m, c.Ten, c.Soluong, c.Gia, c.Ncc, c.Anh);
        //    }
        //}
    }
}
