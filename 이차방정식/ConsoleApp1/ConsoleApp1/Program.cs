using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void Equation(int a, int b, int c)
        {
            int discriminant = b * b + -4 * a * c; // 중근 허근 구별
            if (discriminant > 0)
            {
                Console.WriteLine(Math.Round((-b + Math.Sqrt(b * b + -4 * a * c)) / 2 * a));
                Console.WriteLine(Math.Round((-b - Math.Sqrt(b * b + -4 * a * c)) / 2 * a));
            }
            else if (discriminant == 0) // 중근인 경우
            {
                Console.WriteLine("중근");
                Console.WriteLine((-b + Math.Sqrt(b * b + -4 * a * c)) / 2 * a);
            }
            else if (discriminant < 0) // 허근인 경우
            {
                Console.WriteLine("허근");
            }
        }
    }
}
