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
    public partial class frmCNTTNV : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        QLXMEntities dbContext = new QLXMEntities();
        public frmCNTTNV()
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
        private void frmCNTTNV_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvCNTTNV);
            LoadNhanVien();
        }
        //Ham Nhap
        private void LoadNhanVien()
        {
            try
            {
                var listNhanVien = bus_NhanVien.GetAll();
                foreach (DOT_NhanVien item in listNhanVien)
                { 
                    int index = dgvCNTTNV.Rows.Add();
                    dgvCNTTNV.Rows[index].Cells[0].Value = item.MaNV;
                    dgvCNTTNV.Rows[index].Cells[1].Value = item.HoVaTen;
                    dgvCNTTNV.Rows[index].Cells[2].Value = item.GioiTinh;
                    dgvCNTTNV.Rows[index].Cells[3].Value = item.NgaySinh;
                    dgvCNTTNV.Rows[index].Cells[4].Value = item.DiaChi;
                    dgvCNTTNV.Rows[index].Cells[5].Value = item.SDT;
                    dgvCNTTNV.Rows[index].Cells[6].Value = item.ChucVu;
                    dgvCNTTNV.Rows[index].Cells[7].Value = item.NgayVaoLam;
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham xoa Text
        public void ClearTxt()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dtNgaySinh.Enabled = false;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtChucVu.Text = "";
            dtNgayVaoLam.Enabled = false;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }
        //Ham su kien them nhan vien
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "" || txtHoTen.Text == ""|| txtDiaChi.Text == "" || txtChucVu.Text == ""  || txtSDT.Text == "")
                    throw new Exception("Vui Lòng Nhập Đầy Đủ Thông Tin!!!");
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoVaTen = txtHoTen.Text;
                nv.NgaySinh = dtNgaySinh.Value;
                if (rdoNam.Enabled == true)
                    nv.GioiTinh = rdoNam.Checked;
                else nv.GioiTinh = rdoNu.Checked;
                nv.DiaChi = txtDiaChi.Text;
                nv.SDT = txtSDT.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.NgayVaoLam = dtNgayVaoLam.Value;

                NhanVien dbNhanVien = dbContext.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (dbNhanVien == null)
                {
                    dbContext.NhanViens.Add(nv);
                    dbContext.SaveChanges();
                    LoadNhanVien();
                    MessageBox.Show("Thêm Thành Công!!!", "Thông Báo!");
                    ClearTxt();
                }
                else MessageBox.Show("Mã Nhân Viên Bị Trùng. Mời Bạn Nhập Lại!!!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham su kien sua nhan vien
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoVaTen = txtHoTen.Text;
                nv.NgaySinh = dtNgaySinh.Value;
                if (rdoNam.Enabled == true)
                    nv.GioiTinh = rdoNam.Checked;
                else nv.GioiTinh = rdoNu.Checked;
                nv.DiaChi = txtDiaChi.Text;
                nv.SDT = txtSDT.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.NgayVaoLam = dtNgayVaoLam.Value;

                NhanVien dbNhanVien = dbContext.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (dbNhanVien != null)
                {
                    dbNhanVien.HoVaTen = nv.HoVaTen;
                    dbNhanVien.GioiTinh = nv.GioiTinh;
                    dbNhanVien.NgaySinh = nv.NgaySinh;
                    dbNhanVien.DiaChi = nv.DiaChi;
                    dbNhanVien.SDT = nv.SDT;
                    dbNhanVien.ChucVu = nv.ChucVu;
                    dbNhanVien.NgayVaoLam = nv.NgayVaoLam;
                    dbContext.NhanViens.AddOrUpdate();
                    dbContext.SaveChanges();
                    LoadNhanVien();
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
        //Ham su kien xoa nhan vien
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien dbDelete = dbContext.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
            if (dbDelete != null)
            {
                dbContext.NhanViens.Remove(dbDelete);
                dbContext.SaveChanges();
                LoadNhanVien();
                MessageBox.Show("Xóa Thành Công!!!", "Thông Báo!");
                ClearTxt();
            }
        }
        //Ham su kien thoat 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Thoát Chương Trình?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}

