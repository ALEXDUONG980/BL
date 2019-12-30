namespace FINAL
{
    partial class frmXe
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
            this.gpbDSXe = new System.Windows.Forms.GroupBox();
            this.dgvCNTTXe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMauXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.labGiaBan = new System.Windows.Forms.Label();
            this.labMauXe = new System.Windows.Forms.Label();
            this.labTenXe = new System.Windows.Forms.Label();
            this.labMaXe = new System.Windows.Forms.Label();
            this.gbxThongTinXe = new System.Windows.Forms.GroupBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cmbMaNCC = new System.Windows.Forms.ComboBox();
            this.cmbMaBH = new System.Windows.Forms.ComboBox();
            this.labMaNCC = new System.Windows.Forms.Label();
            this.labNgayLap = new System.Windows.Forms.Label();
            this.labMaBH = new System.Windows.Forms.Label();
            this.txtThongTinNCC = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gpbDSXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTXe)).BeginInit();
            this.gbxThongTinXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDSXe
            // 
            this.gpbDSXe.Controls.Add(this.dgvCNTTXe);
            this.gpbDSXe.Location = new System.Drawing.Point(7, 249);
            this.gpbDSXe.Name = "gpbDSXe";
            this.gpbDSXe.Size = new System.Drawing.Size(786, 189);
            this.gpbDSXe.TabIndex = 18;
            this.gpbDSXe.TabStop = false;
            this.gpbDSXe.Text = "Danh Sách Xe";
            // 
            // dgvCNTTXe
            // 
            this.dgvCNTTXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCNTTXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column7});
            this.dgvCNTTXe.Location = new System.Drawing.Point(21, 17);
            this.dgvCNTTXe.Name = "dgvCNTTXe";
            this.dgvCNTTXe.Size = new System.Drawing.Size(741, 166);
            this.dgvCNTTXe.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Xe";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Xe";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Màu Xe";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã BH";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã NCC";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gía Bán";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày Lập";
            this.Column7.Name = "Column7";
            // 
            // txtMauXe
            // 
            this.txtMauXe.Location = new System.Drawing.Point(101, 96);
            this.txtMauXe.Name = "txtMauXe";
            this.txtMauXe.Size = new System.Drawing.Size(252, 24);
            this.txtMauXe.TabIndex = 1;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(101, 62);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(252, 24);
            this.txtTenXe.TabIndex = 1;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(101, 29);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(252, 24);
            this.txtMaXe.TabIndex = 1;
            // 
            // labGiaBan
            // 
            this.labGiaBan.AutoSize = true;
            this.labGiaBan.Location = new System.Drawing.Point(418, 68);
            this.labGiaBan.Name = "labGiaBan";
            this.labGiaBan.Size = new System.Drawing.Size(65, 18);
            this.labGiaBan.TabIndex = 0;
            this.labGiaBan.Text = "Gía Bán:";
            // 
            // labMauXe
            // 
            this.labMauXe.AutoSize = true;
            this.labMauXe.Location = new System.Drawing.Point(18, 102);
            this.labMauXe.Name = "labMauXe";
            this.labMauXe.Size = new System.Drawing.Size(63, 18);
            this.labMauXe.TabIndex = 0;
            this.labMauXe.Text = "Màu Xe:";
            // 
            // labTenXe
            // 
            this.labTenXe.AutoSize = true;
            this.labTenXe.Location = new System.Drawing.Point(22, 68);
            this.labTenXe.Name = "labTenXe";
            this.labTenXe.Size = new System.Drawing.Size(59, 18);
            this.labTenXe.TabIndex = 0;
            this.labTenXe.Text = "Tên Xe:";
            // 
            // labMaXe
            // 
            this.labMaXe.AutoSize = true;
            this.labMaXe.Location = new System.Drawing.Point(26, 35);
            this.labMaXe.Name = "labMaXe";
            this.labMaXe.Size = new System.Drawing.Size(55, 18);
            this.labMaXe.TabIndex = 0;
            this.labMaXe.Text = "Mã Xe:";
            // 
            // gbxThongTinXe
            // 
            this.gbxThongTinXe.Controls.Add(this.dtNgayLap);
            this.gbxThongTinXe.Controls.Add(this.txtGiaBan);
            this.gbxThongTinXe.Controls.Add(this.cmbMaNCC);
            this.gbxThongTinXe.Controls.Add(this.cmbMaBH);
            this.gbxThongTinXe.Controls.Add(this.txtMauXe);
            this.gbxThongTinXe.Controls.Add(this.txtTenXe);
            this.gbxThongTinXe.Controls.Add(this.txtMaXe);
            this.gbxThongTinXe.Controls.Add(this.labMaNCC);
            this.gbxThongTinXe.Controls.Add(this.labNgayLap);
            this.gbxThongTinXe.Controls.Add(this.labGiaBan);
            this.gbxThongTinXe.Controls.Add(this.labMaBH);
            this.gbxThongTinXe.Controls.Add(this.labMauXe);
            this.gbxThongTinXe.Controls.Add(this.labTenXe);
            this.gbxThongTinXe.Controls.Add(this.labMaXe);
            this.gbxThongTinXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinXe.Location = new System.Drawing.Point(7, 62);
            this.gbxThongTinXe.Name = "gbxThongTinXe";
            this.gbxThongTinXe.Size = new System.Drawing.Size(786, 134);
            this.gbxThongTinXe.TabIndex = 12;
            this.gbxThongTinXe.TabStop = false;
            this.gbxThongTinXe.Text = "Nhập Thông Tin Xe";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Location = new System.Drawing.Point(495, 97);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(272, 24);
            this.dtNgayLap.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(495, 65);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(272, 24);
            this.txtGiaBan.TabIndex = 3;
            // 
            // cmbMaNCC
            // 
            this.cmbMaNCC.FormattingEnabled = true;
            this.cmbMaNCC.Location = new System.Drawing.Point(641, 29);
            this.cmbMaNCC.Name = "cmbMaNCC";
            this.cmbMaNCC.Size = new System.Drawing.Size(126, 26);
            this.cmbMaNCC.TabIndex = 2;
            // 
            // cmbMaBH
            // 
            this.cmbMaBH.FormattingEnabled = true;
            this.cmbMaBH.Location = new System.Drawing.Point(437, 29);
            this.cmbMaBH.Name = "cmbMaBH";
            this.cmbMaBH.Size = new System.Drawing.Size(127, 26);
            this.cmbMaBH.TabIndex = 2;
            // 
            // labMaNCC
            // 
            this.labMaNCC.AutoSize = true;
            this.labMaNCC.Location = new System.Drawing.Point(570, 35);
            this.labMaNCC.Name = "labMaNCC";
            this.labMaNCC.Size = new System.Drawing.Size(70, 18);
            this.labMaNCC.TabIndex = 0;
            this.labMaNCC.Text = "Mã NCC:";
            // 
            // labNgayLap
            // 
            this.labNgayLap.AutoSize = true;
            this.labNgayLap.Location = new System.Drawing.Point(409, 105);
            this.labNgayLap.Name = "labNgayLap";
            this.labNgayLap.Size = new System.Drawing.Size(74, 18);
            this.labNgayLap.TabIndex = 0;
            this.labNgayLap.Text = "Ngày Lập:";
            // 
            // labMaBH
            // 
            this.labMaBH.AutoSize = true;
            this.labMaBH.Location = new System.Drawing.Point(373, 35);
            this.labMaBH.Name = "labMaBH";
            this.labMaBH.Size = new System.Drawing.Size(58, 18);
            this.labMaBH.TabIndex = 0;
            this.labMaBH.Text = "Mã BH:";
            // 
            // txtThongTinNCC
            // 
            this.txtThongTinNCC.AutoSize = true;
            this.txtThongTinNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinNCC.ForeColor = System.Drawing.Color.Purple;
            this.txtThongTinNCC.Location = new System.Drawing.Point(211, 18);
            this.txtThongTinNCC.Name = "txtThongTinNCC";
            this.txtThongTinNCC.Size = new System.Drawing.Size(374, 31);
            this.txtThongTinNCC.TabIndex = 17;
            this.txtThongTinNCC.Text = "CẬP NHẬT THÔNG TIN XE";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FINAL.Properties.Resources.red_delete_button;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(469, 211);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 32);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FINAL.Properties.Resources._1024px_Crystal_Clear_action_exit_svg;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(648, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 32);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::FINAL.Properties.Resources.edit_button_hi1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(257, 211);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 32);
            this.btnSua.TabIndex = 15;
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
            this.btnThem.Location = new System.Drawing.Point(36, 211);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 32);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDSXe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbxThongTinXe);
            this.Controls.Add(this.txtThongTinNCC);
            this.Name = "frmXe";
            this.Text = "frmXe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            this.gpbDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNTTXe)).EndInit();
            this.gbxThongTinXe.ResumeLayout(false);
            this.gbxThongTinXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDSXe;
        private System.Windows.Forms.DataGridView dgvCNTTXe;
        private System.Windows.Forms.TextBox txtMauXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label labGiaBan;
        private System.Windows.Forms.Label labMauXe;
        private System.Windows.Forms.Label labTenXe;
        private System.Windows.Forms.Label labMaXe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gbxThongTinXe;
        private System.Windows.Forms.Label txtThongTinNCC;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cmbMaNCC;
        private System.Windows.Forms.ComboBox cmbMaBH;
        private System.Windows.Forms.Label labNgayLap;
        private System.Windows.Forms.Label labMaBH;
        private System.Windows.Forms.Label labMaNCC;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}