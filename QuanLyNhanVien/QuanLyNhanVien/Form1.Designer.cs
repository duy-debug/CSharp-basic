namespace QuanLyNhanVien
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbMaNhanVien = new TextBox();
            txbHoTen = new TextBox();
            txbNamSinh = new TextBox();
            txbChucVu = new TextBox();
            txbTimKiem = new TextBox();
            btnTimKiem = new Button();
            btbnThem = new Button();
            btnSua = new Button();
            btnReset = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(38, 76);
            label2.Name = "label2";
            label2.Size = new Size(145, 26);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(79, 26);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(38, 151);
            label4.Name = "label4";
            label4.Size = new Size(107, 26);
            label4.TabIndex = 1;
            label4.Text = "Năm sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(38, 190);
            label5.Name = "label5";
            label5.Size = new Size(97, 26);
            label5.TabIndex = 1;
            label5.Text = "Chức vụ:";
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.Font = new Font("Times New Roman", 12F);
            txbMaNhanVien.Location = new Point(189, 75);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.Size = new Size(228, 30);
            txbMaNhanVien.TabIndex = 2;
            // 
            // txbHoTen
            // 
            txbHoTen.Font = new Font("Times New Roman", 12F);
            txbHoTen.Location = new Point(189, 111);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(228, 30);
            txbHoTen.TabIndex = 2;
            // 
            // txbNamSinh
            // 
            txbNamSinh.Font = new Font("Times New Roman", 12F);
            txbNamSinh.Location = new Point(189, 151);
            txbNamSinh.Name = "txbNamSinh";
            txbNamSinh.Size = new Size(228, 30);
            txbNamSinh.TabIndex = 2;
            // 
            // txbChucVu
            // 
            txbChucVu.Font = new Font("Times New Roman", 12F);
            txbChucVu.Location = new Point(189, 191);
            txbChucVu.Name = "txbChucVu";
            txbChucVu.Size = new Size(228, 30);
            txbChucVu.TabIndex = 2;
            txbChucVu.TextChanged += textBox4_TextChanged;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Font = new Font("Times New Roman", 12F);
            txbTimKiem.Location = new Point(666, 190);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(228, 30);
            txbTimKiem.TabIndex = 2;
            txbTimKiem.TextChanged += textBox4_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(900, 187);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 35);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btbnThem
            // 
            btbnThem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btbnThem.Location = new Point(584, 76);
            btbnThem.Name = "btbnThem";
            btbnThem.Size = new Size(99, 35);
            btbnThem.TabIndex = 3;
            btbnThem.Text = "Thêm";
            btbnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(689, 76);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 35);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(900, 76);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 35);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(794, 76);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 35);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1076, 424);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 699);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnReset);
            Controls.Add(btnSua);
            Controls.Add(btbnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txbTimKiem);
            Controls.Add(txbChucVu);
            Controls.Add(txbNamSinh);
            Controls.Add(txbHoTen);
            Controls.Add(txbMaNhanVien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbMaNhanVien;
        private TextBox txbHoTen;
        private TextBox txbNamSinh;
        private TextBox txbChucVu;
        private TextBox txbTimKiem;
        private Button btnTimKiem;
        private Button btbnThem;
        private Button btnSua;
        private Button btnReset;
        private Button btnXoa;
        private DataGridView dataGridView1;
    }
}
