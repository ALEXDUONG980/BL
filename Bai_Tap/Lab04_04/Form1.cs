using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_04
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        //EVENT FOR LOAD FORM PRODUCT MANAGEMENT
        private void FormProduct_Load(object sender, EventArgs e)
        {
            try
            {
                //Always use context to work with class
                ContextDB_Lab04_04 context = new ContextDB_Lab04_04();
                //Get all faculties from the faculty table
                List<Invoice> listInvoice = context.Invoices.ToList();
                List<Order> listOrder = context.Orders.ToList();
                foreach (var item in listOrder)
                {
                    //dgvProduct.Rows
                }
                BindGrip(listInvoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //THE BINDING LIST DATA FUNCTION
        private void BindGrip(List<Invoice> listInvoice)
        {
            dgvProduct.Rows.Clear();
            foreach (var item1 in listInvoice)
            {
                int index = dgvProduct.Rows.Add();
                dgvProduct.Rows[index].Cells[1].Value = item1.InvoiceNo;
                dgvProduct.Rows[index].Cells[2].Value = item1.OrderDate;
                dgvProduct.Rows[index].Cells[3].Value = item1.DeliveryDate;
            }
        }
    }
}
