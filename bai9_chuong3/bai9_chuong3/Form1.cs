using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9_chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gọi phương thức CenterScreen để đặt form ở giữa màn hình
            CenterScreen();
        }
        private void CenterScreen()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu trống
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                textBox1.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu trống
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                textBox2.Focus();
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskFull)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                maskedTextBox1.Focus();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                comboBox1.Focus();
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                comboBox2.Focus();
            }
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBox2.MaskFull)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                maskedTextBox2.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu trống
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập thông tin vào ô này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Chuyển focus về ô cần nhập
                textBox3.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô nhập liệu đã được điền đầy đủ thông tin hay không
            if (IsValidData())
            {
                // Tạo chuỗi thông tin đầy đủ
                string fullInfo = $"Employee: {textBox1.Text}\n" +
                                  $"Day of Birthday: {maskedTextBox1.Text}\n" +
                                  $"Address: {textBox2.Text}\n" +
                                  $"City: {comboBox1.Text}\n" +
                                  $"Qualification: {comboBox2.Text}\n" +
                                  $"Phone: {maskedTextBox2.Text}\n" +
                                  $"Email: {textBox3.Text}\n" +
                                  $"Date of joining: {dateTimePicker1.Value.ToShortDateString()}\n";

                // Hiển thị MessageBox với thông tin đầy đủ
                MessageBox.Show(fullInfo, "Thông tin đầy đủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu thông tin chưa đầy đủ, hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi nhấn Submit!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidData()
        {
            // Kiểm tra xem tất cả các ô nhập liệu đã được điền đầy đủ thông tin hay không
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   maskedTextBox1.MaskFull &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox2.Text) &&
                   maskedTextBox2.MaskFull &&
                   !string.IsNullOrWhiteSpace(textBox3.Text);
        }
    }
}
