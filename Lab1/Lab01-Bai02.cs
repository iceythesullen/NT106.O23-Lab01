using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumber1.Text, out double number1) ||
               !double.TryParse(txtNumber2.Text, out double number2) ||
               !double.TryParse(txtNumber3.Text, out double number3))
            {
                MessageBox.Show("Vui lòng nhập ba số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double maxNumber, minNumber;
            if (number1 >= number2 && number1 >= number3)
            {
                maxNumber = number1;
                minNumber = Math.Min(number2, number3);
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                maxNumber = number2;
                minNumber = Math.Min(number1, number3);
            }
            else
            {
                maxNumber = number3;
                minNumber = Math.Min(number1, number2);
            }

            // Hiển thị số lớn nhất và nhỏ nhất trong hai TextBox
            txtMax.Text = maxNumber.ToString();
            txtMin.Text = minNumber.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNumber3.Clear();
            txtMax.Clear();
            txtMin.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab01_Bai02_Load(object sender, EventArgs e)
        {

        }
    }
}
