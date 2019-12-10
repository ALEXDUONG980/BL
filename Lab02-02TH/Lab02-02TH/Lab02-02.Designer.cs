namespace Lab02_02TH
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Huy = new System.Windows.Forms.Button();
            this.Chon = new System.Windows.Forms.Button();
            this.KetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAN HINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(152, 296);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(194, 29);
            this.txtThanhTien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thanh Tien";
            // 
            // Huy
            // 
            this.Huy.Location = new System.Drawing.Point(152, 331);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(75, 48);
            this.Huy.TabIndex = 4;
            this.Huy.Text = "HUY";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // Chon
            // 
            this.Chon.Location = new System.Drawing.Point(49, 331);
            this.Chon.Name = "Chon";
            this.Chon.Size = new System.Drawing.Size(75, 48);
            this.Chon.TabIndex = 5;
            this.Chon.Text = "CHON";
            this.Chon.UseVisualStyleBackColor = true;
            this.Chon.Click += new System.EventHandler(this.Chon_Click);
            // 
            // KetThuc
            // 
            this.KetThuc.Location = new System.Drawing.Point(257, 331);
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.Size = new System.Drawing.Size(75, 48);
            this.KetThuc.TabIndex = 6;
            this.KetThuc.Text = "KET THUC";
            this.KetThuc.UseVisualStyleBackColor = true;
            this.KetThuc.Click += new System.EventHandler(this.KetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 398);
            this.Controls.Add(this.KetThuc);
            this.Controls.Add(this.Chon);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Button Chon;
        private System.Windows.Forms.Button KetThuc;
    }
}

