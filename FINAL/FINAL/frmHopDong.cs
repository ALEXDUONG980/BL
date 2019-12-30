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
    public partial class frmHopDong : Form
    {
        BUS_HopDong bus_HopDong = new BUS_HopDong();
        BUS_KhachHang bus_KhachHang = new BUS_KhachHang();
        BUS_Xe bus_Xe = new BUS_Xe();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        QLXMEntities dbContext = new QLXMEntities();
        public frmHopDong()
        {
            InitializeComponent();
        }
        private void frmHopDong_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvCNTTHD);
            MaKHCombobox();
            MaNVCombobox();
            MaXeCombobox();
            LoadHopDong();
        }
        //Do dl tu databases vao MaXe
        private void MaXeCombobox()
        {
            var listMaXe = bus_Xe.GetAll();
            this.cmbMaXe.DataSource = listMaXe;
            this.cmbMaXe.DisplayMember = "MaXe";
        }
        //Do dl tu databases vao MaNV
        private void MaNVCombobox()
        {
            var listMaNV = bus_NhanVien.GetAll();
            this.cmbMaNV.DataSource = listMaNV;
            this.cmbMaNV.DisplayMember = "MaNV";
        }
        //Do dl tu databases vao MaKH
        private void MaKHCombobox()
        {
            var listMaKH = bus_KhachHang.GetAll();
            this.cmbMaKH.DataSource = listMaKH;
            this.cmbMaKH.ValueMember = "MaKH";
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
        //Ham nhap
        private void LoadHopDong()
        {
            try
            {
                var listHopDong = bus_HopDong.GetAll();
                foreach (DOT_HopDong item in listHopDong)
                {
                    int index = dgvCNTTHD.Rows.Add();
                    dgvCNTTHD.Rows[index].Cells[0].Value = item.MaHD;
                    dgvCNTTHD.Rows[index].Cells[1].Value = item.MaKH;
                    dgvCNTTHD.Rows[index].Cells[2].Value = item.MaNV;
                    dgvCNTTHD.Rows[index].Cells[3].Value = item.MaXe;
                    dgvCNTTHD.Rows[index].Cells[4].Value = item.NgayLap;
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
            txtMaHD.Text = "";
            cmbMaKH.Text = "";
            cmbMaNV.Text = "";
            cmbMaXe.Text = "";
            dtNgayLap.Enabled = false;
        }
        //Ham su kien them hop dong
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text == "" || cmbMaKH.Text == "" || cmbMaNV.Text == "" || cmbMaXe.Text == "" || dtNgayLap.Enabled == false)
                    throw new Exception("Vui Lòng Nhập Đầy Đủ Thông Tin!!!");
                HopDong hd = new HopDong();
                hd.MaHD = txtMaHD.Text;
                hd.MaKH = cmbMaKH.SelectedValue.ToString();
                hd.MaNV = cmbMaNV.SelectedValue.ToString();
                hd.MaXe = cmbMaXe.SelectedValue.ToString();
                hd.NgayLap = dtNgayLap.Value;

                HopDong dbHopDong = dbContext.HopDongs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
                if (dbHopDong == null)
                {
                    dbContext.HopDongs.Add(hd);
                    dbContext.SaveChanges();
                    LoadHopDong();
                    MessageBox.Show("Thêm Thành Công!!!", "Thông Báo!");
                    ClearTxt();
                }
                else MessageBox.Show("Mã Hợp Đồng Bị Trùng. Mời Bạn Nhập Lại!!!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham su kien sua hop dong
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HopDong hd = new HopDong();
                hd.MaHD = txtMaHD.Text;
                hd.MaKH = cmbMaKH.SelectedValue.ToString();
                hd.MaNV = cmbMaNV.SelectedValue.ToString();
                hd.MaXe = cmbMaXe.SelectedValue.ToString();
                hd.NgayLap = dtNgayLap.Value;

                HopDong dbHopDong = dbContext.HopDongs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
                if (dbHopDong != null)
                {
                    dbHopDong.MaKH = hd.MaKH;
                    dbHopDong.MaNV = hd.MaNV;
                    dbHopDong.MaXe = hd.MaXe;
                    dbHopDong.NgayLap = hd.NgayLap;
                    dbContext.NhanViens.AddOrUpdate();
                    dbContext.SaveChanges();
                    LoadHopDong();
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
        //Ham su kien xoa hop dong
        private void btnXoa_Click(object sender, EventArgs e)
        {
            HopDong dbDelete = dbContext.HopDongs.FirstOrDefault(p => p.MaHD == txtMaHD.Text);
            if (dbDelete != null)
            {
                dbContext.HopDongs.Remove(dbDelete);
                dbContext.SaveChanges();
                LoadHopDong();
                MessageBox.Show("Xóa Thành Công!!!", "Thông Báo!");
                ClearTxt();
            }
        }
        //Ham thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Thoát Chương Trình?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
