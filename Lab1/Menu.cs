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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 f = new Lab01_Bai01();
            f.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 f = new Lab01_Bai02();
            f.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 f = new Lab01_Bai03();
            f.Show();
        }
        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 f = new Lab01_Bai04();
            f.Show();
        }
        private void Bai5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 f = new Lab01_Bai05();
            f.Show();
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 f = new Lab01_Bai06();
            f.Show();
        }
        private void Bai7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 f = new Lab01_Bai07();
            f.Show();
        }

        private void Bai8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 f = new Lab01_Bai08();
            f.Show();
        }
    }
}
