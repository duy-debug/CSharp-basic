using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 5;
            y = 10;
            Console.WriteLine("x= " +x);
            x += y;
            Console.WriteLine("x= " + x);
            int n;
            Console.WriteLine("Nhap n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("n vua nhap la: " + n);
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", n);
            }
            else
            {
                Console.WriteLine("{0} la so le", n);
            }
            const float p = 3.14f;
            int r;
            float dientich, chuvi;
            Console.WriteLine("Nhap ban kinh: ");
            r = int.Parse(Console.ReadLine());
            chuvi = 2*p * r;
            dientich = p * r * r;
            Console.WriteLine("Chu vi = {0}, Dien tich= {1}", chuvi, dientich);
            Console.ReadKey();
        }
    }
}
