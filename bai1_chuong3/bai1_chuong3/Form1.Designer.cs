namespace bai1_chuong3
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
            listBox_hienthi = new ListBox();
            label1 = new Label();
            textBox_ho = new TextBox();
            textBox_ten = new TextBox();
            label2 = new Label();
            btn_Ho = new Button();
            btn_ten = new Button();
            btn_hvt = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox_hienthi
            // 
            listBox_hienthi.FormattingEnabled = true;
            listBox_hienthi.ItemHeight = 32;
            listBox_hienthi.Location = new Point(12, 12);
            listBox_hienthi.Name = "listBox_hienthi";
            listBox_hienthi.Size = new Size(862, 164);
            listBox_hienthi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(63, 260);
            label1.Name = "label1";
            label1.Size = new Size(220, 71);
            label1.TabIndex = 1;
            label1.Text = "Họ Lót:";
            // 
            // textBox_ho
            // 
            textBox_ho.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ho.Location = new Point(363, 266);
            textBox_ho.Name = "textBox_ho";
            textBox_ho.Size = new Size(414, 68);
            textBox_ho.TabIndex = 2;
            // 
            // textBox_ten
            // 
            textBox_ten.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ten.Location = new Point(363, 409);
            textBox_ten.Name = "textBox_ten";
            textBox_ten.Size = new Size(414, 68);
            textBox_ten.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(63, 403);
            label2.Name = "label2";
            label2.Size = new Size(141, 71);
            label2.TabIndex = 3;
            label2.Text = "Tên:";
            // 
            // btn_Ho
            // 
            btn_Ho.Location = new Point(54, 558);
            btn_Ho.Name = "btn_Ho";
            btn_Ho.Size = new Size(207, 66);
            btn_Ho.TabIndex = 5;
            btn_Ho.Text = "Họ Lót";
            btn_Ho.UseVisualStyleBackColor = true;
            btn_Ho.Click += btn_Ho_Click;
            // 
            // btn_ten
            // 
            btn_ten.Location = new Point(340, 558);
            btn_ten.Name = "btn_ten";
            btn_ten.Size = new Size(197, 66);
            btn_ten.TabIndex = 6;
            btn_ten.Text = "Tên";
            btn_ten.UseVisualStyleBackColor = true;
            btn_ten.Click += btn_ten_Click;
            // 
            // btn_hvt
            // 
            btn_hvt.Location = new Point(626, 558);
            btn_hvt.Name = "btn_hvt";
            btn_hvt.Size = new Size(170, 66);
            btn_hvt.TabIndex = 7;
            btn_hvt.Text = "Họ và tên";
            btn_hvt.UseVisualStyleBackColor = true;
            btn_hvt.Click += btn_hvt_Click;
            // 
            // button4
            // 
            button4.Location = new Point(282, 710);
            button4.Name = "button4";
            button4.Size = new Size(387, 107);
            button4.TabIndex = 8;
            button4.Text = "Kết thúc";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 859);
            Controls.Add(button4);
            Controls.Add(btn_hvt);
            Controls.Add(btn_ten);
            Controls.Add(btn_Ho);
            Controls.Add(textBox_ten);
            Controls.Add(label2);
            Controls.Add(textBox_ho);
            Controls.Add(label1);
            Controls.Add(listBox_hienthi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_hienthi;
        private Label label1;
        private TextBox textBox_ho;
        private TextBox textBox_ten;
        private Label label2;
        private Button btn_Ho;
        private Button btn_ten;
        private Button btn_hvt;
        private Button button4;
    }
}