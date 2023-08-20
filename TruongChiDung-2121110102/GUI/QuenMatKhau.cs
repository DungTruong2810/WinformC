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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TruongChiDung_2121110102.BEL;

namespace TruongChiDung_2121110102.GUI
{
    public partial class QuenMatKhau : Form
    {
        TaikhoanBAL cusBAL = new TaikhoanBAL();
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btQMK_Click(object sender, EventArgs e)
        {
            string dk = taikhoan.Text;
            string dk1 = email1.Text;
            bool a = false;
            List<TaikhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
            foreach (TaikhoanBEL c in lstCus)
            {
                if (c.Tentk == dk && c.Email == dk1)
                {
                    TaikhoanBEL cus = new TaikhoanBEL();
                    cus.Tentk = taikhoan.Text;
                    cus.Matkhau = passwordnew.Text;
                    cus.Email = email1.Text;
                    if (passwordnew.Text == passwordenter.Text)
                    {
                        cusBAL.EditTaikhoan(cus);
                        a = true;
                        MessageBox.Show("Đổi mật khẩu Thành công", "Thông báo");
                        break;
                    }
                    else
                    {
                        a = true;
                        MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo");
                    }

                }

            }
            if (a == false)
            {
                MessageBox.Show("Tài Khoản Mật Khẩu không tồn tại ", "Thông báo");
            }
            this.Hide();
            var form1 = new DangNhap();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new QuenMatKhau();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
