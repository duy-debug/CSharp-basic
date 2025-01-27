using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            nv1.TenNV = "Trần Mai Ngọc Duy";
            nv1.MaNV = 1;
            Console.WriteLine("Tên nhân viên là: " +nv1.TenNV + " Mã nhân viên là:" +nv1.MaNV);
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.TenNV = "Ngọc Nữ";
            hc1.MaNV = 2;
            Console.WriteLine("Tên nhân viên là:" +hc1.TenNV + " Mã nhân viên là: " +hc1.MaNV);
            Console.ReadKey();
        }
    }
}
