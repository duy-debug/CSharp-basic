namespace Caculator
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
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            buttonXoa = new Button();
            buttonTinh = new Button();
            buttonCong = new Button();
            textHienthi = new TextBox();
            buttonNhan = new Button();
            buttonChia = new Button();
            buttonTru = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Location = new Point(23, 331);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.Location = new Point(123, 331);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 331);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(23, 286);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(123, 286);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(223, 286);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(23, 239);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(123, 239);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(223, 239);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(123, 193);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 9;
            buttonXoa.Text = "C";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonTinh
            // 
            buttonTinh.Location = new Point(323, 331);
            buttonTinh.Name = "buttonTinh";
            buttonTinh.Size = new Size(94, 29);
            buttonTinh.TabIndex = 10;
            buttonTinh.Text = "=";
            buttonTinh.UseVisualStyleBackColor = true;
            buttonTinh.Click += buttonTinh_Click;
            // 
            // buttonCong
            // 
            buttonCong.Location = new Point(223, 193);
            buttonCong.Name = "buttonCong";
            buttonCong.Size = new Size(94, 29);
            buttonCong.TabIndex = 11;
            buttonCong.Text = "+";
            buttonCong.UseVisualStyleBackColor = true;
            buttonCong.Click += buttonCong_Click;
            // 
            // textHienthi
            // 
            textHienthi.BackColor = Color.PowderBlue;
            textHienthi.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textHienthi.ForeColor = SystemColors.ActiveCaptionText;
            textHienthi.Location = new Point(23, 73);
            textHienthi.Name = "textHienthi";
            textHienthi.Size = new Size(394, 70);
            textHienthi.TabIndex = 12;
            textHienthi.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonNhan
            // 
            buttonNhan.Location = new Point(323, 239);
            buttonNhan.Name = "buttonNhan";
            buttonNhan.Size = new Size(94, 29);
            buttonNhan.TabIndex = 13;
            buttonNhan.Text = "x";
            buttonNhan.UseVisualStyleBackColor = true;
            buttonNhan.Click += buttonNhan_Click;
            // 
            // buttonChia
            // 
            buttonChia.Location = new Point(323, 286);
            buttonChia.Name = "buttonChia";
            buttonChia.Size = new Size(94, 29);
            buttonChia.TabIndex = 14;
            buttonChia.Text = "/";
            buttonChia.UseVisualStyleBackColor = true;
            buttonChia.Click += button14_Click;
            // 
            // buttonTru
            // 
            buttonTru.Location = new Point(323, 193);
            buttonTru.Name = "buttonTru";
            buttonTru.Size = new Size(94, 29);
            buttonTru.TabIndex = 15;
            buttonTru.Text = "-";
            buttonTru.UseVisualStyleBackColor = true;
            buttonTru.Click += buttonTru_Click;
            // 
            // button9
            // 
            button9.Location = new Point(23, 193);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 16;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 397);
            Controls.Add(button9);
            Controls.Add(buttonTru);
            Controls.Add(buttonChia);
            Controls.Add(buttonNhan);
            Controls.Add(textHienthi);
            Controls.Add(buttonCong);
            Controls.Add(buttonTinh);
            Controls.Add(buttonXoa);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button buttonXoa;
        private Button buttonTinh;
        private Button buttonCong;
        private TextBox textHienthi;
        private Button buttonNhan;
        private Button buttonChia;
        private Button buttonTru;
        private Button button9;
    }
}
