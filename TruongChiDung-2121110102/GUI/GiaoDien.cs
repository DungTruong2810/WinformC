using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TruongChiDung_2121110102.BAL;
using TruongChiDung_2121110102.BEL;
using System.Data.SqlClient;
using Irony.Parsing;
using System.Linq;
using ClosedXML.Excel;
using System.Text.RegularExpressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO.Packaging;


namespace TruongChiDung_2121110102.GUI
{
    public partial class GiaoDien : Form
    {
        string nameimg;
        string ma;
        PictureBox pb = new PictureBox();
        SanPhamBAL cusBAL1 = new SanPhamBAL();
        SanPhamBAL cusBAL = new SanPhamBAL();
        public GiaoDien()
        {
            InitializeComponent();
            FillComboBox();
            rs.Click += rs_Click;

        }
        private void FillComboBox()
        {
            using (SqlConnection connection = CreateConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT DISTINCT TenNhaCungCap FROM NhaCungCap", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string TenNhaCungCap = reader["TenNhaCungCap"].ToString();
                                comboBox1.Items.Add(TenNhaCungCap);
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

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            List<SanPhamBEL> lstCus = cusBAL1.ReadSanPham();
            foreach (SanPhamBEL cus in lstCus)
            {
                dgvSanPham.Rows.Add(cus.Ma,cus.Ten, cus.Soluong, cus.Gia, cus.Ncc, cus.Anh);
            }
        }
        string id;

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tensp.Text) || string.IsNullOrWhiteSpace(gia.Text) || string.IsNullOrWhiteSpace(soluong.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin cho sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm nếu thông tin không đủ
            }
            if (string.IsNullOrEmpty(nameimg))
            {
                MessageBox.Show("Vui lòng chọn một ảnh sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm nếu chưa chọn ảnh
            }

            SanPhamBEL cus = new SanPhamBEL();
            cus.Ten = tensp.Text;
            cus.Gia = float.Parse(gia.Text);
            cus.Soluong = int.Parse(soluong.Text);
            cus.Ncc = comboBox1.Text;
            cus.Anh = nameimg;
            cusBAL1.AddSanPham(cus);
            dgvSanPham.Rows.Clear();
            List<SanPhamBEL> lstCus = cusBAL1.ReadSanPham();
            foreach (SanPhamBEL cus1 in lstCus)
            {
                dgvSanPham.Rows.Add(cus1.Ma,cus1.Ten, cus1.Soluong, cus1.Gia, cus1.Ncc, cus1.Anh);
            }

        }


        private void btPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
                openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp tin

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của hình ảnh đã chọn
                    string imagePath = openFileDialog.FileName;
                    string selectedImagePath = openFileDialog.FileName;

                    // Lưu ảnh vào thư mục chỉ định
                    string targetDirectory = @"D:\TruongChiDung-2121110102\TruongChiDung-2121110102\img"; // Thay đổi đường dẫn tới thư mục mong muốn
                    string targetFileName = Path.Combine(targetDirectory, Path.GetFileName(selectedImagePath));

                    nameimg = Path.GetFileName(selectedImagePath);


                    File.Copy(selectedImagePath, targetFileName, true);
                    // Load ảnh từ đường dẫn và thêm vào DataGridViewImageColumn
                    // Kiểm tra dung lượng của tệp ảnh
                    long fileSizeKB = new FileInfo(selectedImagePath).Length / 1024; // Chuyển từ byte sang KB

                    // Giới hạn dung lượng tệp ảnh tối đa (VD: 500KB)
                    int maxFileSizeKB = 76;

