namespace bai1_chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ho_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ho.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ");
            }
            else
            {
                // Thêm phần tử vào ListBox
                listBox_hienthi.Items.Add(textBox_ho.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
            }
            else
            {
                listBox_hienthi.Items.Add(textBox_ten.Text);
            }
        }

        private void btn_hvt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ho.Text) || string.IsNullOrEmpty(textBox_ten.Text))
            {
                MessageBox.Show("Nhập cả họ và tên!!");
            }
            else
            {
                listBox_hienthi.Items.Add(textBox_ho.Text + " " + textBox_ten.Text);
            }
        }
    }
}