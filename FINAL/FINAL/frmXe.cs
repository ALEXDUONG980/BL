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
    public partial class frmXe : Form
    {
        BUS_Xe bus_Xe = new BUS_Xe();
        BUS_NCC bus_NCC = new BUS_NCC();
        BUS_BaoHanh bus_BaoHanh = new BUS_BaoHanh();
        QLXMEntities dbContext = new QLXMEntities();
        public frmXe()
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

        private void frmXe_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvCNTTXe);
            MaBHCombobox();
            MaNCCCombobox();
            LoadXe();
        }
        //Do dl tu databases cho MaNCC
        private void MaNCCCombobox()
        {
            var listMaNCC = bus_NCC.GetAll();
            this.cmbMaNCC.DataSource = listMaNCC;
            this.cmbMaNCC.DisplayMember = "TenNCC";
            this.cmbMaNCC.ValueMember = "MaNCC";
        }
        //Do dl tu databases cho MaBH
        private void MaBHCombobox()
        {
            var listMaBH = bus_BaoHanh.GetAll();
            this.cmbMaBH.DataSource = listMaBH;
            this.cmbMaBH.DisplayMember = "MaBH";
        }
        //Ham nhap
        private void LoadXe()
        {
            try
            {
                var listXe = bus_Xe.GetAll();
                foreach (DOT_Xe item in listXe)
                {
                    int index = dgvCNTTXe.Rows.Add();
                    dgvCNTTXe.Rows[index].Cells[0].Value = item.MaXe;
                    dgvCNTTXe.Rows[index].Cells[1].Value = item.TenXe;
                    dgvCNTTXe.Rows[index].Cells[2].Value = item.MauXe;
                    dgvCNTTXe.Rows[index].Cells[3].Value = item.MaBH;
                    dgvCNTTXe.Rows[index].Cells[4].Value = item.MaNCC;
                    dgvCNTTXe.Rows[index].Cells[5].Value = item.NgayLap;
                    dgvCNTTXe.Rows[index].Cells[6].Value = item.GiaBan;
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
            txtMaXe.Text = "";
            txtTenXe.Text = "";
            txtMauXe.Text = "";
            cmbMaBH.Text = "";
            cmbMaNCC.Text = "";
            txtGiaBan.Text = "";
            dtNgayLap.Enabled = false;
        }
        //Ham su kien them xe
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaXe.Text == "" || txtTenXe.Text == "" || txtMauXe.Text == "" || txtGiaBan.Text == "" || cmbMaBH.Text == "" || cmbMaNCC.Text == "" || dtNgayLap.Enabled == false)
                    throw new Exception("Vui Lòng Nhập Đầy Đủ Thông Tin!!!");
                Xe xe = new Xe();
                xe.MaXe = txtMaXe.Text;
                xe.TenXe = txtTenXe.Text;
                xe.MauXe = txtMauXe.Text;
                xe.MaBH = cmbMaBH.SelectedValue.ToString();
                xe.MaNCC = cmbMaNCC.SelectedValue.ToString();
                xe.GiaBan = int.Parse(txtGiaBan.Text);
                xe.NgayNhap = dtNgayLap.Value;

                Xe dbXe = dbContext.Xes.FirstOrDefault(p => p.MaXe == txtMaXe.Text);
                if (dbXe == null)
                {
                    dbContext.Xes.Add(xe);
                    dbContext.SaveChanges();
                    LoadXe();
                    MessageBox.Show("Thêm Thành Công!!!", "Thông Báo!");
                    ClearTxt();
                }
                else MessageBox.Show("Mã Xe Bị Trùng. Mời Bạn Nhập Lại!!!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham su kien sua xe
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Xe xe = new Xe();
                xe.MaXe = txtMaXe.Text;
                xe.TenXe = txtTenXe.Text;
                xe.MauXe = txtMauXe.Text;
                xe.MaBH = cmbMaBH.SelectedValue.ToString();
                xe.MaNCC = cmbMaNCC.SelectedValue.ToString();
                xe.GiaBan = int.Parse(txtGiaBan.Text);
                xe.NgayNhap = dtNgayLap.Value;

                Xe dbXe = dbContext.Xes.FirstOrDefault(p => p.MaXe == txtMaXe.Text);
                if (dbXe != null)
                {
                    dbXe.TenXe = xe.TenXe;
                    dbXe.MauXe = xe.MauXe;
                    dbXe.MaBH = xe.MaBH;
                    dbXe.MaNCC = xe.MaNCC;
                    dbXe.GiaBan = xe.GiaBan;
                    dbXe.NgayNhap = xe.NgayNhap;
                    dbContext.NhanViens.AddOrUpdate();
                    dbContext.SaveChanges();
                    LoadXe();
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
        //Ham su kien xoa xe
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xe dbDelete = dbContext.Xes.FirstOrDefault(p => p.MaXe == txtMaXe.Text);
            if (dbDelete != null)
            {
                dbContext.Xes.Remove(dbDelete);
                dbContext.SaveChanges();
                LoadXe();
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
