using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02TH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.White;

                btn.Size = new System.Drawing.Size(55, 55);
                btn.TabIndex = i + 1;
                btn.Text = (i+1).ToString();
                btn.UseVisualStyleBackColor = false ;
            

                int x = 17 + (i % 5) * 60;
                int y = 29 + (i / 5) * 70;
                btn.Location = new System.Drawing.Point(x, y);
                btn.Click += new System.EventHandler(this.btnChoseASeat_Click);
                this.groupBox1.Controls.Add(btn);
            }
        }

        private void btnChoseASeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Blue;
            else if (btn.BackColor == Color.Blue)
                btn.BackColor = Color.White;
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghe da duoc ban. ");
        }

        private void Chon_Click(object sender, EventArgs e)
        {
            int Tien = 0;
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if(ctr.BackColor == Color.Blue)
                {
                    ctr.BackColor = Color.Yellow;
                    if (int.Parse(ctr.Text) < 6)
                        Tien += 5000;
                    else if(int.Parse(ctr.Text) < 11)
                        Tien += 6500;
                    else if(int.Parse(ctr.Text) < 15)
                        Tien += 8000;
                }
            }
            txtThanhTien.Text = Tien.ToString();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr.BackColor == Color.Blue)
                {
                    ctr.BackColor = Color.White;
                    
                }
                txtThanhTien.Text = "0";
            }         
        }

        private void KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
