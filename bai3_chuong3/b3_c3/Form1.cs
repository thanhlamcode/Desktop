namespace b3_c3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập tên!!");
            }
            else
            {
                Color selectedColor = Color.Black; // Màu mặc định, có thể thay đổi nếu không có RadioButton được chọn
                if (radio_red.Checked)
                    selectedColor = Color.Red;
                else if (radio_blue.Checked)
                    selectedColor = Color.Blue;
                else if (radioButton6.Checked)
                    selectedColor = Color.Green;

                // Lấy font từ các CheckBox
                FontStyle selectedFontStyle = FontStyle.Regular;
                if (checkBox1.Checked)
                    selectedFontStyle |= FontStyle.Bold;
                if (checkBox2.Checked)
                    selectedFontStyle |= FontStyle.Italic;
                if (checkBox3.Checked)
                    selectedFontStyle |= FontStyle.Underline;

                // Áp dụng màu sắc và font cho label2
                label2.ForeColor = selectedColor;
                label2.Font = new Font("Times New Roman", 18F, selectedFontStyle, GraphicsUnit.Point);

                // Hiển thị tên từ TextBox tại label2
                label2.Text = textBox1.Text;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radio_red_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}