namespace TinhTongWin
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            buttontinhtong = new Button();
            labelketqua = new Label();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập a:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập b:";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(113, 36);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(113, 82);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 2;
            // 
            // buttontinhtong
            // 
            buttontinhtong.Location = new Point(44, 135);
            buttontinhtong.Name = "buttontinhtong";
            buttontinhtong.Size = new Size(94, 29);
            buttontinhtong.TabIndex = 3;
            buttontinhtong.Text = "Tính tổng";
            buttontinhtong.UseVisualStyleBackColor = true;
            buttontinhtong.Click += buttontinhtong_Click;
            // 
            // labelketqua
            // 
            labelketqua.AutoSize = true;
            labelketqua.Location = new Point(169, 139);
            labelketqua.Name = "labelketqua";
            labelketqua.Size = new Size(0, 20);
            labelketqua.TabIndex = 5;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(44, 170);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 263);
            Controls.Add(buttonReset);
            Controls.Add(labelketqua);
            Controls.Add(buttontinhtong);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttontinhtong;
        private Label labelketqua;
        private Button buttonReset;
    }
}
