using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoten;
            float diemtoan;
            float diemvan;
            Console.WriteLine("Nhap vao ho ten: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap vao diem toan: ");
            diemtoan=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem van: ");
            diemvan=float.Parse(Console.ReadLine());
            Console.WriteLine("Hoc sinh ten {0} co diem van la {1} co diem toan la {2}", hoten, diemtoan, diemvan);
            float x,y;
            Console.WriteLine("Nhap vao x va y: ");
            x= float.Parse(Console.ReadLine());
            y= float.Parse(Console.ReadLine());
            float z = x + y;
            float z1 = x - y;
            float z2 = x * y;
            float z3 = x / y;
            float z4 = x % y;
            Console.WriteLine("{0} + {1} = {2}", x, y, z);
            Console.WriteLine("{0} - {1} = {2}", x, y, z1);
            Console.WriteLine("{0} * {1} = {2}", x, y, z2);
            Console.WriteLine("{0} / {1} = {2}", x, y, z3);
            Console.WriteLine("{0} % {1} = {2}", x, y, z4);
            Console.ReadKey();  
        }
    }
}
