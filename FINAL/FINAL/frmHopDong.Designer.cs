namespace FINAL
{
    partial class frmHopDong
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
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.labMaNV = new System.Windows.Forms.Label();
            this.labNgayLap = new System.Windows.Forms.Label();
            this.labMaKH = new System.Windows.Forms.Label();
            this.dgvCNTTHD = new System.Windows.Forms.DataGridView();
            this.gpbDSHopDong = new System.Windows.Forms.GroupBox();
            this.gbxThongTinHopDong = new System.Windows.Forms.GroupBox();
            this.cmbMaXe = new System.Windows.Forms.ComboBox();
            this.labMaXe = new System.Windows.Forms.Label();
            this.labMaHD = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTHD)).BeginInit();
            this.gpbDSHopDong.SuspendLayout();
            this.gbxThongTinHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThongTinNCC
            // 
            this.txtThongTinNCC.AutoSize = true;
            this.txtThongTinNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinNCC.ForeColor = System.Drawing.Color.Maroon;
            this.txtThongTinNCC.Location = new System.Drawing.Point(131, 9);
            this.txtThongTinNCC.Name = "txtThongTinNCC";
            this.txtThongTinNCC.Size = new System.Drawing.Size(492, 31);
            this.txtThongTinNCC.TabIndex = 24;
            this.txtThongTinNCC.Text = "CẬP NHẬT THÔNG TIN HỢP ĐỒNG";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Location = new System.Drawing.Point(502, 67);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(255, 24);
            this.dtNgayLap.TabIndex = 4;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(85, 102);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(255, 26);
            this.cmbMaNV.TabIndex = 2;
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(85, 65);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(255, 26);
            this.cmbMaKH.TabIndex = 2;
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Location = new System.Drawing.Point(18, 105);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(57, 18);
            this.labMaNV.TabIndex = 0;
            this.labMaNV.Text = "Mã NV:";
            // 
            // labNgayLap
            // 
            this.labNgayLap.AutoSize = true;
            this.labNgayLap.Location = new System.Drawing.Point(422, 71);
            this.labNgayLap.Name = "labNgayLap";
            this.labNgayLap.Size = new System.Drawing.Size(74, 18);
            this.labNgayLap.TabIndex = 0;
            this.labNgayLap.Text = "Ngày Lập:";
            // 
            // labMaKH
            // 
            this.labMaKH.AutoSize = true;
            this.labMaKH.Location = new System.Drawing.Point(17, 68);
            this.labMaKH.Name = "labMaKH";
            this.labMaKH.Size = new System.Drawing.Size(58, 18);
            this.labMaKH.TabIndex = 0;
            this.labMaKH.Text = "Mã KH:";
            // 
            // dgvCNTTHD
            // 
            this.dgvCNTTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCNTTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCNTTHD.Location = new System.Drawing.Point(115, 19);
            this.dgvCNTTHD.Name = "dgvCNTTHD";
            this.dgvCNTTHD.Size = new System.Drawing.Size(543, 166);
            this.dgvCNTTHD.TabIndex = 4;
            // 
            // gpbDSHopDong
            // 
            this.gpbDSHopDong.Controls.Add(this.dgvCNTTHD);
            this.gpbDSHopDong.Location = new System.Drawing.Point(7, 246);
            this.gpbDSHopDong.Name = "gpbDSHopDong";
            this.gpbDSHopDong.Size = new System.Drawing.Size(786, 189);
            this.gpbDSHopDong.TabIndex = 25;
            this.gpbDSHopDong.TabStop = false;
            this.gpbDSHopDong.Text = "Danh Sách Hợp Đồng";
            // 
            // gbxThongTinHopDong
            // 
            this.gbxThongTinHopDong.Controls.Add(this.txtMaHD);
            this.gbxThongTinHopDong.Controls.Add(this.dtNgayLap);
            this.gbxThongTinHopDong.Controls.Add(this.cmbMaNV);
            this.gbxThongTinHopDong.Controls.Add(this.cmbMaXe);
            this.gbxThongTinHopDong.Controls.Add(this.cmbMaKH);
            this.gbxThongTinHopDong.Controls.Add(this.labMaNV);
            this.gbxThongTinHopDong.Controls.Add(this.labNgayLap);
            this.gbxThongTinHopDong.Controls.Add(this.labMaXe);
            this.gbxThongTinHopDong.Controls.Add(this.labMaHD);
            this.gbxThongTinHopDong.Controls.Add(this.labMaKH);
            this.gbxThongTinHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinHopDong.Location = new System.Drawing.Point(7, 59);
            this.gbxThongTinHopDong.Name = "gbxThongTinHopDong";
            this.gbxThongTinHopDong.Size = new System.Drawing.Size(786, 134);
            this.gbxThongTinHopDong.TabIndex = 19;
            this.gbxThongTinHopDong.TabStop = false;
            this.gbxThongTinHopDong.Text = "Nhập Thông Tin Hợp Đồng";
            // 
            // cmbMaXe
            // 
            this.cmbMaXe.FormattingEnabled = true;
            this.cmbMaXe.Location = new System.Drawing.Point(502, 26);
            this.cmbMaXe.Name = "cmbMaXe";
            this.cmbMaXe.Size = new System.Drawing.Size(255, 26);
            this.cmbMaXe.TabIndex = 2;
            // 
            // labMaXe
            // 
            this.labMaXe.AutoSize = true;
            this.labMaXe.Location = new System.Drawing.Point(438, 32);
            this.labMaXe.Name = "labMaXe";
            this.labMaXe.Size = new System.Drawing.Size(55, 18);
            this.labMaXe.TabIndex = 0;
            this.labMaXe.Text = "Mã Xe:";
            // 
            // labMaHD
            // 
            this.labMaHD.AutoSize = true;
            this.labMaHD.Location = new System.Drawing.Point(18, 34);
            this.labMaHD.Name = "labMaHD";
            this.labMaHD.Size = new System.Drawing.Size(59, 18);
            this.labMaHD.TabIndex = 0;
            this.labMaHD.Text = "Mã HĐ:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FINAL.Properties.Resources.red_delete_button;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(469, 208);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 32);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FINAL.Properties.Resources._1024px_Crystal_Clear_action_exit_svg;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(648, 208);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 32);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::FINAL.Properties.Resources.add_button1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(36, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 32);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::FINAL.Properties.Resources.edit_button_hi1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(257, 208);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 32);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã KH";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ma NV";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã Xe";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày Lập";
            this.Column7.Name = "Column7";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(85, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(255, 24);
            this.txtMaHD.TabIndex = 5;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtThongTinNCC);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gpbDSHopDong);
            this.Controls.Add(this.gbxThongTinHopDong);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTHD)).EndInit();
            this.gpbDSHopDong.ResumeLayout(false);
            this.gbxThongTinHopDong.ResumeLayout(false);
            this.gbxThongTinHopDong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtThongTinNCC;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.Label labMaNV;
        private System.Windows.Forms.Label labNgayLap;
        private System.Windows.Forms.Label labMaKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvCNTTHD;
        private System.Windows.Forms.GroupBox gpbDSHopDong;
        private System.Windows.Forms.GroupBox gbxThongTinHopDong;
        private System.Windows.Forms.ComboBox cmbMaXe;
        private System.Windows.Forms.Label labMaXe;
        private System.Windows.Forms.Label labMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtMaHD;
    }
}