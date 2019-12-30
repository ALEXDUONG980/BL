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
    public partial class frmCNTTNCC : Form
    {
        BUS_NCC bus_NCC = new BUS_NCC();
        QLXMEntities dbContext = new QLXMEntities();
        public frmCNTTNCC()
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

        private void frmCNTTNCC_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvCNTTNCC);
            LoadNCC();
        }
        //Ham nhap
        private void LoadNCC()
        {
            try
            {
                var listNCC = bus_NCC.GetAll();
                foreach (DOT_NCC item in listNCC)
                {
                    int index = dgvCNTTNCC.Rows.Add();
                    dgvCNTTNCC.Rows[index].Cells[0].Value = item.MaNCC;
                    dgvCNTTNCC.Rows[index].Cells[1].Value = item.TenNCC;
                    dgvCNTTNCC.Rows[index].Cells[2].Value = item.DiaChi;
                    dgvCNTTNCC.Rows[index].Cells[3].Value = item.SDT;
                    dgvCNTTNCC.Rows[index].Cells[4].Value = item.Email;
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
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChiNCC.Text = "";
            txtSDTNCC.Text = "";
            txtEmail.Text = "";
        }
        //Ham su kien them nha cung cap
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtSDTNCC.Text == "" || txtEmail.Text == "")
                    throw new Exception("Vui Lòng Nhập Đầy Đủ Thông Tin!!!");
                NCC ncc = new NCC();
                ncc.MaNCC = txtMaNCC.Text;
                ncc.TenNCC = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChiNCC.Text;
                ncc.SDT = txtSDTNCC.Text;
                ncc.Email = txtEmail.Text;

                NCC dbNCC = dbContext.NCCs.FirstOrDefault(p => p.MaNCC == txtMaNCC.Text);
                if (dbNCC == null)
                {
                    dbContext.NCCs.Add(ncc);
                    dbContext.SaveChanges();
                    LoadNCC();
                    MessageBox.Show("Thêm Thành Công!!!", "Thông Báo!");
                    ClearTxt();
                }
                else MessageBox.Show("Mã Nhà Cung Cấp Đã Có. Mời Bạn Nhập Lại!!!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo!");
            }
        }
        //Ham su kien sua nha cung cap 
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NCC ncc = new NCC();
                ncc.MaNCC = txtMaNCC.Text;
                ncc.TenNCC = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChiNCC.Text;
                ncc.SDT = txtSDTNCC.Text;
                ncc.Email = txtEmail.Text;

                NCC dbNCC = dbContext.NCCs.FirstOrDefault(p => p.MaNCC == txtMaNCC.Text);
                if (dbNCC != null)
                {
                    dbNCC.TenNCC = ncc.TenNCC;
                    dbNCC.DiaChi = ncc.DiaChi;
                    dbNCC.SDT = ncc.SDT;
                    dbNCC.Email = ncc.Email;
                    dbContext.NCCs.AddOrUpdate();
                    dbContext.SaveChanges();
                    LoadNCC();
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
        //Ham su kien xoa nha cung cap
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NCC dbDelete = dbContext.NCCs.FirstOrDefault(p => p.MaNCC == txtMaNCC.Text);
            if (dbDelete != null)
            {
                dbContext.NCCs.Remove(dbDelete);
                dbContext.SaveChanges();
                LoadNCC();
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
