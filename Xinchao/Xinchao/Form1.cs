namespace Xinchao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbNhaphoten_TextChanged(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            label2.Text = "Xin ch�o " + hoten;
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            MessageBox.Show("Xin ch�o "+ hoten);
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            label2.Text = "Xin ch�o " + hoten;
            
        }

        private void buttonTextbox_Click(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            textBox1.Text = "Xin ch�o " + hoten;
        }
    }
}
