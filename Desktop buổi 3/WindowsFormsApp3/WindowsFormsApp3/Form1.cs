using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string logMessage = $"{DateTime.Now} - ";
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoginLog.txt");

            switch (x)
            {
                case "1645":
                case "1689":
                case "8345":
                    listBox1.Items.Add($"{logMessage}Technicians");
                    LogToFile($"{logMessage}Access granted: Technicians", logFilePath);
                    break;
                case "9998":
                case "1006":
                case "1008":
                    listBox1.Items.Add($"{logMessage}Scientist");
                    LogToFile($"{logMessage}Access granted: Scientist", logFilePath);
                    break;
                default:
                    listBox1.Items.Add($"{logMessage}Restricted Access!");
                    LogToFile($"{logMessage}Access denied: Restricted Access!", logFilePath);
                    break;
            }
        }

        private void LogToFile(string logMessage, string logFilePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn_logfile_Click(object sender, EventArgs e)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoginLog.txt");

            try
            {
                if (File.Exists(logFilePath))
                {
                    // Đọc tất cả các dòng từ tệp và thêm vào listBox
                    string[] logLines = File.ReadAllLines(logFilePath);
                    listBox1.Items.AddRange(logLines);
                }
                else
                {
                    MessageBox.Show("Log file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                // Gọi phương thức xử lý khi một số được nhấn
                HandleNumericKeyPress((Keys)(e.KeyCode - Keys.D0));
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_enter_Click(sender, e);
            }
        }

        private void HandleNumericKeyPress(Keys numericKey)
        {
            // Thực hiện xử lý tương ứng với số được nhấn
            // Ở đây, chúng ta chọn thực hiện sự kiện Click của button tương ứng với số
            switch (numericKey)
            {
                case Keys.D0:
                    button0.PerformClick();
                    break;
                case Keys.D1:
                    button1.PerformClick();
                    break;
                case Keys.D2:
                    button2.PerformClick();
                    break;
                case Keys.D3:
                    button3.PerformClick();
                    break;
                case Keys.D4:
                    button4.PerformClick();
                    break;
                case Keys.D5:
                    button5.PerformClick();
                    break;
                case Keys.D6:
                    button6.PerformClick();
                    break;
                case Keys.D7:
                    button7.PerformClick();
                    break;
                case Keys.D8:
                    button8.PerformClick();
                    break;
                case Keys.D9:
                    button9.PerformClick();
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
    }
}
