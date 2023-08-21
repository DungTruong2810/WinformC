using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongChiDung_2121110102.BEL;
using System.IO;
using TruongChiDung_2121110102.DAL;
using TruongChiDung_2121110102.BAL;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace TruongChiDung_2121110102.GUI
{
    public partial class MuonSach : Form
    {
        string nameimg;
        PictureBox pb = new PictureBox();
        MuonSachBAL msBAL = new MuonSachBAL();
        MuonSachBAL msBAL1 = new MuonSachBAL();
        SanPhamBAL bal= new SanPhamBAL();
        public MuonSach()
        {
            
            InitializeComponent();
        }
        private void FillComboBox()
        {
            using (SqlConnection connection = CreateConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT DISTINCT MaSanPham FROM SanPham", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MaSanPham = reader["MaSanPham"].ToString();
                                comboBox2.Items.Add(MaSanPham);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-I0VTS5J2\SQLEXPRESS;Initial Catalog=QLSACH1;User Id=sa;Password=sa";
            return conn;
        }
        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DanhMuc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        private void MS_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu trước khi thêm
            if (string.IsNullOrWhiteSpace(Mpm.Text) || string.IsNullOrWhiteSpace(Tdg.Text) || string.IsNullOrWhiteSpace(MS.Text) || string.IsNullOrWhiteSpace(sl.Text) || string.IsNullOrWhiteSpace(dateTimePicker2.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cho mượn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm nếu thông tin không đủ
            }

            if (IsMaPhieuMuonExist(Mpm.Text))
            {
                MessageBox.Show("Mã Phiếu Mượn đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm nếu mã sản phẩm đã tồn tại
            }

            MuonSachBEL muonSach = new MuonSachBEL();
            muonSach.MaPhieuMuon = int.Parse(Mpm.Text);
            muonSach.TenDocGia = Tdg.Text;
            muonSach.MaSanPham = int.Parse(comboBox2.Text);
            muonSach.SoLuong = int.Parse(sl.Text);  
            muonSach.NgayMuon = DateTime.Parse(dateTimePicker2.Text);

            // Lấy số lượng tồn kho
            int soLuongTonKho = int.Parse(textBox1.Text);

            // Kiểm tra số lượng tồn kho trước khi thêm
            if (muonSach.SoLuong > soLuongTonKho)
            {
                MessageBox.Show("Không đủ sách mượn. Vui lòng nhập lại số lượng.", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // Thực hiện thêm và cập nhật số lượng tồn kho
            msBAL.AddMuonSach(muonSach);
            dsm1.Rows.Add(muonSach.MaPhieuMuon, muonSach.TenDocGia, muonSach.MaSanPham, muonSach.SoLuong, muonSach.NgayMuon);
            int soLuongConLai = soLuongTonKho - muonSach.SoLuong;
            textBox1.Text = soLuongConLai.ToString();
            MessageBox.Show("Mượn thành công", "Thông báo", MessageBoxButtons.OK);
        }


        private bool IsMaPhieuMuonExist(string MaPhieuMuon)
        {
            foreach (DataGridViewRow row in dsm1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == MaPhieuMuon)
                {
                    return true; // Mã sản phẩm đã tồn tại
                }
            }
            return false; // Mã sản phẩm chưa tồn tại
        }



        private void STT_Click(object sender, EventArgs e)
        {
            //if (IsMaPhieuMuonExist(Mpm.Text))
            //{
            //    MessageBox.Show("Mã Phiếu Mượn đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return; // Không thêm nếu mã sản phẩm đã tồn tại
            //}
            MuonSachBEL ms = new MuonSachBEL();
            ms.MaPhieuMuon = int.Parse(Mpm.Text);
            ms.TenDocGia = Tdg.Text;
            ms.MaSanPham = int.Parse(comboBox2.Text);
            ms.SoLuong = int.Parse(sl.Text);
            ms.NgayMuon = DateTime.Parse(dateTimePicker2.Text);
            msBAL.EditMuonSach(ms);

            int idx = dsm1.CurrentCell.RowIndex;
            dsm1.Rows[idx].Cells[0].Value = Mpm.Text;
            dsm1.Rows[idx].Cells[1].Value = Tdg.Text;
            dsm1.Rows[idx].Cells[2].Value = comboBox2.Text;
            dsm1.Rows[idx].Cells[3].Value = sl.Text;
            dsm1.Rows[idx].Cells[4].Value = dateTimePicker2.Text;
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);

        }
        private void Del_Click(object sender, EventArgs e)
        {
            if (Mpm.Text != null)
            {
                MuonSachBEL ms = new MuonSachBEL();
                ms.MaPhieuMuon = int.Parse(Mpm.Text);
                msBAL1.DeleteSanPham(ms);
                int idx = dsm1.CurrentCell.RowIndex;
                dsm1.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show("khong the xoa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     

        private void MuonSach_Load(object sender, EventArgs e)
        {
            FillComboBox();
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            List<MuonSachBEL> lstCus = msBAL.ReadMuonSach();

            foreach (MuonSachBEL muonSach in lstCus)    
            {
                dsm1.Rows.Add(muonSach.MaPhieuMuon, muonSach.TenDocGia,muonSach.MaSanPham, muonSach.SoLuong, muonSach.NgayMuon);
            }
            foreach (DataGridViewRow row in dsm1.Rows)
            {
                MuonSachBEL phieuMuon = row.DataBoundItem as MuonSachBEL;
                if (phieuMuon != null && phieuMuon.NgayMuon < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
        }



        private void Mpm_TextChanged(object sender, EventArgs e)
        {
            string inputText = Mpm.Text; // Lấy nội dung trong trường giá


            // Kiểm tra từng ký tự trong nội dung
            foreach (char c in inputText)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu không phải là ký tự số, thông báo và loại bỏ nó
                    MessageBox.Show("Chỉ được nhập số vào Mã Phiếu Mượn.");
                    Mpm.Text = inputText.Remove(inputText.IndexOf(c), 1);
                    Mpm.SelectionStart = Mpm.Text.Length; // Di chuyển con trỏ về cuối
                    return;
                }
            }
        }



        private void sl_TextChanged(object sender, EventArgs e)
        {

            string inputText = sl.Text; // Lấy nội dung trong trường giá

            // Kiểm tra từng ký tự trong nội dung
            foreach (char c in inputText)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu không phải là ký tự số, thông báo và loại bỏ nó
                    MessageBox.Show("Chỉ được nhập số vào số lượng.");
                    sl.Text = inputText.Remove(inputText.IndexOf(c), 1);
                    sl.SelectionStart = sl.Text.Length; // Di chuyển con trỏ về cuối
                    return;
                }
            }
        }
        string ms1;
        string img;
        private void dsm1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dsm1.SelectedCells.Count > 0)
                {
                    Mpm.Text = dsm1.SelectedCells[0].Value?.ToString() ?? "";
                    Tdg.Text = dsm1.SelectedCells[1].Value?.ToString() ?? "";
                    comboBox2.Text = dsm1.SelectedCells[2].Value?.ToString() ?? "";
                    sl.Text = dsm1.SelectedCells[3].Value?.ToString() ?? "";
                    dateTimePicker2.Text = dsm1.SelectedCells[4].Value?.ToString() ?? "";

                    
                }
                else
                {
                    Mpm.Text = string.Empty;
                    Tdg.Text = string.Empty;
                    comboBox2.Text= string.Empty;
                    sl.Text = string.Empty;

                }

            }
            catch
            {
                MessageBox.Show("lỗi thử lại");
            }
        }

        private void Tdg_TextChanged(object sender, EventArgs e)
        {
            string inputText = Tdg.Text;
            // Tạo biểu thức chính quy để kiểm tra ký tự
            string pattern = "^[a-zA-ZÀ-ÿ ]*$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(inputText))
            {
                MessageBox.Show("Chỉ được nhập chữ và dấu cách vào Tên Đọc Giả.");
                // Loại bỏ các ký tự không hợp lệ khỏi TextBox
                string validInput = Regex.Replace(inputText, "[^a-zA-ZÀ-ÿ ]", ""); // Sử dụng Regex.Replace để loại bỏ các ký tự không hợp lệ
                Tdg.Text = validInput;
                Tdg.SelectionStart = Tdg.Text.Length; // Di chuyển con trỏ về cuối
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaSanPham = comboBox2.SelectedItem.ToString();
            comboBox2.Text = selectedMaSanPham;
        }


        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            SanPhamBEL cus = new SanPhamBEL();
            cus.Ma = comboBox2.Text;
            List<SanPhamBEL> lstCus = bal.Timkiem1(cus);
            foreach (SanPhamBEL c in lstCus)
            {
                textBox1.Text = c.Soluong.ToString();
            }
        }

    }
}


