using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn reser không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = "";
                txta.Text = "";
                txtb.Text = "";
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txta.Text);
            Console.WriteLine(txtb.Text);
            tong = int.Parse(txta.Text) + int.Parse(txtb.Text);
            lblKetQua.Text = tong + "";
        }

        private void btnhieu_Click(object sender, EventArgs e)
        {
            int hieu;
            Console.WriteLine(txta.Text);
            Console.WriteLine(txtb.Text);
            hieu = int.Parse(txta.Text) - int.Parse(txtb.Text);
            lblKetQua.Text = hieu + "";
        }
    }
}
