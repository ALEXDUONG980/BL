namespace Lab05_01a
{
    partial class frmXuatReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReport = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.cmbChon = new System.Windows.Forms.ComboBox();
            this.rdoGiaoHang = new System.Windows.Forms.RadioButton();
            this.rdoBaoGia = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(802, 156);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Xuat Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.cmbChon);
            this.gb1.Controls.Add(this.rdoGiaoHang);
            this.gb1.Controls.Add(this.rdoBaoGia);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(879, 134);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // cmbChon
            // 
            this.cmbChon.FormattingEnabled = true;
            this.cmbChon.Location = new System.Drawing.Point(571, 86);
            this.cmbChon.Name = "cmbChon";
            this.cmbChon.Size = new System.Drawing.Size(215, 21);
            this.cmbChon.TabIndex = 2;
            // 
            // rdoGiaoHang
            // 
            this.rdoGiaoHang.AutoSize = true;
            this.rdoGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGiaoHang.Location = new System.Drawing.Point(6, 82);
            this.rdoGiaoHang.Name = "rdoGiaoHang";
            this.rdoGiaoHang.Size = new System.Drawing.Size(185, 24);
            this.rdoGiaoHang.TabIndex = 1;
            this.rdoGiaoHang.TabStop = true;
            this.rdoGiaoHang.Text = "Xem Phieu Giao Hang";
            this.rdoGiaoHang.UseVisualStyleBackColor = true;
            // 
            // rdoBaoGia
            // 
            this.rdoBaoGia.AutoSize = true;
            this.rdoBaoGia.Checked = true;
            this.rdoBaoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBaoGia.Location = new System.Drawing.Point(6, 19);
            this.rdoBaoGia.Name = "rdoBaoGia";
            this.rdoBaoGia.Size = new System.Drawing.Size(242, 24);
            this.rdoBaoGia.TabIndex = 0;
            this.rdoBaoGia.TabStop = true;
            this.rdoBaoGia.Text = "Xem Bang Bao Gia San Pham";
            this.rdoBaoGia.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 185);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(879, 367);
            this.reportViewer1.TabIndex = 2;
            // 
            // frmXuatReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 564);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnReport);
            this.Name = "frmXuatReport";
            this.Text = "Xuat Thong Tin Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ComboBox cmbChon;
        private System.Windows.Forms.RadioButton rdoGiaoHang;
        private System.Windows.Forms.RadioButton rdoBaoGia;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

