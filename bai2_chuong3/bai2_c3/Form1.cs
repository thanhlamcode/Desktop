namespace bai2_c3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "UEHBIT")
            {
                MessageBox.Show("Đăng nhập thành công!!");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập/mật khẩu sai!!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}