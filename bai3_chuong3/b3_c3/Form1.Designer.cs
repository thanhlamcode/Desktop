namespace b3_c3
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radio_black = new RadioButton();
            radio_red = new RadioButton();
            radio_blue = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(73, 83);
            label1.Name = "label1";
            label1.Size = new Size(249, 65);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(417, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 78);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_black);
            groupBox1.Controls.Add(radio_red);
            groupBox1.Controls.Add(radio_blue);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(58, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 342);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radio_black
            // 
            radio_black.AutoSize = true;
            radio_black.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radio_black.Location = new Point(108, 248);
            radio_black.Name = "radio_black";
            radio_black.Size = new Size(105, 36);
            radio_black.TabIndex = 8;
            radio_black.TabStop = true;
            radio_black.Text = "Black";
            radio_black.UseVisualStyleBackColor = true;
            // 
            // radio_red
            // 
            radio_red.AutoSize = true;
            radio_red.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radio_red.ForeColor = Color.Red;
            radio_red.Location = new Point(108, 6);
            radio_red.Name = "radio_red";
            radio_red.Size = new Size(88, 36);
            radio_red.TabIndex = 5;
            radio_red.TabStop = true;
            radio_red.Text = "Red";
            radio_red.UseVisualStyleBackColor = true;
            radio_red.CheckedChanged += radio_red_CheckedChanged;
            // 
            // radio_blue
            // 
            radio_blue.AutoSize = true;
            radio_blue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radio_blue.ForeColor = Color.Blue;
            radio_blue.Location = new Point(108, 158);
            radio_blue.Name = "radio_blue";
            radio_blue.Size = new Size(95, 36);
            radio_blue.TabIndex = 7;
            radio_blue.TabStop = true;
            radio_blue.Text = "Blue";
            radio_blue.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.ForeColor = Color.Chartreuse;
            radioButton6.Location = new Point(108, 80);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(113, 36);
            radioButton6.TabIndex = 6;
            radioButton6.TabStop = true;
            radioButton6.Text = "Green";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(431, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 342);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            checkBox3.Location = new Point(38, 248);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(150, 36);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Underline";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(38, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 36);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Italic";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(38, 80);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Bold";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(397, 689);
            label2.Name = "label2";
            label2.Size = new Size(363, 64);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(73, 666);
            button1.Name = "button1";
            button1.Size = new Size(217, 97);
            button1.TabIndex = 10;
            button1.Text = "Kết quả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(150, 111, 51);
            ClientSize = new Size(830, 810);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radio_red;
        private RadioButton radio_blue;
        private RadioButton radioButton6;
        private RadioButton radio_black;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Button button1;
    }
}