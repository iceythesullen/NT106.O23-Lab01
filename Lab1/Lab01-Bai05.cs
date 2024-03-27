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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void btnMultiplicationTable_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập số nguyên B chưa
            if (!int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị bảng cửu chương cho số B vào ListBox
            DisplayMultiplicationTable(B);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập số nguyên A và B chưa
            if (!int.TryParse(txtA.Text, out int A) || !int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên A và B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính và hiển thị các phép toán vào ListBox
            CalculateAndDisplayResults(A, B);
        }
        private void DisplayMultiplicationTable(int B)
        {
            lstResults.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResults.Items.Add($"{B} x {i} = {B * i}");
            }
        }

        private long Factorial(int n)
        {
            if (n < 0)
                return -1; // Trả về -1 nếu n < 0 vì không thể tính giai thừa của số âm
            if (n == 0)
                return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private long PowerSum(int A, int B)
        {
            long sum = 0;
            for (int i = 1; i <= B; i++)
            {
                sum += (long)Math.Pow(A, i);
            }
            return sum;
        }

        private void CalculateAndDisplayResults(int A, int B)
        {
            lstResults.Items.Clear();

            // Bảng cửu chương: B - A
            lstResults.Items.Add("Bảng cửu chương:");
            for (int i = 1; i <= 10; i++)
            {
                lstResults.Items.Add($"{B} x {i} = {B * i}");
            }
            lstResults.Items.Add(""); // Dòng trống

            // Tính toán (A – B)!
            if (A < B)
            {
                lstResults.Items.Add("Không thể tính (A - B)!");
            }
            else
            {
                long factorialResult = Factorial(A - B);
                lstResults.Items.Add($"(A - B)! = {(factorialResult >= 0 ? factorialResult.ToString() : "Không thể tính (A - B)!")}");

            }

            // Tính tổng S = A^1 + A^2 + A^3 + ... + A^B
            long sum = 0;
            lstResults.Items.Add(""); // Dòng trống
            lstResults.Items.Add("Tính tổng S = A^1 + A^2 + A^3 + ... + A^B:");
            for (int i = 1; i <= B; i++)
            {
                sum += (long)Math.Pow(A, i);
                lstResults.Items.Add($"{A}^{i} = {(long)Math.Pow(A, i)}");
            }
            lstResults.Items.Add($"Tổng S = {sum}");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lstResults.Items.Clear();
        }

        private void Lab01_Bai05_Load(object sender, EventArgs e)
        {

        }
    }
}
