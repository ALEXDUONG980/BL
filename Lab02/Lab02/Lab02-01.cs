using System;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhepCong_Click(object sender, EventArgs e)
        {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 + number2;
        }

        private void btnPhepTru_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float result = number1 - number2;
            txtNumber3.Text = result.ToString();
        }

        private void btnPhepNhan_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float result = number1 * number2;
            txtNumber3.Text = result.ToString();
        }

        private void btnPhepChia_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                if (number2 == 0)
                    throw new Exception("Khong chia cho 0.");
                float result = number1 / number2;
                txtNumber3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
