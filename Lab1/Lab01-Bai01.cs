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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ hai số hay chưa
            if (!int.TryParse(txtNumber1.Text, out int number1) || !int.TryParse(txtNumber2.Text, out int number2))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính tổng của hai số
            int sum = number1 + number2;

            // Hiển thị kết quả
            MessageBox.Show($"Tổng của {number1} và {number2} là {sum}.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
