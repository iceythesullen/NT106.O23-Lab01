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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void Lab01_Bai03_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            long number;
            if (!long.TryParse(txtNumber.Text, out number))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string words = NumberToWords(number);
            txtResult.Text = words;
        }

        private string NumberToWords(long number)
        {
            if (number == 0)
                return "Không";

            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] thousands = { "", "ngàn", "triệu", "tỷ", "nghìn tỷ", "triệu tỷ", "tỷ tỷ" }; // Thêm các chuỗi hàng nghìn tỷ, triệu tỷ, tỷ tỷ để hỗ trợ số có từ 1 đến 12 chữ số.

            string words = "";

            int groupIndex = 0; // Biến để lưu chỉ số của hàng nghìn, triệu, tỷ...
            while (number > 0)
            {
                int currentGroup = (int)(number % 1000);
                if (currentGroup != 0)
                {
                    words = $"{NumberToWordsUnder1000(currentGroup, ones, tens)} {thousands[groupIndex]} {words}";
                }
                number /= 1000;
                groupIndex++;
            }

            return words.Trim();
        }

        private string NumberToWordsUnder1000(int number, string[] ones, string[] tens)
        {
            string words = "";

            if (number >= 100)
            {
                words += $"{ones[number / 100]} trăm ";
                number %= 100;
            }

            if (number >= 10 && number <= 19)
            {
                words += $"{tens[number % 10]} ";
                return words;
            }
            else if (number >= 20)
            {
                words += $"{ones[number / 10]} mươi ";
                number %= 10;
            }

            if (number > 0)
            {
                words += $"{ones[number]} ";
            }

            return words;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtNumber.Clear();
        }
    }
}
