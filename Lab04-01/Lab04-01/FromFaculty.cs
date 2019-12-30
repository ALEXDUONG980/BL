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

namespace Lab04_01
{
    public partial class FromFaculty : Form
    {
        public FromFaculty()
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
        private void FromFaculty_Load(object sender, EventArgs e)
        {
             try
             {
                    setGridViewStyle(dgvFaculty);
                    QLSV qlsv = new QLSV();
                    List<Faculty> listFaculty = qlsv.Faculties.ToList();
                    BindGrip(listFaculty);
             }
             catch (Exception ex)
             {
                    MessageBox.Show(ex.Message);
             }
        }
       
        private void BindGrip(List<Faculty> listFaculty)
        {
            dgvFaculty.Rows.Clear();
            foreach (var item in listFaculty)
            {
                int index = dgvFaculty.Rows.Add();
                dgvFaculty.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFaculty.Rows[index].Cells[1].Value = item.FacultyName;
            }
        }
        
        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvFaculty.CurrentCell.RowIndex;
            txtMaKhoa.Text = dgvFaculty.Rows[r].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvFaculty.Rows[r].Cells[1].Value.ToString();
        }
  
        private void clearTXT()
        {
            txtMaKhoa.ResetText();
            txtTenKhoa.ResetText();
            txtTongGS.ResetText();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "" || txtTongGS.Text == "")
                    throw new Exception("Lam on nhap day du thong tin!");
                
                Faculty FA = new Faculty();
                FA.FacultyID = int.Parse(txtMaKhoa.Text);
                if (txtTenKhoa.Text != "")
                    FA.FacultyName = txtTenKhoa.Text;
                FA.TotalProfessor = int.Parse(txtTongGS.Text);

                int temp = int.Parse(txtMaKhoa.Text);
                QLSV qlsv = new QLSV();
                Faculty db = qlsv.Faculties.FirstOrDefault(p => p.FacultyID == temp);
                if (db == null)
                {
                        qlsv.Faculties.Add(FA);
                        qlsv.SaveChanges();
                        FromFaculty_Load(sender, e);
                        MessageBox.Show("Chen hoan thanh!");
                }
                else
                {
                    db.FacultyName = FA.FacultyName;
                    db.TotalProfessor = FA.TotalProfessor;
                    qlsv.Faculties.AddOrUpdate(FA);
                    qlsv.SaveChanges();
                    FromFaculty_Load(sender, e);
                    MessageBox.Show("Update thanh cong!");
                }
                clearTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV();
            int temp = int.Parse(txtMaKhoa.Text);
            Faculty dbDelete = qlsv.Faculties.FirstOrDefault(p => p.FacultyID == temp);
            try
            {
                if (dbDelete != null)
                {
                    qlsv.Faculties.Remove(dbDelete);
                    qlsv.SaveChanges();
                    FromFaculty_Load(sender, e);
                    MessageBox.Show("Delete hoan thanh!");
                }
                clearTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
