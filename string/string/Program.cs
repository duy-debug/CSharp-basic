using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // khai báo chuỗi
            string chuoi = "Duy lại lập trình";
            Console.WriteLine("Chuỗi vừa nhập là: " +chuoi);
            // khai báo nguyên văn
            string chuoi1 = "D:\\galailaptrinh";
            Console.WriteLine(chuoi1);
            int i = 1;
            string chuoi2 = i.ToString(); // cách 1
            Console.WriteLine(chuoi2);
            Console.ReadKey();
        }
    }
}
