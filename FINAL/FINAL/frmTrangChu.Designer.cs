namespace FINAL
{
    partial class frmTrangChu
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
            this.lblDesign = new System.Windows.Forms.Label();
            this.btnThoatChuongTrinh = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.lblTrangChu = new System.Windows.Forms.Label();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.Location = new System.Drawing.Point(11, 304);
            this.lblDesign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(166, 17);
            this.lblDesign.TabIndex = 17;
            this.lblDesign.Text = "Designer Thanh Toàn";
            // 
            // btnThoatChuongTrinh
            // 
            this.btnThoatChuongTrinh.BackColor = System.Drawing.Color.Red;
            this.btnThoatChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnThoatChuongTrinh.Location = new System.Drawing.Point(248, 238);
            this.btnThoatChuongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            this.btnThoatChuongTrinh.Size = new System.Drawing.Size(167, 47);
            this.btnThoatChuongTrinh.TabIndex = 14;
            this.btnThoatChuongTrinh.Text = "Thoát";
            this.btnThoatChuongTrinh.UseVisualStyleBackColor = false;
            this.btnThoatChuongTrinh.Click += new System.EventHandler(this.btnThoatChuongTrinh_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnNhaCungCap.Location = new System.Drawing.Point(51, 169);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(167, 47);
            this.btnNhaCungCap.TabIndex = 12;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Yellow;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnKhachHang.Location = new System.Drawing.Point(51, 100);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(167, 47);
            this.btnKhachHang.TabIndex = 11;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangChu.ForeColor = System.Drawing.Color.Red;
            this.lblTrangChu.Location = new System.Drawing.Point(117, 33);
            this.lblTrangChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(230, 39);
            this.lblTrangChu.TabIndex = 9;
            this.lblTrangChu.Text = "TRANG CHỦ";
            // 
            // btnXe
            // 
            this.btnXe.BackColor = System.Drawing.Color.Blue;
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnXe.Location = new System.Drawing.Point(248, 169);
            this.btnXe.Margin = new System.Windows.Forms.Padding(2);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(167, 47);
            this.btnXe.TabIndex = 12;
            this.btnXe.Text = "Thông Tin Xe";
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Lime;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnNhanVien.Location = new System.Drawing.Point(248, 100);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(167, 47);
            this.btnNhanVien.TabIndex = 11;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.Fuchsia;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnHopDong.Location = new System.Drawing.Point(51, 238);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(167, 47);
            this.btnHopDong.TabIndex = 12;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(460, 331);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.btnThoatChuongTrinh);
            this.Controls.Add(this.btnXe);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnNhaCungCap);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.lblTrangChu);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Button btnThoatChuongTrinh;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHopDong;
    }
}