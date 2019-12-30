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
    public partial class FormFaculty : Form
    {
        public FormFaculty()
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
        private void FormFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvFaculty);
                //Always use context to work with class
                ContextDB context = new ContextDB();
                //Get all faculties from the faculty table
                List<Faculty> listFaculty = context.Faculties.ToList();
                BindGrip(listFaculty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //THE BINDING LIST DATA FUNCTION IN COMBOBOX HAS THE DISPLAY OF THE FACULTY NAME, THE VALUE IS FACULTY ID
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
        //EVENT FOR DGVFACULTY OF CELL CLICK
        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvFaculty.CurrentCell.RowIndex;
            txtFalID.Text = dgvFaculty.Rows[r].Cells[0].Value.ToString();
            txtFalName.Text = dgvFaculty.Rows[r].Cells[1].Value.ToString();
        }
        //CLEAT TEXTBOX
        private void clearTXT()
        {
            txtFalID.ResetText();
            txtFalName.ResetText();
            txtTotal.ResetText();
        }
        //EVENT FOR BUTTON ADD & UPDATE
        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFalID.Text == "" || txtFalName.Text == "" || txtTotal.Text == "")
                    throw new Exception("Please Enter Full Information!!!");
                //Get object from form
                Faculty fl = new Faculty();
                fl.FacultyID = int.Parse(txtFalID.Text);
                if (txtFalName.Text != "")
                    fl.FacultyName = txtFalName.Text;
                fl.TotalTeacher = int.Parse(txtTotal.Text);

                int temp = int.Parse(txtFalID.Text);
                ContextDB context = new ContextDB();
                Faculty db = context.Faculties.FirstOrDefault(p => p.FacultyID == temp);
                if (db == null)
                {
                    if (MessageBox.Show("You may want to insert ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Add an object
                        context.Faculties.Add(fl);
                        context.SaveChanges();
                        FormFaculty_Load(sender, e);
                        MessageBox.Show("Add Faculty Successfully!!!", "Notification");
                    }
                    else this.Close();
                    clearTXT();
                }
                else
                {
                    //Update an object
                    db.FacultyName = fl.FacultyName;
                    db.TotalTeacher = fl.TotalTeacher;
                    context.Faculties.AddOrUpdate(fl);
                    context.SaveChanges();
                    FormFaculty_Load(sender, e);
                    MessageBox.Show("Update Faculty Successfully!!!", "Notification");
                }
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
            int temp = int.Parse(txtFalID.Text);
            Faculty dbDelete = context.Faculties.FirstOrDefault(p => p.FacultyID == temp);
            try
            {
                if (dbDelete != null)
                {
                    if (MessageBox.Show("You may want to delete ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.Faculties.Remove(dbDelete);
                        context.SaveChanges();
                        FormFaculty_Load(sender, e);
                        MessageBox.Show("Delete Faculty Successfully!!!", "Notification");
                    }
                }
                clearTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
    }
}
