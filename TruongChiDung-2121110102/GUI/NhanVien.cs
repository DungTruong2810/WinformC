using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongChiDung_2121110102.BAL;
using TruongChiDung_2121110102.BEL;

namespace TruongChiDung_2121110102.GUI
{
    public partial class NhanVien : Form
    {
        NhanVienBAL nvBAL = new NhanVienBAL();
        public NhanVien()
        {
            InitializeComponent();
        }
        private void btadd_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin có đủ hay không
            if (string.IsNullOrEmpty(mnv.Text) || string.IsNullOrEmpty(tnv.Text) || string.IsNullOrEmpty(dc.Text) || (!rbNam.Checked && !rbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem mã nhân viên đã tồn tại chưa
            int maNhanVien = int.Parse(mnv.Text);
            if (NhanVienExists(maNhanVien))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NhanVienBEL nv = new NhanVienBEL();
            nv.MaNhanVien = int.Parse(mnv.Text);
            nv.HoTen = tnv.Text;
            nv.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
            nv.DiaChi = dc.Text;
            if (rbNam.Checked)
            {
                nv.GioiTinh = "Nam";
            }
            else if (rbNu.Checked)
            {
                nv.GioiTinh = "Nữ";
            }
            nvBAL.AddNhanVien(nv);
            QLNV.Rows.Clear();
            List<NhanVienBEL> nslist = nvBAL.ReadNhanVien();
            foreach(NhanVienBEL nv1 in nslist)
            {
                QLNV.Rows.Add(nv1.MaNhanVien, nv1.HoTen, nv1.NgaySinh, nv1.GioiTinh, nv1.DiaChi);

            }

        }
        private bool NhanVienExists(int maNhanVien)
        {
            List<NhanVienBEL> nslist = nvBAL.ReadNhanVien();
            foreach (NhanVienBEL nv1 in nslist)
            {
                if (nv1.MaNhanVien == maNhanVien)
                {
                    return true;
                }
            }
            return false;
        }
        private void btdel_Click(object sender, EventArgs e)
        {
            if (mnv.Text != null)
            {
                NhanVienBEL nv = new NhanVienBEL();
                nv.MaNhanVien = int.Parse(mnv.Text);

                nvBAL.DeleteNhanVien(nv);

                int idx = QLNV.CurrentCell.RowIndex;
                QLNV.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show("khong the xoa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bted_Click(object sender, EventArgs e)
        {

            try
            {
                NhanVienBEL Nv = new NhanVienBEL();
                Nv.MaNhanVien = int.Parse(mnv.Text);
                Nv.HoTen = tnv.Text;
                Nv.NgaySinh = DateTime.Parse(dateTimePicker1.Text);
                Nv.DiaChi = dc.Text;
                if (rbNam.Checked)
                {
                    Nv.GioiTinh = "Nam";
                }
                else if (rbNu.Checked)
                {
                    Nv.GioiTinh = "Nữ";
                }
                nvBAL.EditNhanVien(Nv);
                int idx = QLNV.CurrentCell.RowIndex;
                QLNV.Rows[idx].Cells[0].Value = mnv.Text;
                QLNV.Rows[idx].Cells[1].Value = tnv.Text;
                QLNV.Rows[idx].Cells[2].Value = dateTimePicker1.Text;
                QLNV.Rows[idx].Cells[3].Value = Nv.GioiTinh;
                QLNV.Rows[idx].Cells[4].Value = dc.Text;
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi xảy ra", "thông báo", MessageBoxButtons.OK);
            }
        }
        private void btback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DanhMuc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVienBEL> lstCus = nvBAL.ReadNhanVien();

            foreach (NhanVienBEL muonSach in lstCus)
            {
                QLNV.Rows.Add(muonSach.MaNhanVien, muonSach.HoTen, muonSach.NgaySinh, muonSach.GioiTinh, muonSach.DiaChi);
            }
        }
        string mnv1;
        private void QLNV_SelectionChanged(object sender, EventArgs e)
        {
            if (QLNV.SelectedCells.Count > 0)
            {
                mnv.Text = QLNV.SelectedCells[0].Value?.ToString();
                mnv1 = mnv.Text;
                tnv.Text = QLNV.SelectedCells[1].Value?.ToString();
                dateTimePicker1.Text = QLNV.SelectedCells[2].Value?.ToString();

                if (rbNam.Checked || rbNu.Checked)
                {
                    string genderValue = QLNV.SelectedCells[3].Value?.ToString();

                    if (rbNam.Checked)
                    {
                        rbNam.Text = genderValue;
                    }
                    else if (rbNu.Checked)
                    {
                        rbNu.Text = genderValue;
                    }
                }

                dc.Text = QLNV.SelectedCells[4].Value?.ToString();
            }
            else
            {
                // Xử lý trường hợp khi không có ô nào được chọn trong QLNV
            }


        }



        private void mnv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập là số hoặc ký tự control (chẳng hạn như backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép nhập ký tự khác số
            }
        }

        private void tnv_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tnv_TextChanged(object sender, EventArgs e)
        {
            string inputText = tnv.Text;
            string validInput = string.Empty;
            bool hasInvalidCharacters = false;

            foreach (char c in inputText)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c) || "ÀÁÂÃẠÈÉÊẸÌÍÒÓÔÕỌÙÚÛỤỲÝĐàáâãạèéêẹìíòóôõọùúûụỳýđ".Contains(c))
                {
                    validInput += c;
                }
                else
                {
                    hasInvalidCharacters = true;
                }
            }

            tnv.Text = validInput;
            tnv.SelectionStart = tnv.Text.Length;

            if (hasInvalidCharacters)
            {
                MessageBox.Show("Chỉ được nhập chữ có dấu và dấu cách vào họ tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnv_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
