namespace b4_c3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false; radioButton2.Checked = false;
            radioButton3.Checked = false; radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (checkBox_nghenhac.Checked)
                s += checkBox_nghenhac.Text + "\n";
            if (checkBox2.Checked)
                s += checkBox2.Text + "\n";
            if (checkBox3.Checked)
                s += checkBox3.Text + "\n";
            if (checkBox4.Checked)
                s += checkBox4.Text + "\n";
            if (checkBox5.Checked)
                s += checkBox5.Text + "";
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Không có sở thích nào được chọn!!");
            }
            else
            {
                MessageBox.Show($"Sở thích của bạn là:\n{s}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Màu bạn thích là " + radioButton1.Text);
            }
            else if (radioButton2.Checked)
                {
                    MessageBox.Show("Màu bạn thích là " + radioButton2.Text);
                }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Màu bạn thích là " + radioButton3.Text);
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("Màu bạn thích là " + radioButton4.Text);
            }
        }
    }
}