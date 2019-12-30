using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations; 

namespace Lab04_01
{
    public partial class FormStuden : Form
    {
        public FormStuden()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                QLSV qlsv = new QLSV();
                List<Faculty> listFacultys = qlsv.Faculties.ToList();
                List<Student> listStudents = qlsv.Students.ToList();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa, giá trị là Mã khoa         
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)         
        {             
            this.cmbFaculty.DataSource = listFalcultys;             
            this.cmbFaculty.DisplayMember = "FacultyName";             
            this.cmbFaculty.ValueMember = "FacultyID";         
        }  
        //Hàm binding gridView từ list sinh viên                  
        private void BindGrid(List<Student> listStudent)       
        {             
            dgvStudent.Rows.Clear();             
            foreach (var item in listStudent)             
            {                 
                int index = dgvStudent.Rows.Add();                 
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;                 
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;                 
                if(item.Faculty!= null)                    
                    dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;                 
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";             
            }         
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvStudent.CurrentCell.RowIndex;
            txtMaSV.Text = dgvStudent.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvStudent.Rows[r].Cells[1].Value.ToString();
            cmbFaculty.SelectedItem = dgvStudent.Rows[r].Cells[2].Value.ToString();
            txtDTB.Text = dgvStudent.Rows[r].Cells[3].Value.ToString();
        }

        private void cleartxt()
        {
            txtMaSV.ResetText();
            txtHoTen.ResetText();
            cmbFaculty.ResetText();
            txtDTB.ResetText();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text == "" || txtHoTen.Text == "" || cmbFaculty.Text == "" || txtDTB.Text == "")
                    throw new Exception("Lam on nhap day du!");
         
                Student ST = new Student();
                ST.StudentID = txtMaSV.Text;
                if (txtHoTen.Text != "")
                    ST.FullName = txtHoTen.Text;
                if (cmbFaculty.Text != "")
                    ST.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                if (txtDTB.Text != "")
                    ST.AverageScore = double.Parse(txtDTB.Text);

                QLSV qlsv = new QLSV();
                Student db = qlsv.Students.FirstOrDefault(p => p.StudentID == txtMaSV.Text);
                if (db == null)
                {
                    qlsv.Students.Add(ST);
                    qlsv.SaveChanges();
                    Form1_Load(sender, e);
                    MessageBox.Show("Update thanh cong!");
                }
                else
                {
                    db.FullName = ST.FullName;
                    db.Faculty = ST.Faculty;
                    db.AverageScore = ST.AverageScore;
                    qlsv.Students.AddOrUpdate(ST);
                    qlsv.SaveChanges();
                    Form1_Load(sender, e);
                    MessageBox.Show("Update thanh con!");
                }
                cleartxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV();
            Student dbDelete = qlsv.Students.FirstOrDefault(p => p.StudentID == txtMaSV.Text);
            if (dbDelete != null)
            {
                qlsv.Students.Remove(dbDelete);
                qlsv.SaveChanges();
                Form1_Load(sender, e);
                MessageBox.Show("Delete hoan thanh!");
            }
            cleartxt();
        }

        private void thôngTinKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FromFaculty form = new FromFaculty();
            form.Activate();
            form.Show();
        }
    }
}
