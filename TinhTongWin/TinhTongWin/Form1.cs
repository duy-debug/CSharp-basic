namespace TinhTongWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontinhtong_Click(object sender, EventArgs e)
        {
            float tong;
            Console.WriteLine(textBoxA.Text);
            Console.WriteLine(textBoxB.Text);
            tong = float.Parse(textBoxA.Text) + float.Parse(textBoxB.Text);
            labelketqua.Text = tong + "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Bạn có chắc chắn muốn reset không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reset == DialogResult.Yes)
            {
                labelketqua.Text = "";
                textBoxA.Text = "";
                textBoxB.Text = "";
            } 
                
        }
    }
}
