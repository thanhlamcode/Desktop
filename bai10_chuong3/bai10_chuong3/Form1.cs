using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai10_chuong3
{
    public partial class Form1 : Form
    {
        private int dotIndex = 0;
        private int dotSize = 10;
        private int dotSpacing = 20;

        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            // Đặt interval cho timer (tùy chọn, thay đổi nếu cần)
            timer.Interval = 500; // Đổi số mili giây theo ý muốn của bạn

            // Gọi sự kiện Tick khi timer đếm
            timer.Tick += Timer_Tick;

            // Bắt đầu timer
            timer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Thay đổi index của chấm tròn (đến chấm tiếp theo)
            dotIndex = (dotIndex + 1) % 3;

            // Yêu cầu PictureBox vẽ lại
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Graphics từ sự kiện Paint
            Graphics g = e.Graphics;

            // Tính toán vị trí x của chấm tròn đầu tiên
            int startX = (pictureBox1.Width - (3 * dotSize + 2 * dotSpacing)) / 2;

            // Vẽ 3 chấm tròn
            for (int i = 0; i < 3; i++)
            {
                // Xác định màu của chấm tương ứng
                Color dotColor = (i == dotIndex) ? Color.Black : Color.Gray;

                // Vẽ chấm tròn
                g.FillEllipse(new SolidBrush(dotColor), startX + i * (dotSize + dotSpacing), (pictureBox1.Height - dotSize) / 2, dotSize, dotSize);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 10;
            if (panel1.Width >= 1220)
            {
                timer1.Stop();
                Form2 Linh = new Form2();
                this.Hide();
                Linh.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label3.SendToBack();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
