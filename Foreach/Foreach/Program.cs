using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            int[] lis = { 1, 3, 5, 7, 8, 10, 12};
            foreach (int i in lis)
            {
                if(thang==i)
                {
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
