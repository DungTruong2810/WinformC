using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TruongChiDung_2121110102.GUI
{
    public partial class DanhMuc : Form
    {

        private string loggedInUsername = "TenTaiKhoan";
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new GiaoDien();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btĐX_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DangNhap();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btEX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new GiaoDien();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MuonSach();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new DocGia();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new NhanVien();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new TraSach();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
