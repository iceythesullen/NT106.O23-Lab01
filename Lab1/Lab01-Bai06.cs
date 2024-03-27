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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void Lab01_Bai06_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Lấy ngày tháng năm sinh từ DateTimePicker
            DateTime dateOfBirth = dtpDateOfBirth.Value;

            // Xác định cung hoàng đạo
            string zodiacSign = DetermineZodiacSign(dateOfBirth.Month, dateOfBirth.Day);

            // Hiển thị kết quả
            MessageBox.Show($"Cung hoàng đạo của bạn là: {zodiacSign}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string DetermineZodiacSign(int month, int day)
        {
            // Xác định cung hoàng đạo dựa trên tháng và ngày
            switch (month)
            {
                case 3:
                    return (day >= 21) ? "Bạch Dương" : "Song Ngư";
                case 4:
                    return (day <= 20) ? "Bạch Dương" : "Kim Ngưu";
                case 5:
                    return (day <= 21) ? "Kim Ngưu" : "Song Tử";
                case 6:
                    return (day <= 21) ? "Song Tử" : "Cự Giải";
                case 7:
                    return (day <= 22) ? "Cự Giải" : "Sư Tử";
                case 8:
                    return (day <= 22) ? "Sư Tử" : "Xử Nữ";
                case 9:
                    return (day <= 23) ? "Xử Nữ" : "Thiên Bình";
                case 10:
                    return (day <= 23) ? "Thiên Bình" : "Thần Nông";
                case 11:
                    return (day <= 22) ? "Thần Nông" : "Nhân Mã";
                case 12:
                    return (day <= 21) ? "Nhân Mã" : "Ma Kết";
                case 1:
                    return (day <= 20) ? "Ma Kết" : "Bảo Bình";
                case 2:
                    return (day <= 19) ? "Bảo Bình" : "Song Ngư";
                default:
                    return "";
            }
        }
    }
}
