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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        //STYLE DATAGRIDVIEW TABLE
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
        //FORM STUDENT MANAGE LOAD DATA
        private void FormStudent_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                //Always use context to work with class
                ContextDB context = new ContextDB();
                //Get all faculties from the faculty table
                List<Faculty> listFaculty = context.Faculties.ToList();
                FillFacultyCombobox(listFaculty);
                //Get all students from the student table
                List<Student> listStudent = context.Students.ToList();
                BindGrip(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //THE BINDING LIST DATA FUNCTION IN COMBOBOX HAS THE DISPLAY OF THE FACULTY NAME, THE VALUE IS FACULTY ID
        private void BindGrip(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }
        private void FillFacultyCombobox(List<Faculty> listFaculty)
        {
            this.cbFaculty.DataSource = listFaculty;
            this.cbFaculty.DisplayMember = "FacultyName";
            this.cbFaculty.ValueMember = "FacultyID";
        }
        //EVENT FOR DGVSTUDENT OF CELL CLICK
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvStudent.CurrentCell.RowIndex;
            txtStuID.Text = dgvStudent.Rows[r].Cells[0].Value.ToString();
            txtStuName.Text = dgvStudent.Rows[r].Cells[1].Value.ToString();
            cbFaculty.SelectedItem = dgvStudent.Rows[r].Cells[2].Value.ToString();
            txtAvgScore.Text = dgvStudent.Rows[r].Cells[3].Value.ToString();
        }
        //CLEAT TEXTBOX
        private void cleartxt()
        {
            txtStuID.ResetText();
            txtStuName.ResetText();
            cbFaculty.ResetText();
            txtAvgScore.ResetText();
        }
        //EVENT FOR BUTTON ADD & UPDATE
        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStuID.Text == "" || txtStuName.Text == "" || cbFaculty.Text == "" || txtAvgScore.Text == "")
                    throw new Exception("Please Enter Full Information!!!");
                //Get object from form
                Student st = new Student();
                st.StudentID = txtStuID.Text;
                if (txtStuName.Text != "")
                    st.FullName = txtStuName.Text;
                if (cbFaculty.Text != "")
                    st.FacultyID = int.Parse(cbFaculty.SelectedValue.ToString());
                if (txtAvgScore.Text != "")
                    st.AverageScore = double.Parse(txtAvgScore.Text);

                ContextDB context = new ContextDB();
                Student db = context.Students.FirstOrDefault(p => p.StudentID == txtStuID.Text);
                if (db == null)
                {
                    //Add an object
                    context.Students.Add(st);
                    context.SaveChanges();
                    FormStudent_Load(sender, e);
                    MessageBox.Show("Add Student Successfully!!!", "Notification");
                }
                else
                {
                    db.FullName = st.FullName;
                    db.Faculty = st.Faculty;
                    db.AverageScore = st.AverageScore;
                    context.Students.AddOrUpdate(st);
                    context.SaveChanges();
                    FormStudent_Load(sender, e);
                    MessageBox.Show("Update Student Successfully!!!", "Notification");
                }
                cleartxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //EVENT FOR BUTTON DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ContextDB context = new ContextDB();
            Student dbDelete = context.Students.FirstOrDefault(p => p.StudentID == txtStuID.Text);
            if (dbDelete != null)
            {
                context.Students.Remove(dbDelete);
                context.SaveChanges();
                FormStudent_Load(sender, e);
                MessageBox.Show("Delete Student Successfully!!!", "Notification");
            }
            cleartxt();
        }
        //EVENT FOR FACULTY INFOR OF TOOL STRIP MENU ITEM
        private void facultyInforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFaculty form = new FormFaculty();
            form.Activate();
            form.Show();
        }
    }
}
