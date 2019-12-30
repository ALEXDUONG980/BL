using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmCNTTKH form = new frmCNTTKH();
            form.Activate();
            form.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmCNTTNV form = new frmCNTTNV();
            form.Activate();
            form.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmCNTTNCC form = new frmCNTTNCC();
            form.Activate();
            form.Show();
        }
        private void btnXe_Click(object sender, EventArgs e)
        {
            frmXe form = new frmXe();
            form.Activate();
            form.Show();
        }
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            frmHopDong form = new frmHopDong();
            form.Activate();
            form.Show();
        }

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Thoát Chương Trình?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
