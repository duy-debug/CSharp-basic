using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, b, c, delta;
            Console.WriteLine("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = float.Parse(Console.ReadLine());
            delta = (b * b) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep la {0}", x);
            }
            else
            {
                float x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                float x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);
            }
            Console.ReadKey();
        }
    }
}
