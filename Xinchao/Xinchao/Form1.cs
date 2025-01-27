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
            label2.Text = "Xin chào " + hoten;
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            MessageBox.Show("Xin chào "+ hoten);
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            label2.Text = "Xin chào " + hoten;
            
        }

        private void buttonTextbox_Click(object sender, EventArgs e)
        {
            string hoten = txbNhaphoten.Text;
            textBox1.Text = "Xin chào " + hoten;
        }
    }
}
