namespace bai6_chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng điền dữ liệu!!");
            }
            else
            {
                // Thử chuyển đổi dữ liệu từ TextBox thành số nguyên
                if (int.TryParse(textBox1.Text, out int n))
                {
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!");
                    // Clear TextBox để người dùng nhập lại
                    textBox1.Clear();
                }
            }
            // Clear TextBox để người dùng nhập lại
            textBox1.Clear();
            // Chuyển con trỏ về TextBox
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn hay không
            if (listBox1.SelectedIndex != -1)
            {
                // Xóa mục được chọn
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Xử lý khi người dùng nhấn Enter
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Vui lòng điền dữ liệu!!");
                }
                else
                {
                    // Thử chuyển đổi dữ liệu từ TextBox thành số nguyên
                    if (int.TryParse(textBox1.Text, out int n))
                    {
                        listBox1.Items.Add(textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!");
                    }

                    // Clear TextBox để người dùng nhập lại
                    textBox1.Clear();
                    // Chuyển con trỏ về TextBox
                    textBox1.Focus();

                    // Ngăn chặn sự kiện Enter từ việc được xử lý tiếp
                    e.Handled = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var item in listBox1.Items)
            {
                // Thử chuyển đổi mục thành số nguyên
                if (int.TryParse(item.ToString(), out int n) && n % 2 == 0)
                {
                    s += item.ToString() + "\n";
                }
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Listbox rỗng!!");
            }
            else
            {
                MessageBox.Show($"Các số chẵn là:\n{s}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var item in listBox1.Items)
            {
                // Thử chuyển đổi mục thành số nguyên
                if (int.TryParse(item.ToString(), out int n) && n % 2 == 1)
                {
                    s += item.ToString() + "\n";
                }
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Listbox rỗng!!");
            }
            else
            {
                MessageBox.Show($"Các số lẻ là:\n{s}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in listBox1.Items)
            {
                sum += Convert.ToUInt16(item);
            }
            MessageBox.Show($"Tổng các số trong listbox là: {sum}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Thử chuyển đổi mục thành số nguyên
                if (int.TryParse(listBox1.Items[i].ToString(), out int n))
                {
                    // Tăng giá trị của mỗi phần tử lên 2
                    n += 2;

                    // Cập nhật giá trị của mục trong listBox1
                    listBox1.Items[i] = n.ToString();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Thử chuyển đổi mục thành số nguyên
                if (int.TryParse(listBox1.Items[i].ToString(), out int n))
                {
                    // Tăng giá trị của mỗi phần tử lên 2
                    n *=n;

                    // Cập nhật giá trị của mục trong listBox1
                    listBox1.Items[i] = n.ToString();
                }
            }
        }
    }
}