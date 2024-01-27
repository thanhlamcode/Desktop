namespace bai6_chuong3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button9 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(919, 160);
            label1.TabIndex = 0;
            label1.Text = "LISTBOX";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(33, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 533);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listbox";
            // 
            // button1
            // 
            button1.Location = new Point(40, 124);
            button1.Name = "button1";
            button1.Size = new Size(352, 46);
            button1.TabIndex = 2;
            button1.Text = "Nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(40, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 324);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 48);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(501, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 515);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xử lý listbox";
            // 
            // button8
            // 
            button8.Location = new Point(20, 463);
            button8.Name = "button8";
            button8.Size = new Size(352, 46);
            button8.TabIndex = 9;
            button8.Text = "Chọn số lẻ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(20, 395);
            button7.Name = "button7";
            button7.Size = new Size(352, 46);
            button7.TabIndex = 8;
            button7.Text = "Chọn số chẵn";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(20, 328);
            button6.Name = "button6";
            button6.Size = new Size(352, 46);
            button6.TabIndex = 7;
            button6.Text = "Thay bằng bình phương";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(20, 262);
            button5.Name = "button5";
            button5.Size = new Size(352, 46);
            button5.TabIndex = 6;
            button5.Text = "Tăng mỗi phần tử lên 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 50);
            button2.Name = "button2";
            button2.Size = new Size(352, 46);
            button2.TabIndex = 3;
            button2.Text = "Tổng các phần tử trong list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(20, 115);
            button3.Name = "button3";
            button3.Size = new Size(352, 46);
            button3.TabIndex = 4;
            button3.Text = "Xóa phần tử đầu và phần tử cuối";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 182);
            button4.Name = "button4";
            button4.Size = new Size(352, 46);
            button4.TabIndex = 5;
            button4.Text = "Xóa phần tử đang chọn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.Location = new Point(253, 741);
            button9.Name = "button9";
            button9.Size = new Size(352, 46);
            button9.TabIndex = 10;
            button9.Text = "Kết thúc";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 799);
            Controls.Add(button9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button9;
    }
}