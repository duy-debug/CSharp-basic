using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // đọc chữ tiếng việt
            Console.Write("Hello world"); //không xuống dòng
            Console.WriteLine("Xin chào"); //xuống dòng
            Console.WriteLine(200);
            Console.WriteLine("Trần Mai Ngọc Duy");
            Console.WriteLine("2005/10/30");
            Console.WriteLine("giới tính: Nam");
            Console.WriteLine("19 TUỔI");
            Console.ReadLine(); // đặt cuối chương trình để dừng chương trình
        }
    }
}
