using BUS_QLBX;
using DAL_QLXM;
using DTO_QLBX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class frmCNTTKH : Form
    {
        BUS_KhachHang bus_KhachHang = new BUS_KhachHang();
        QLXMEntities dbContext = new QLXMEntities();
        public frmCNTTKH()
        {
            InitializeComponent();
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmCNTTKH_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvCNTTKH);
            LoadKhachHang();
        }
        //Ham nhap
        private void LoadKhachHang()
        {
            try
            {
                var listKhachHang = bus_KhachHang.GetAll();
                foreach (DOT_KhachHang item in listKhachHang)
                {
                    int index = dgvCNTTKH.Rows.Add();
                    dgvCNTTKH.Rows[index].Cells[0].Value = item.MaKH;
                    dgvCNTTKH.Rows[index].Cells[1].Value = item.TenKH;
                    dgvCNTTKH.Rows[index].Cells[2].Value = item.GioiTinh;
                    dgvCNTTKH.Rows[index].Cells[3].Value = item.DiaChi;
                    dgvCNTTKH.Rows[index].Cells[4].Value = item.SDT;
                    dgvCNTTKH.Rows[index].Cells[5].Value = item.GhiChu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham xoa Text
        public void ClearTxt()
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSDTKH.Text = "";
            txtGhiChu.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }
        //Ham su kien them khach hang
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "" || txtHoTenKH.Text == "" || txtDiaChiKH.Text == "" || txtGhiChu.Text == "" || txtSDTKH.Text == "")
                    throw new Exception("Vui Lòng Nhập Đầy Đủ Thông Tin!!!");
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtHoTenKH.Text;
                if (rdoNam.Enabled == true)
                    kh.GioiTinh = rdoNam.Checked;
                else kh.GioiTinh = rdoNu.Checked;
                kh.DiaChi = txtDiaChiKH.Text;
                kh.SDT = txtSDTKH.Text;
                kh.GhiChu = txtGhiChu.Text;
              
                KhachHang dbKhachHang = dbContext.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
                if (dbKhachHang == null)
                {
                    dbContext.KhachHangs.Add(kh);
                    dbContext.SaveChanges();
                    LoadKhachHang();
                    MessageBox.Show("Thêm Thành Công!!!", "Thông Báo!");
                    ClearTxt();
                }
                else MessageBox.Show("Mã Khách Hàng Đã Có. Mời Bạn Nhập Lại!!!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham su kien sua khach hang
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtHoTenKH.Text;
                if (rdoNam.Enabled == true)
                    kh.GioiTinh = rdoNam.Checked;
                else kh.GioiTinh = rdoNu.Checked;
                kh.DiaChi = txtDiaChiKH.Text;
                kh.SDT = txtSDTKH.Text;
                kh.GhiChu = txtGhiChu.Text;

                KhachHang dbKhachHang = dbContext.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
                if (dbKhachHang != null)
                {
                    dbKhachHang.TenKH = kh.TenKH;
                    dbKhachHang.GioiTinh = kh.GioiTinh;
                    dbKhachHang.DiaChi = kh.DiaChi;
                    dbKhachHang.SDT = kh.SDT;
                    dbKhachHang.GhiChu = kh.GhiChu;
                    dbContext.NhanViens.AddOrUpdate();
                    dbContext.SaveChanges();
                    LoadKhachHang();
                    MessageBox.Show("Cập Nhật Thành Công!!!", "Thông Báo!");
                    ClearTxt();
                }
                else MessageBox.Show("Cập Nhật Thất Bại!!!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham su kien xoa khach hang
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang dbDelete = dbContext.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
            if (dbDelete != null)
            {
                dbContext.KhachHangs.Remove(dbDelete);
                dbContext.SaveChanges();
                LoadKhachHang();
                MessageBox.Show("Xóa Thành Công!!!", "Thông Báo!");
                ClearTxt();
            }
        }
        //Thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Thoát Chương Trình?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
