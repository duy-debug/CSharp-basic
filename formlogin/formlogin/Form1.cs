using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using formlogin.Model;
using Azure.Identity;
using System.Security.Cryptography;


namespace formlogin
{
    public partial class Form1 : Form
    {
        private readonly LoginDbContext _db = new LoginDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            string username = txbTaikhoan.Text;
            string password = txbMatkhau.Text;

            user user = new user();

            user = _db.users.Find(username);

            if (user != null && user.password == HashPassword(password))
            {
                MessageBox.Show("Đăng nhập thành công");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbMatkhau_TextChanged(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
