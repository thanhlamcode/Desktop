namespace bai2_c3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            btn_login = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(203, 54);
            label1.Name = "label1";
            label1.Size = new Size(491, 61);
            label1.TabIndex = 0;
            label1.Text = "Thông tin đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(41, 177);
            label2.Name = "label2";
            label2.Size = new Size(435, 71);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(525, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 65);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(525, 301);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(307, 65);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(41, 294);
            label3.Name = "label3";
            label3.Size = new Size(300, 71);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // btn_login
            // 
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.Location = new Point(52, 446);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(324, 146);
            btn_login.TabIndex = 5;
            btn_login.Text = "Đăng nhập";
            btn_login.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Image = Properties.Resources.pngtree_cross_mark_cancellation_white_on_red_background_3drender_png_image_6121842;
            btn_exit.Location = new Point(474, 446);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(324, 146);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 666);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button btn_login;
        private Button btn_exit;
    }
}