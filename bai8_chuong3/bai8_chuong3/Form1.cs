using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8_chuong3
{
    public partial class Form1 : Form
    {
        // Biến để kiểm soát tiến trình con
        private bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_ngaygio_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;

                // Sử dụng Task để chạy vòng lặp cập nhật liên tục
                await Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        // Báo cáo tiến trình về UI thread
                        this.Invoke((MethodInvoker)delegate
                        {
                            label1.Text = "Bây giờ là: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        });
                    }
                });

                isRunning = false;
            }
        }
        private void UpdateProgressBar(object state)
        {
            // Mô phỏng quá trình cập nhật ProgressBar
            for (int i = 0; i <= 100; i++)
            {
                // Báo cáo tiến trình về UI thread
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = i;

                    // Hiển thị Form2 khi ProgressBar hoàn tất
                    if (i == 100)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                });

                // Dừng một khoảng thời gian (mô phỏng công việc thực tế)
                Thread.Sleep(50);
            }
        }
        private void btn_bit_Click(object sender, EventArgs e)
        {
            // Bắt đầu tiến trình con để chạy ProgressBar trước khi hiển thị Form2
            ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateProgressBar));
        }
    }
}
