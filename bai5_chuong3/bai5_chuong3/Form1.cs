namespace bai5_chuong3
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateLabelCount()
        {
            // Cập nhật số lượng người vào label4
            label4.Text = cnt.ToString();
        }

        private void btn_nhapthongtin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
            }
            else
            {
                listBox1.Items.Add(textBox_hoten.Text);
                cnt++;
                label4.Text = cnt.ToString();
            }
        }

        private void btn_xoadangchon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn hay không
            if (listBox1.SelectedIndex != -1)
            {
                // Xóa mục được chọn
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                cnt--;
                UpdateLabelCount(); // Cập nhật số lượng người
            }
        }

        private void btn_xoadau_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                // Xóa mục đầu tiên
                listBox1.Items.RemoveAt(0);
                cnt--;
                UpdateLabelCount(); // Cập nhật số lượng người
            }
        }

        private void btn_xoatatca_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label4.Text = "0";
        }

        private void btn_xoacuoi_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                // Xóa mục cuối cùng
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                cnt--;
                UpdateLabelCount(); // Cập nhật số lượng người
            }
        }
    }
}