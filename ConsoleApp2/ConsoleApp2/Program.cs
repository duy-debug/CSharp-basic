using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int soLuong = 0; // khởi tạo biến
            float diemTrungBinh = 8.5f;
            string name = "Toan";
            byte tuoi; // khai báo biến
            Console.WriteLine("So luong là: {0}", soLuong);
            Console.WriteLine("So luong là: {0}, diem trung binh la: {1} ", soLuong, diemTrungBinh);
            Console.ReadKey();
        }
    }
}
