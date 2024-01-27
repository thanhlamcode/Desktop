using System.Drawing.Drawing2D;

namespace Bai1_chuong2
{
    public partial class Form1 : Form
    {
        private Point startPoint; // Lưu điểm bắt đầu khi nhấn chuột
        private Point endPoint;   // Lưu điểm kết thúc khi nhấn chuột lần thứ hai
        private bool isFirstClick = true; // Biến kiểm tra xem đã nhấn chuột lần thứ nhất hay chưa
        private bool isButtonVisible = false; // Biến kiểm tra xem nút tròn đã được hiển thị hay chưa

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isFirstClick)
            {
                startPoint = e.Location;
                isFirstClick = false;
                ShowCircleButton(startPoint); // Hiển thị nút tròn lớn
            }
            else
            {
                // Nếu đây là lần nhấn chuột thứ hai, vẽ đường thẳng
                endPoint = e.Location;
                using (Graphics g = this.CreateGraphics())
                {
                    using (Pen pen = new Pen(Color.Black, 3)) // Đặt Width là 3 (hoặc giá trị khác tùy chọn)
                    {
                        g.DrawLine(pen, startPoint, endPoint);
                    }
                }
                ShowCircleButton(endPoint);
                isFirstClick = true; // Reset lại trạng thái cho lần nhấn chuột tiếp theo
            }
        }
        private void ShowCircleButton(Point location)
        {
            // Hiển thị nút tròn lớn tại vị trí nhấn chuột
            Button circleButton = new Button();
            circleButton.Width = 40; // Đặt chiều rộng của nút
            circleButton.Height = 40; // Đặt chiều cao của nút
            circleButton.Location = new Point(location.X - 20, location.Y - 20);
            circleButton.BackColor = Color.Red;
            circleButton.FlatStyle = FlatStyle.Flat;
            circleButton.FlatAppearance.BorderSize = 0;

            // Tạo hình tròn bằng cách đặt hình dạng của nút tròn
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(0, 0, 40, 40));
                circleButton.Region = new Region(path);
            }

            this.Controls.Add(circleButton);
            isButtonVisible = true;
        }
    }
}