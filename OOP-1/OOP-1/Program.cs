using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SinhVien sinhVien1 = new SinhVien();
            //SinhVien sinhVien2 = new SinhVien();

            //Console.WriteLine(sinhVien1.MaSV);
            //Console.WriteLine(sinhVien1.TenSV);
            //sinhVien1.MaSV = 1234;
            //Console.WriteLine(sinhVien1.MaSV);
            // 1. Tạo 1 đối tượng mới không truyền giá trị
            SinhVien sinhVien1 = new SinhVien();
            SinhVien sinhVien2 = new SinhVien();
            Console.WriteLine(sinhVien1.MaSV);
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien2.MaSV);
            Console.WriteLine(sinhVien2.TenSV);
            //// 2. Tạo 1 đói tượng có truyền vào giá trị ban đầu
            //SinhVien sinhVien3 = new SinhVien(65130650,"Trần Mai Ngọc Duy");
            //Console.WriteLine("Mã sinh vien: " +sinhVien3.MaSV);
            //Console.WriteLine("Tên sinh viên là: "+sinhVien3.TenSV);
            //// 3. Sửa dữ liệu đối tượng
            //sinhVien3.MaSV = 123;
            //sinhVien3.TenSV = "Nguyễn văn A";
            //Console.WriteLine("Mã số sinh viên thay đổi: " +sinhVien3.MaSV);
            //Console.WriteLine("Tên sinh viển thay đổi: " +sinhVien3.TenSV);
            ////4. Phương thức Tostring
            //Console.WriteLine(sinhVien1.ToString());
            //Console.WriteLine(sinhVien3.ToString());
            //Console.WriteLine(sinhVien1);
            //Console.WriteLine(sinhVien3);
            // service method & support method
            SinhVien sinhVien3 = new SinhVien(3,"Nguyên văn DUY",20);
            // check
            sinhVien3.XuatThongTin();
            Console.ReadKey();
        }
    }
}
