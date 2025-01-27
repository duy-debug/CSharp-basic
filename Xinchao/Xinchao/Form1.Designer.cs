namespace Xinchao
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
            buttonMessage = new Button();
            buttonLabel = new Button();
            buttonTextbox = new Button();
            label1 = new Label();
            txbNhaphoten = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonMessage
            // 
            buttonMessage.Location = new Point(21, 99);
            buttonMessage.Name = "buttonMessage";
            buttonMessage.Size = new Size(270, 29);
            buttonMessage.TabIndex = 2;
            buttonMessage.Text = "Hiện lời chào qua messageBox";
            buttonMessage.UseVisualStyleBackColor = true;
            buttonMessage.Click += buttonMessage_Click;
            // 
            // buttonLabel
            // 
            buttonLabel.Location = new Point(21, 134);
            buttonLabel.Name = "buttonLabel";
            buttonLabel.Size = new Size(270, 29);
            buttonLabel.TabIndex = 3;
            buttonLabel.Text = "Hiện lời chào qua label";
            buttonLabel.UseVisualStyleBackColor = true;
            buttonLabel.Click += buttonLabel_Click;
            // 
            // buttonTextbox
            // 
            buttonTextbox.Location = new Point(21, 169);
            buttonTextbox.Name = "buttonTextbox";
            buttonTextbox.Size = new Size(270, 29);
            buttonTextbox.TabIndex = 4;
            buttonTextbox.Text = "Hiện lời chào qua textbox";
            buttonTextbox.UseVisualStyleBackColor = true;
            buttonTextbox.Click += buttonTextbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 3;
            label1.Text = "Nhập họ và tên: ";
            // 
            // txbNhaphoten
            // 
            txbNhaphoten.Location = new Point(21, 48);
            txbNhaphoten.Name = "txbNhaphoten";
            txbNhaphoten.Size = new Size(387, 27);
            txbNhaphoten.TabIndex = 1;
            txbNhaphoten.TextChanged += txbNhaphoten_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 99);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(362, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 34);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txbNhaphoten);
            Controls.Add(label1);
            Controls.Add(buttonTextbox);
            Controls.Add(buttonLabel);
            Controls.Add(buttonMessage);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMessage;
        private Button buttonLabel;
        private Button buttonTextbox;
        private Label label1;
        private TextBox txbNhaphoten;
        private Label label2;
        private TextBox textBox1;
    }
}
