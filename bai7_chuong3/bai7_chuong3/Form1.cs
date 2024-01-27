namespace bai7_chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt con trỏ vào textBox1
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
                    listBox1.Items.Add(textBox1.Text);

                    // Clear TextBox để người dùng nhập lại
                    textBox1.Clear();
                    // Chuyển con trỏ về TextBox
                    textBox1.Focus();

                    // Ngăn chặn sự kiện Enter từ việc được xử lý tiếp
                    e.Handled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                int select = listBox1.SelectedIndices[i];
                listBox2.Items.Add(listBox1.Items[select]);
                listBox1.Items.RemoveAt(select);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lặp qua từng mục trong listBox1
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Thêm mục vào listBox2
                listBox2.Items.Add(listBox1.Items[i]);

                // Xóa mục khỏi listBox1
                listBox1.Items.RemoveAt(i);

                // Giảm i để đảm bảo không bỏ qua mục sau khi xóa
                i--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int selectedIndex = listBox2.SelectedIndices[i];
                listBox1.Items.Add(listBox2.Items[selectedIndex]);
                listBox2.Items.RemoveAt(selectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                // Thêm mục vào listBox2
                listBox1.Items.Add(listBox2.Items[i]);

                // Xóa mục khỏi listBox1
                listBox2.Items.RemoveAt(i);

                // Giảm i để đảm bảo không bỏ qua mục sau khi xóa
                i--;
            }
        }
    }
}