                    if (fileSizeKB > maxFileSizeKB)
                    {
                        MessageBox.Show("File ảnh quá lớn. Vui lòng chọn tệp ảnh nhỏ hơn " + maxFileSizeKB + "KB.");
                        return;
                    }
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = new Bitmap(openFileDialog.FileName);
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi sảy ra. Thử lại");
            }
            
        }
        string img;
        string ma1;

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSanPham.SelectedCells.Count > 0)
                {

                    masp.Text = dgvSanPham.SelectedCells[0].Value.ToString();
                    ma1 = masp.Text;
                    tensp.Text = dgvSanPham.SelectedCells[1].Value.ToString();
                    soluong.Text = dgvSanPham.SelectedCells[2].Value.ToString();
                    gia.Text = dgvSanPham.SelectedCells[3].Value.ToString();
                    comboBox1.Text = dgvSanPham.SelectedCells[4].Value.ToString();
                    if (dgvSanPham.SelectedCells[5].Value != null)
                    {
                        img = dgvSanPham.SelectedCells[5].Value.ToString();
                    }

                    if (File.Exists(@"D:\TruongChiDung-2121110102\TruongChiDung-2121110102\img\" + img))
                    {
                        // Hiển thị hình ảnh trong PictureBox
                        pictureBox1.Image = new Bitmap(@"D:\TruongChiDung-2121110102\TruongChiDung-2121110102\img\" + img);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    masp.Text = string.Empty;
                    tensp.Text = string.Empty;
                    gia.Text = string.Empty;
                    soluong.Text = string.Empty;
                    comboBox1.Text = string.Empty;
                    pictureBox1.Image = null;
                }
            }
            catch
            {
                MessageBox.Show("lỗi thử lại");
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {



                SanPhamBEL cus = new SanPhamBEL();
            cus.Ma = masp.Text;
                cus.Ten = tensp.Text;
                cus.Gia = float.Parse(gia.Text);
                cus.Soluong = int.Parse(soluong.Text);
                cus.Ncc = comboBox1.Text;
                cus.Anh = nameimg;

                // Gọi hàm để cập nhật thông tin sản phẩm trong cơ sở dữ liệu
                cusBAL1.EditSanPham(cus);

            // Cập nhật thông tin trong DataGridView
            int idx = dgvSanPham.CurrentCell.RowIndex;
            //dgvSanPham.Rows[idx].Cells[0].Value = masp.Text;
            dgvSanPham.Rows[idx].Cells[1].Value = tensp.Text;
                dgvSanPham.Rows[idx].Cells[2].Value = gia.Text;
                dgvSanPham.Rows[idx].Cells[3].Value = soluong.Text;
                dgvSanPham.Rows[idx].Cells[4].Value = comboBox1.Text;
                dgvSanPham.Rows[idx].Cells[5].Value = nameimg;
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        //private bool CheckIfProductIdExists(string productId)
        //{
        //    // Thực hiện truy vấn SQL để kiểm tra
        //    SqlConnection conn = CreateConnection();
        //    conn.Open();
        //    SqlCommand checkIdCmd = new SqlCommand("select count(*) from SanPham where MaSanPham=@MaSanPham", conn);
        //    checkIdCmd.Parameters.Add(new SqlParameter("@MaSanPham", productId));
        //    int existingCount = (int)checkIdCmd.ExecuteScalar();
        //    conn.Close();

        //    return existingCount > 0;
        //}
        private void btDelete_Click(object sender, EventArgs e)
        {
            if(masp.Text !=null)
            {
                SanPhamBEL cus = new SanPhamBEL();
                cus.Ma = masp.Text;
                cusBAL1.DeleteSanPham(cus);
                int idx = dgvSanPham.CurrentCell.RowIndex;
                dgvSanPham.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show("khong the xoa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Visible = false;
                            excelApp.Workbooks.Add();

                            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;

                            int rowIndex = 1;

                            // Header
                            for (int colIndex = 1; colIndex <= dgvSanPham.Columns.Count; colIndex++)
                            {
                                worksheet.Cells[rowIndex, colIndex] = dgvSanPham.Columns[colIndex - 1].HeaderText;
                            }
                            rowIndex++;

                            // Data
                            foreach (DataGridViewRow row in dgvSanPham.Rows)
                            {
                                for (int colIndex = 1; colIndex <= dgvSanPham.Columns.Count; colIndex++)
                                {
                                    worksheet.Cells[rowIndex, colIndex] = row.Cells[colIndex - 1].Value;
                                }
                                rowIndex++;
                            }

                            worksheet.SaveAs(filePath);
                            excelApp.Quit();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DanhMuc();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void gia_TextChanged(object sender, EventArgs e)
        {
            string inputText = gia.Text; // Get the content of the "gia" field

            // Remove any non-digit characters from the input
            string cleanedInput = new string(inputText.Where(char.IsDigit).ToArray());

            
            foreach (char c in inputText)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu không phải là ký tự số, thông báo và loại bỏ nó
                    MessageBox.Show("Chỉ được nhập số vào giá.");
                    gia.Text = inputText.Remove(inputText.IndexOf(c), 1);
                    gia.SelectionStart = gia.Text.Length; // Di chuyển con trỏ về cuối
                    return;
                }

            }
        }


        private void soluong_TextChanged(object sender, EventArgs e)
        {
            string inputText = soluong.Text; // Lấy nội dung trong trường giá

            // Kiểm tra từng ký tự trong nội dung
            foreach (char c in inputText)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu không phải là ký tự số, thông báo và loại bỏ nó
                    MessageBox.Show("Chỉ được nhập số vào số lượng.");
                    soluong.Text = inputText.Remove(inputText.IndexOf(c), 1);
                    soluong.SelectionStart = soluong.Text.Length; // Di chuyển con trỏ về cuối
                    return;
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.Rows.Clear();
            SanPhamBEL cus = new SanPhamBEL();
            cus.Ma = search.Text;
            List<SanPhamBEL> lstCus = cusBAL1.Timkiem(cus);
            foreach (SanPhamBEL c in lstCus)
            {
                dgvSanPham.Rows.Add(c.Ma, c.Ten, c.Soluong, c.Gia, c.Ncc, c.Anh);
            }
        }

        private void tensp_TextChanged(object sender, EventArgs e)
        {
            string inputText = tensp.Text;
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

            tensp.Text = validInput;
            tensp.SelectionStart = tensp.Text.Length;

            if (hasInvalidCharacters)
            {
                MessageBox.Show("Chỉ được nhập chữ có dấu và dấu cách vào trường tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Ngăn người dùng nhập bằng bàn phím
        }

        private void rs_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            tensp.Text = "";
            soluong.Text = "";
            gia.Text = "";
            comboBox1.SelectedIndex = -1;
            search.Text = "";
            pictureBox1.Image = null; // Clear the picture box
        }
        private void ExportToPDF(DataGridView dgv)
        {
            // Tạo tệp PDF
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF file (*.pdf)|*.pdf";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));

                document.Open();

                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    pdfTable.AddCell(new Phrase(dgv.Columns[j].HeaderText));
                }
                pdfTable.HeaderRows = 1;

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int k = 0; k < dgv.Columns.Count; k++)
                    {
                        if (dgv[k, i].Value != null)
                        {
                            pdfTable.AddCell(new Phrase(dgv[k, i].Value.ToString()));
                        }
                    }
                }
                MessageBox.Show("Xuất PDF thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                document.Add(pdfTable);
                document.Close();
            }
        }
        private void PDF_Click(object sender, EventArgs e)
        {
            ExportToPDF(dgvSanPham);
        }


        private void importEX_Click(object sender, EventArgs e)
        {

        }
    }
}

