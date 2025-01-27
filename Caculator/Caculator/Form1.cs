namespace Caculator
{
    public partial class Form1 : Form
    {
        private string operation = ""; // Lưu phép toán hiện tại (+, -, *, /)
        private double number1 = 0;       // Lưu giá trị số đầu tiên
        private double number2 = 0;       // Lưu giá trị số thứ hai
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textHienthi.Text);
            operation = "/";
            textHienthi.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "4";
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textHienthi.Text = "";
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textHienthi.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "3";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textHienthi.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textHienthi.Text += "9";
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textHienthi.Text);
            operation = "+";
            textHienthi.Text = "";
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textHienthi.Text);
            operation = "-";
            textHienthi.Text = "";
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textHienthi.Text);
            operation = "*";
            textHienthi.Text = "";
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(textHienthi.Text);
            double ketqua = 0;
            switch(operation)
            {
                case "+":
                    ketqua = number1 + number2;
                    break;
                case "-":
                    ketqua = number1 - number2;
                    break;
                case "*":
                    ketqua = number1 * number2;
                    break;
                case "/":
                    if(number2 != 0)
                    {
                        ketqua = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia hết cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    break;  
            }
            textHienthi.Text = ketqua.ToString();
            operation = "";
        }
    }
}
