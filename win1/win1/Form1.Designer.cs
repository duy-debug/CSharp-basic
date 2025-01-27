namespace win1
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
            this.lblsob = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblsoa = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.btntong = new System.Windows.Forms.Button();
            this.btnhieu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsob
            // 
            this.lblsob.AutoSize = true;
            this.lblsob.Location = new System.Drawing.Point(37, 163);
            this.lblsob.Name = "lblsob";
            this.lblsob.Size = new System.Drawing.Size(57, 26);
            this.lblsob.TabIndex = 2;
            this.lblsob.Text = "số b:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblKetQua.Location = new System.Drawing.Point(0, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(566, 73);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetQua.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsoa
            // 
            this.lblsoa.AutoSize = true;
            this.lblsoa.Location = new System.Drawing.Point(37, 106);
            this.lblsoa.Name = "lblsoa";
            this.lblsoa.Size = new System.Drawing.Size(55, 26);
            this.lblsoa.TabIndex = 1;
            this.lblsoa.Text = "số a:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(110, 98);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(299, 34);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(110, 155);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(299, 34);
            this.txtb.TabIndex = 4;
            // 
            // btntong
            // 
            this.btntong.BackColor = System.Drawing.Color.Yellow;
            this.btntong.Location = new System.Drawing.Point(65, 239);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(101, 33);
            this.btntong.TabIndex = 5;
            this.btntong.Text = "&Tổng";
            this.btntong.UseVisualStyleBackColor = false;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnhieu
            // 
            this.btnhieu.BackColor = System.Drawing.Color.Lime;
            this.btnhieu.Location = new System.Drawing.Point(169, 239);
            this.btnhieu.Name = "btnhieu";
            this.btnhieu.Size = new System.Drawing.Size(101, 33);
            this.btnhieu.TabIndex = 6;
            this.btnhieu.Text = "&Hiệu";
            this.btnhieu.UseVisualStyleBackColor = false;
            this.btnhieu.Click += new System.EventHandler(this.btnhieu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(169, 278);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 33);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Th&oát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnreset.Location = new System.Drawing.Point(276, 239);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(101, 33);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(566, 355);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhieu);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblsoa);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblsob);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsob;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblsoa;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnhieu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnreset;
    }
}

