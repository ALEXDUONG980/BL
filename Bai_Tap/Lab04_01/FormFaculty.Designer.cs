namespace Lab04_01
{
    partial class FormFaculty
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd_Update = new System.Windows.Forms.Button();
            this.txtFalName = new System.Windows.Forms.TextBox();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.FalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.gbStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.Location = new System.Drawing.Point(150, 156);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(227, 26);
            this.txtTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Teacher";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd_Update
            // 
            this.btnAdd_Update.Location = new System.Drawing.Point(117, 225);
            this.btnAdd_Update.Name = "btnAdd_Update";
            this.btnAdd_Update.Size = new System.Drawing.Size(99, 30);
            this.btnAdd_Update.TabIndex = 8;
            this.btnAdd_Update.Text = "Add/Update";
            this.btnAdd_Update.UseVisualStyleBackColor = true;
            this.btnAdd_Update.Click += new System.EventHandler(this.btnAdd_Update_Click);
            // 
            // txtFalName
            // 
            this.txtFalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFalName.Location = new System.Drawing.Point(150, 95);
            this.txtFalName.Name = "txtFalName";
            this.txtFalName.Size = new System.Drawing.Size(227, 26);
            this.txtFalName.TabIndex = 5;
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FalID,
            this.FalName,
            this.TotalTeacher});
            this.dgvFaculty.Location = new System.Drawing.Point(411, 12);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(615, 355);
            this.dgvFaculty.TabIndex = 3;
            this.dgvFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellClick);
            // 
            // FalID
            // 
            this.FalID.DataPropertyName = "FalID";
            this.FalID.HeaderText = "Faculty ID";
            this.FalID.MinimumWidth = 6;
            this.FalID.Name = "FalID";
            // 
            // FalName
            // 
            this.FalName.DataPropertyName = "FalName";
            this.FalName.HeaderText = "Faculty Name";
            this.FalName.MinimumWidth = 6;
            this.FalName.Name = "FalName";
            // 
            // TotalTeacher
            // 
            this.TotalTeacher.HeaderText = "Total Teacher";
            this.TotalTeacher.MinimumWidth = 6;
            this.TotalTeacher.Name = "TotalTeacher";
            // 
            // txtFalID
            // 
            this.txtFalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFalID.Location = new System.Drawing.Point(150, 44);
            this.txtFalID.Name = "txtFalID";
            this.txtFalID.Size = new System.Drawing.Size(227, 26);
            this.txtFalID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculty Name";
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.txtTotal);
            this.gbStudent.Controls.Add(this.label5);
            this.gbStudent.Controls.Add(this.btnDelete);
            this.gbStudent.Controls.Add(this.btnAdd_Update);
            this.gbStudent.Controls.Add(this.txtFalName);
            this.gbStudent.Controls.Add(this.txtFalID);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.ForeColor = System.Drawing.Color.Blue;
            this.gbStudent.Location = new System.Drawing.Point(12, 12);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(393, 355);
            this.gbStudent.TabIndex = 2;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Faculty Information";
            // 
            // FormFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 380);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.gbStudent);
            this.Name = "FormFaculty";
            this.Text = "Faculty Manage";
            this.Load += new System.EventHandler(this.FormFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd_Update;
        private System.Windows.Forms.TextBox txtFalName;
        public System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.TextBox txtFalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTeacher;
    }
}