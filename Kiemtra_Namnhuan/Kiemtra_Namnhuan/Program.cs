using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra_Namnhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao mot nam: ");
            n = int.Parse(Console.ReadLine());
            if((n%4==0 && n%100==1) || n%400==0)
                Console.WriteLine("{0} la nam nhuan", n);
            else
                Console.WriteLine("{0} khong phai la nam nhuan", n);
            Console.ReadKey();
        }
    }
}
