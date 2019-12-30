namespace FINAL
{
    partial class frmCNTTNV
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
            this.gbxThongTinNV = new System.Windows.Forms.GroupBox();
            this.dtNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labChucVu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labMaNV = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.Label();
            this.gpbDSNV = new System.Windows.Forms.GroupBox();
            this.dgvCNTTNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxThongTinNV.SuspendLayout();
            this.gpbDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxThongTinNV
            // 
            this.gbxThongTinNV.Controls.Add(this.dtNgayVaoLam);
            this.gbxThongTinNV.Controls.Add(this.dtNgaySinh);
            this.gbxThongTinNV.Controls.Add(this.rdoNu);
            this.gbxThongTinNV.Controls.Add(this.rdoNam);
            this.gbxThongTinNV.Controls.Add(this.txtChucVu);
            this.gbxThongTinNV.Controls.Add(this.txtSDT);
            this.gbxThongTinNV.Controls.Add(this.txtDiaChi);
            this.gbxThongTinNV.Controls.Add(this.txtHoTen);
            this.gbxThongTinNV.Controls.Add(this.txtMaNV);
            this.gbxThongTinNV.Controls.Add(this.label4);
            this.gbxThongTinNV.Controls.Add(this.labChucVu);
            this.gbxThongTinNV.Controls.Add(this.label7);
            this.gbxThongTinNV.Controls.Add(this.labSDT);
            this.gbxThongTinNV.Controls.Add(this.labDiaChi);
            this.gbxThongTinNV.Controls.Add(this.labGioiTinh);
            this.gbxThongTinNV.Controls.Add(this.labHoTen);
            this.gbxThongTinNV.Controls.Add(this.labMaNV);
            this.gbxThongTinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinNV.Location = new System.Drawing.Point(12, 53);
            this.gbxThongTinNV.Name = "gbxThongTinNV";
            this.gbxThongTinNV.Size = new System.Drawing.Size(786, 169);
            this.gbxThongTinNV.TabIndex = 0;
            this.gbxThongTinNV.TabStop = false;
            this.gbxThongTinNV.Text = "Nhập Thông Tin Nhân Viên";
            // 
            // dtNgayVaoLam
            // 
            this.dtNgayVaoLam.Location = new System.Drawing.Point(538, 132);
            this.dtNgayVaoLam.Name = "dtNgayVaoLam";
            this.dtNgayVaoLam.Size = new System.Drawing.Size(228, 24);
            this.dtNgayVaoLam.TabIndex = 6;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(101, 132);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(252, 24);
            this.dtNgaySinh.TabIndex = 6;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(243, 100);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 22);
            this.rdoNu.TabIndex = 5;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(117, 98);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 22);
            this.rdoNam.TabIndex = 4;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(538, 94);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(228, 24);
            this.txtChucVu.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(538, 62);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 24);
            this.txtSDT.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(538, 29);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 24);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(101, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(252, 24);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(101, 29);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(252, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh:";
            // 
            // labChucVu
            // 
            this.labChucVu.AutoSize = true;
            this.labChucVu.Location = new System.Drawing.Point(442, 102);
            this.labChucVu.Name = "labChucVu";
            this.labChucVu.Size = new System.Drawing.Size(68, 18);
            this.labChucVu.TabIndex = 0;
            this.labChucVu.Text = "Chức Vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Vào Làm:";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(468, 68);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(42, 18);
            this.labSDT.TabIndex = 0;
            this.labSDT.Text = "SĐT:";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(450, 35);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(60, 18);
            this.labDiaChi.TabIndex = 0;
            this.labDiaChi.Text = "Địa Chỉ:";
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Location = new System.Drawing.Point(16, 100);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(71, 18);
            this.labGioiTinh.TabIndex = 0;
            this.labGioiTinh.Text = "Giới Tính:";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(26, 68);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(61, 18);
            this.labHoTen.TabIndex = 0;
            this.labHoTen.Text = "Họ Tên:";
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Location = new System.Drawing.Point(30, 35);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(57, 18);
            this.labMaNV.TabIndex = 0;
            this.labMaNV.Text = "Mã NV:";
            // 
            // txtThongTin
            // 
            this.txtThongTin.AutoSize = true;
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.ForeColor = System.Drawing.Color.Navy;
            this.txtThongTin.Location = new System.Drawing.Point(168, 19);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(494, 31);
            this.txtThongTin.TabIndex = 2;
            this.txtThongTin.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
            // 
            // gpbDSNV
            // 
            this.gpbDSNV.Controls.Add(this.dgvCNTTNV);
            this.gpbDSNV.Location = new System.Drawing.Point(12, 293);
            this.gpbDSNV.Name = "gpbDSNV";
            this.gpbDSNV.Size = new System.Drawing.Size(786, 168);
            this.gpbDSNV.TabIndex = 3;
            this.gpbDSNV.TabStop = false;
            this.gpbDSNV.Text = "Danh Sách Nhân Viên";
            // 
            // dgvCNTTNV
            // 
            this.dgvCNTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCNTTNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvCNTTNV.Location = new System.Drawing.Point(6, 19);
            this.dgvCNTTNV.Name = "dgvCNTTNV";
            this.dgvCNTTNV.Size = new System.Drawing.Size(774, 145);
            this.dgvCNTTNV.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SĐT";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Chức Vụ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngay Vào Làm";
            this.Column8.Name = "Column8";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FINAL.Properties.Resources.red_delete_button;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(457, 245);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 32);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FINAL.Properties.Resources._1024px_Crystal_Clear_action_exit_svg;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(643, 245);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::FINAL.Properties.Resources.edit_button_hi1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(243, 245);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::FINAL.Properties.Resources.add_button1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(41, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmCNTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(810, 473);
            this.Controls.Add(this.gpbDSNV);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbxThongTinNV);
            this.Name = "frmCNTTNV";
            this.Text = "Cập Nhât Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.frmCNTTNV_Load);
            this.gbxThongTinNV.ResumeLayout(false);
            this.gbxThongTinNV.PerformLayout();
            this.gpbDSNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThongTinNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labMaNV;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label txtThongTin;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label labChucVu;
        private System.Windows.Forms.GroupBox gpbDSNV;
        private System.Windows.Forms.DataGridView dgvCNTTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DateTimePicker dtNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}

