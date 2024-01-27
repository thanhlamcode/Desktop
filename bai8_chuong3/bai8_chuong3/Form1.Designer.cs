namespace bai8_chuong3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ngaygio = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_bit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1154, 213);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bây giờ là:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1154, 383);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1154, 236);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ngaygio
            // 
            this.btn_ngaygio.Location = new System.Drawing.Point(33, 328);
            this.btn_ngaygio.Name = "btn_ngaygio";
            this.btn_ngaygio.Size = new System.Drawing.Size(241, 88);
            this.btn_ngaygio.TabIndex = 3;
            this.btn_ngaygio.Text = "Hiển thị ngày và giờ";
            this.btn_ngaygio.UseVisualStyleBackColor = true;
            this.btn_ngaygio.Click += new System.EventHandler(this.btn_ngaygio_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(322, 328);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(760, 88);
            this.progressBar1.TabIndex = 4;
            // 
            // btn_bit
            // 
            this.btn_bit.BackColor = System.Drawing.Color.Lime;
            this.btn_bit.Font = new System.Drawing.Font("Palatino Linotype", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bit.Location = new System.Drawing.Point(242, 641);
            this.btn_bit.Name = "btn_bit";
            this.btn_bit.Size = new System.Drawing.Size(570, 163);
            this.btn_bit.TabIndex = 5;
            this.btn_bit.Text = "Chào mừng bạn đến với BIT";
            this.btn_bit.UseVisualStyleBackColor = false;
            this.btn_bit.Click += new System.EventHandler(this.btn_bit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 827);
            this.Controls.Add(this.btn_bit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_ngaygio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ngaygio;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_bit;
    }
}

