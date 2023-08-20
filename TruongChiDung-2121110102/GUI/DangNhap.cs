using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongChiDung_2121110102.BAL;
using TruongChiDung_2121110102.BEL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TruongChiDung_2121110102.GUI
{
    public partial class DangNhap : Form
    {
        private string loggedInUsername = "TenTaiKhoan";
        TaikhoanBAL cusBAL = new TaikhoanBAL();
        public DangNhap()
        {
            InitializeComponent();
          
        }    
    private void btLogin_Click(object sender, EventArgs e)
        {
            string tk = tbtk.Text;
            string mk = tbmk.Text;
            bool dn = false;
            bool kktk = false;
            bool kkmk = false;

            int length = tk.Length;
            int length1 = mk.Length;
            if (length < 5 || length >= 15)
            {
                MessageBox.Show("Tài khoản phải từ 5-15 ký tự");
            }
            else
            {
                kktk = true;
            }
            if (length1 < 5)
            {
                MessageBox.Show("Mật khẩu ít nhất 5 ký tự");
            }
            else
            {
                kkmk = true;
            }
            if (kktk == true && kkmk == true)
            {
                List<TaikhoanBEL> lstCus = cusBAL.ReadTaiKhoan();
                foreach (TaikhoanBEL cus in lstCus)
                {
                    if (cus.Tentk == tk && cus.Matkhau == mk)
                    {
                        MessageBox.Show("Đăng Nhập Thành Công","Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        this.Hide();
                        var form2 = new DanhMuc();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                        dn = true;
                        break;
                    }
                }
                if (!dn)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
  
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form2 = new QuenMatKhau();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

    }
}
