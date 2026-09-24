using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;

            // 1. Minimum 8 simvol
            if (username.Length < 8)
            {
                MessageBox.Show("Username minimum 8 simvoldan ibarət olmalıdır!");
                return;
            }

            // 2. *, boşluq və # simvolları olmaz
            if (username.Contains("*") ||
                username.Contains(" ") ||
                username.Contains("#"))
            {
                MessageBox.Show("Username-də *, boşluq və # ola bilməz!");
                return;
            }

            // 3. Böyük hərf və 4. Rəqəm yoxlanılması
            bool boyukHerf = false;
            bool reqem = false;

            foreach (char c in username)
            {
                if (char.IsUpper(c))
                {
                    boyukHerf = true;
                }

                if (char.IsDigit(c))
                {
                    reqem = true;
                }
            }

            // Böyük hərf yoxdursa
            if (boyukHerf == false)
            {
                MessageBox.Show("Username-də ən azı bir böyük hərf olmalıdır!");
                return;
            }

            // Rəqəm yoxdursa
            if (reqem == false)
            {
                MessageBox.Show("Username-də ən azı bir rəqəm olmalıdır!");
                return;
            }

            // 5. Rəqəmlə başlamamalıdır
            if (char.IsDigit(username[0]))
            {
                MessageBox.Show("Username rəqəmlə başlaya bilməz!");
                return;
            }

            // Bütün şərtlər ödənilib
            MessageBox.Show("Username düzgündür!");
        }
    }
}
