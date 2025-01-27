using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhsongaunhien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random(); // cú pháp để tạo ra một đối tượng có thể sinh ra một  số ngẫu nhiên
            int songaunhien = rnd.Next(1,21); // 1-20
            Console.WriteLine("So ngau nhien: " +songaunhien);
            DateTime birthday = new DateTime(2005, 12, 30);
            Console.WriteLine("Ngay thang nam sinh cua ban: " +birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay sinh cua ban: " +birthday.ToString("dd"));
            Console.WriteLine("Thang sinh cua ban: " +birthday.ToString("MM"));
            Console.WriteLine("Nam sinh cua ban: " +birthday.ToString("yyyy"));
            DateTime birthday2 = DateTime.Parse("1999,12,30");
            Console.WriteLine("NGAY THANG NAM SINH 2 CUA BAN LA: " +birthday2.ToString("dd/MM/yyyy"));
            // Viet chuong trinh cho nguoi dung nhap vao ngay thang nam sinh
            Console.WriteLine("Nhap vao ngay thang nam sinh cua ban: ");
            string s = Console.ReadLine();
            DateTime birthday3 = DateTime.Parse(s);
            Console.WriteLine("Ngay sinh cua ban vua nhap la: " +birthday3.ToString("dd/MM/yyyy"));
        }
    }
}
