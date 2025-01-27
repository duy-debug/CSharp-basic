using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello world", "Thống báo",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //    Close();
            //else if (result == DialogResult.No)
            //    MessageBox.Show("Oke tiếp tục sử dụng phần mềm");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát không?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if ( result == DialogResult.Yes )
                e.Cancel = false;
            else 
                e.Cancel = true;
        }
    }
}
