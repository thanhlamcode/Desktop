using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận thoát chương trình?");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            int a = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {
                // Tìm USCLN
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                textBox3.Text = a.ToString();
            }
            else if (radioButton2.Checked)
            {
                // Tìm BSCNN sử dụng USCLN
                int gcd = a; // Giữ lại giá trị USCLN từ bước trước
                int lcm = (a * b) / gcd;
                textBox3.Text = lcm.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
