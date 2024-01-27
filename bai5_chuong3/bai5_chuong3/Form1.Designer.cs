namespace bai5_chuong3
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
            label2 = new Label();
            textBox_hoten = new TextBox();
            listBox1 = new ListBox();
            btn_nhapthongtin = new Button();
            label3 = new Label();
            btn_xoadangchon = new Button();
            btn_xoatatca = new Button();
            btn_xoadau = new Button();
            btn_xoacuoi = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Fuchsia;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(999, 209);
            label1.TabIndex = 0;
            label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 250);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // textBox_hoten
            // 
            textBox_hoten.Location = new Point(131, 253);
            textBox_hoten.Name = "textBox_hoten";
            textBox_hoten.Size = new Size(198, 39);
            textBox_hoten.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(545, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 324);
            listBox1.TabIndex = 3;
            // 
            // btn_nhapthongtin
            // 
            btn_nhapthongtin.Location = new Point(313, 324);
            btn_nhapthongtin.Name = "btn_nhapthongtin";
            btn_nhapthongtin.Size = new Size(206, 111);
            btn_nhapthongtin.TabIndex = 4;
            btn_nhapthongtin.Text = "Nhập thông tin";
            btn_nhapthongtin.UseVisualStyleBackColor = true;
            btn_nhapthongtin.Click += btn_nhapthongtin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 467);
            label3.Name = "label3";
            label3.Size = new Size(300, 32);
            label3.TabIndex = 5;
            label3.Text = "Tổng số người đã khai báo";
            // 
            // btn_xoadangchon
            // 
            btn_xoadangchon.Location = new Point(131, 589);
            btn_xoadangchon.Name = "btn_xoadangchon";
            btn_xoadangchon.Size = new Size(271, 111);
            btn_xoadangchon.TabIndex = 7;
            btn_xoadangchon.Text = "Xóa thông tin đang chọn";
            btn_xoadangchon.UseVisualStyleBackColor = true;
            btn_xoadangchon.Click += btn_xoadangchon_Click;
            // 
            // btn_xoatatca
            // 
            btn_xoatatca.Location = new Point(131, 752);
            btn_xoatatca.Name = "btn_xoatatca";
            btn_xoatatca.Size = new Size(271, 118);
            btn_xoatatca.TabIndex = 8;
            btn_xoatatca.Text = "Xóa tất cả thông tin";
            btn_xoatatca.UseVisualStyleBackColor = true;
            btn_xoatatca.Click += btn_xoatatca_Click;
            // 
            // btn_xoadau
            // 
            btn_xoadau.Location = new Point(597, 589);
            btn_xoadau.Name = "btn_xoadau";
            btn_xoadau.Size = new Size(213, 111);
            btn_xoadau.TabIndex = 9;
            btn_xoadau.Text = "Xóa thông tin đầu";
            btn_xoadau.UseVisualStyleBackColor = true;
            btn_xoadau.Click += btn_xoadau_Click;
            // 
            // btn_xoacuoi
            // 
            btn_xoacuoi.Location = new Point(597, 752);
            btn_xoacuoi.Name = "btn_xoacuoi";
            btn_xoacuoi.Size = new Size(213, 118);
            btn_xoacuoi.TabIndex = 10;
            btn_xoacuoi.Text = "Xóa thông tin cuối";
            btn_xoacuoi.UseVisualStyleBackColor = true;
            btn_xoacuoi.Click += btn_xoacuoi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(362, 467);
            label4.Name = "label4";
            label4.Size = new Size(27, 32);
            label4.TabIndex = 11;
            label4.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 898);
            Controls.Add(label4);
            Controls.Add(btn_xoacuoi);
            Controls.Add(btn_xoadau);
            Controls.Add(btn_xoatatca);
            Controls.Add(btn_xoadangchon);
            Controls.Add(label3);
            Controls.Add(btn_nhapthongtin);
            Controls.Add(listBox1);
            Controls.Add(textBox_hoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_hoten;
        private ListBox listBox1;
        private Button btn_nhapthongtin;
        private Label label3;
        private Button btn_xoadangchon;
        private Button btn_xoatatca;
        private Button btn_xoadau;
        private Button btn_xoacuoi;
        private Label label4;
    }
}