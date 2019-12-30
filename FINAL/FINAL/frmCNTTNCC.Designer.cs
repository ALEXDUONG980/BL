namespace FINAL
{
    partial class frmCNTTNCC
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
            this.txtThongTinNCC = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxThongTinNCC = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.labeEmail = new System.Windows.Forms.Label();
            this.labSDTNCC = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labTenNCC = new System.Windows.Forms.Label();
            this.labMaNCC = new System.Windows.Forms.Label();
            this.dgvCNTTNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDSNCC = new System.Windows.Forms.GroupBox();
            this.gbxThongTinNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTNCC)).BeginInit();
            this.gpbDSNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThongTinNCC
            // 
            this.txtThongTinNCC.AutoSize = true;
            this.txtThongTinNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinNCC.ForeColor = System.Drawing.Color.Purple;
            this.txtThongTinNCC.Location = new System.Drawing.Point(144, 9);
            this.txtThongTinNCC.Name = "txtThongTinNCC";
            this.txtThongTinNCC.Size = new System.Drawing.Size(557, 31);
            this.txtThongTinNCC.TabIndex = 10;
            this.txtThongTinNCC.Text = "CẬP NHẬT THÔNG TIN NHÀ CUNG CẤP";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FINAL.Properties.Resources.red_delete_button;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(469, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FINAL.Properties.Resources._1024px_Crystal_Clear_action_exit_svg;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(648, 187);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::FINAL.Properties.Resources.edit_button_hi1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(257, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 32);
            this.btnSua.TabIndex = 7;
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
            this.btnThem.Location = new System.Drawing.Point(36, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbxThongTinNCC
            // 
            this.gbxThongTinNCC.Controls.Add(this.txtEmail);
            this.gbxThongTinNCC.Controls.Add(this.txtSDTNCC);
            this.gbxThongTinNCC.Controls.Add(this.txtDiaChiNCC);
            this.gbxThongTinNCC.Controls.Add(this.txtTenNCC);
            this.gbxThongTinNCC.Controls.Add(this.txtMaNCC);
            this.gbxThongTinNCC.Controls.Add(this.labeEmail);
            this.gbxThongTinNCC.Controls.Add(this.labSDTNCC);
            this.gbxThongTinNCC.Controls.Add(this.labDiaChi);
            this.gbxThongTinNCC.Controls.Add(this.labTenNCC);
            this.gbxThongTinNCC.Controls.Add(this.labMaNCC);
            this.gbxThongTinNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinNCC.Location = new System.Drawing.Point(7, 38);
            this.gbxThongTinNCC.Name = "gbxThongTinNCC";
            this.gbxThongTinNCC.Size = new System.Drawing.Size(786, 134);
            this.gbxThongTinNCC.TabIndex = 4;
            this.gbxThongTinNCC.TabStop = false;
            this.gbxThongTinNCC.Text = "Nhập Thông Tin Nhà Cung Cấp";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(509, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(509, 32);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(257, 24);
            this.txtSDTNCC.TabIndex = 1;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(101, 96);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(252, 24);
            this.txtDiaChiNCC.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(101, 62);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(252, 24);
            this.txtTenNCC.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(101, 29);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(252, 24);
            this.txtMaNCC.TabIndex = 1;
            // 
            // labeEmail
            // 
            this.labeEmail.AutoSize = true;
            this.labeEmail.Location = new System.Drawing.Point(442, 68);
            this.labeEmail.Name = "labeEmail";
            this.labeEmail.Size = new System.Drawing.Size(49, 18);
            this.labeEmail.TabIndex = 0;
            this.labeEmail.Text = "Email:";
            // 
            // labSDTNCC
            // 
            this.labSDTNCC.AutoSize = true;
            this.labSDTNCC.Location = new System.Drawing.Point(442, 38);
            this.labSDTNCC.Name = "labSDTNCC";
            this.labSDTNCC.Size = new System.Drawing.Size(42, 18);
            this.labSDTNCC.TabIndex = 0;
            this.labSDTNCC.Text = "SĐT:";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(26, 100);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(60, 18);
            this.labDiaChi.TabIndex = 0;
            this.labDiaChi.Text = "Địa Chỉ:";
            // 
            // labTenNCC
            // 
            this.labTenNCC.AutoSize = true;
            this.labTenNCC.Location = new System.Drawing.Point(12, 68);
            this.labTenNCC.Name = "labTenNCC";
            this.labTenNCC.Size = new System.Drawing.Size(74, 18);
            this.labTenNCC.TabIndex = 0;
            this.labTenNCC.Text = "Tên NCC:";
            // 
            // labMaNCC
            // 
            this.labMaNCC.AutoSize = true;
            this.labMaNCC.Location = new System.Drawing.Point(16, 35);
            this.labMaNCC.Name = "labMaNCC";
            this.labMaNCC.Size = new System.Drawing.Size(70, 18);
            this.labMaNCC.TabIndex = 0;
            this.labMaNCC.Text = "Mã NCC:";
            // 
            // dgvCNTTNCC
            // 
            this.dgvCNTTNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCNTTNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dgvCNTTNCC.Location = new System.Drawing.Point(101, 17);
            this.dgvCNTTNCC.Name = "dgvCNTTNCC";
            this.dgvCNTTNCC.Size = new System.Drawing.Size(544, 145);
            this.dgvCNTTNCC.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
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
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // gpbDSNCC
            // 
            this.gpbDSNCC.Controls.Add(this.dgvCNTTNCC);
            this.gpbDSNCC.Location = new System.Drawing.Point(7, 225);
            this.gpbDSNCC.Name = "gpbDSNCC";
            this.gpbDSNCC.Size = new System.Drawing.Size(786, 168);
            this.gpbDSNCC.TabIndex = 11;
            this.gpbDSNCC.TabStop = false;
            this.gpbDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // frmCNTTNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.txtThongTinNCC);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbxThongTinNCC);
            this.Controls.Add(this.gpbDSNCC);
            this.Name = "frmCNTTNCC";
            this.Text = "frmCNTTNCC";
            this.Load += new System.EventHandler(this.frmCNTTNCC_Load);
            this.gbxThongTinNCC.ResumeLayout(false);
            this.gbxThongTinNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTNCC)).EndInit();
            this.gpbDSNCC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtThongTinNCC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbxThongTinNCC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label labeEmail;
        private System.Windows.Forms.Label labSDTNCC;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labTenNCC;
        private System.Windows.Forms.Label labMaNCC;
        private System.Windows.Forms.DataGridView dgvCNTTNCC;
        private System.Windows.Forms.GroupBox gpbDSNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}