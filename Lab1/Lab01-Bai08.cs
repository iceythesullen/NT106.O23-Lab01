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
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }
        private List<string> favoriteFoods = new List<string>();

        private void UpdateFoodList()
        {
            // Xóa danh sách món ăn cũ
            lstFavoriteFoods.Items.Clear();

            // Thêm các món ăn vào danh sách
            foreach (string food in favoriteFoods)
            {
                lstFavoriteFoods.Items.Add(food);
            }
        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {
            // Hiển thị danh sách món ăn ưa thích
            UpdateFoodList();
        }

        private void btnPickFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem danh sách món ăn ưa thích có rỗng không
            if (favoriteFoods.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn ưa thích đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Chọn ngẫu nhiên một món ăn từ danh sách
            Random random = new Random();
            int index = random.Next(0, favoriteFoods.Count);

            // Hiển thị món ăn đã chọn trong TextBox
            string selectedFood = favoriteFoods[index];
            txtSelectedFood.Text = selectedFood;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Lấy tên món ăn từ TextBox
            string newFood = txtNewFood.Text.Trim();

            // Kiểm tra xem người dùng đã nhập một tên món ăn mới chưa
            if (!string.IsNullOrEmpty(newFood))
            {
                // Thêm món ăn mới vào danh sách
                favoriteFoods.Add(newFood);

                // Cập nhật danh sách món ăn
                UpdateFoodList();

                // Xóa nội dung của TextBox
                txtNewFood.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNewFood.Clear();
            txtSelectedFood.Clear();
            lstFavoriteFoods.Items.Clear();
        }
    }
}
