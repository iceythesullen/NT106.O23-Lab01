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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Lấy danh sách điểm từ TextBox
            string input = txtInput.Text.Trim();
            string[] data = input.Split(',');

            // Kiểm tra tính hợp lệ của định dạng
            if (data.Length < 2)
            {
                MessageBox.Show("Đã nhập sai định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy tên sinh viên và điểm
            string studentName = data[0].Trim();
            List<double> grades = new List<double>();
            for (int i = 1; i < data.Length; i++)
            {
                if (!double.TryParse(data[i].Trim(), out double grade))
                {
                    MessageBox.Show("Đã nhập sai định dạng điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                grades.Add(grade);
            }

            // Hiển thị tên sinh viên
            lstResults.Items.Add($"Họ và tên: {studentName}");

            // Hiển thị danh sách điểm
            DisplayGrades(grades);

            // Tính điểm trung bình
            double averageGrade = CalculateAverageGrade(grades);
            lstResults.Items.Add($"Điểm trung bình: {averageGrade:F2}");

            // Tìm môn điểm cao nhất và thấp nhất
            double maxGrade = FindMaxGrade(grades);
            double minGrade = FindMinGrade(grades);
            lstResults.Items.Add($"Điểm cao nhất: {maxGrade}");
            lstResults.Items.Add($"Điểm thấp nhất: {minGrade}");

            // Tìm số lượng môn đậu và không đậu
            int passCount = CountPassingSubjects(grades);
            int failCount = grades.Count - passCount;
            lstResults.Items.Add($"Số môn đậu: {passCount}");
            lstResults.Items.Add($"Số môn không đậu: {failCount}");

            // Xếp loại sinh viên
            string classification = ClassifyStudent(averageGrade, grades);
            lstResults.Items.Add($"Xếp loại sinh viên: {classification}");
        }

        private void DisplayGrades(List<double> grades)
        {
            lstResults.Items.Add("Danh sách điểm:");
            for (int i = 0; i < grades.Count; i++)
            {
                lstResults.Items.Add($"Môn {i + 1}: {grades[i]}");
            }
        }

        private double CalculateAverageGrade(List<double> grades)
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Count;
        }

        private double FindMaxGrade(List<double> grades)
        {
            double maxGrade = double.MinValue;
            foreach (double grade in grades)
            {
                if (grade > maxGrade)
                {
                    maxGrade = grade;
                }
            }
            return maxGrade;
        }

        private double FindMinGrade(List<double> grades)
        {
            double minGrade = double.MaxValue;
            foreach (double grade in grades)
            {
                if (grade < minGrade)
                {
                    minGrade = grade;
                }
            }
            return minGrade;
        }

        private int CountPassingSubjects(List<double> grades)
        {
            int passCount = 0;
            foreach (double grade in grades)
            {
                if (grade >= 5)
                {
                    passCount++;
                }
            }
            return passCount;
        }

        private string ClassifyStudent(double averageGrade, List<double> grades)
        {
            bool hasFailed = false;
            foreach (double grade in grades)
            {
                if (grade < 5)
                {
                    hasFailed = true;
                    break;
                }
            }

            if (averageGrade >= 8 && !hasFailed)
            {
                return "Giỏi";
            }
            else if (averageGrade >= 6.5 && !hasFailed)
            {
                return "Khá";
            }
            else if (averageGrade >= 5 && !hasFailed)
            {
                return "Trung bình";
            }
            else if (averageGrade >= 3.5 && !hasFailed)
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }

        private void Lab01_Bai07_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lstResults.Items.Clear();
        }
    }
}
