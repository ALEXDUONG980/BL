using BUS_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
   //
    public partial class frmQuanLySinhVien : Form
    {
        BUS_ChuyenNganh bus_chuyenNganh = new BUS_ChuyenNganh();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            ControlConfig();
        }

        private void ControlConfig()
        {
            cmbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cmbChuyenNganh.ValueMember = "MaChuyenNgnah";
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadChuyenNganh();
        }

        private void LoadChuyenNganh()
        {
            cmbChuyenNganh.DataSource = bus_chuyenNganh.GetChuyenNganh();
        
        }
    }
}
