using Lab05_01a.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_01a
{
    public partial class frmXuatReport : Form
    {
        public frmXuatReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<Invoice> list = context.Invoices.ToList();
            InvoiceCombobox(list);
          
        }
        private void InvoiceCombobox (List<Invoice> list)
        {
            Model1 context = new Model1();
            this.cmbChon.DataSource = list;
            this.cmbChon.ValueMember = "InvoiceNo";
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            //Lay tat ca cac san pham
            Model1 context = new Model1();
            List<Product> listProduct = context.Products.ToList();
            if (rdoBaoGia.Checked == true) //TH báo giá
            {
                
                this.reportViewer1.LocalReport.ReportPath = "ProductDataSet.rdlc"; //nhớ copy report ra debug               
                var reportDataSource = new ReportDataSource("DataSet1", listProduct);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Bảng Báo Giá";
                this.reportViewer1.RefreshReport();

            }
            else //TH chi tiết đơn hàng
            {
                Invoice invoice = context.Invoices.FirstOrDefault(p => p.InvoiceNo == cmbChon.Text);
                List<Order> listOrder = context.Orders.Where(p => p.InvoiceNo == cmbChon.Text).ToList();
                if (invoice == null || listOrder.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                    return;
                }

                //Sử dụng 2 tham số truyển vào cho report
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("so", invoice.InvoiceNo);
                param[1] = new ReportParameter("giaohang", string.Format("Ngày " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.ReportPath = "OderDataSet.rdlc"; //nhớ copyreport ra debug      
                this.reportViewer1.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("DataSet1", listOrder);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Phiếu giao hàng"; //tên hiển thị            
            }
            this.reportViewer1.RefreshReport();
        }

    }
}
