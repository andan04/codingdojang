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
            Page(0, 1);
            Page(1, 1);
            Page(2, 1);
            Page(1, 10);
            Page(10, 10);
            Page(11, 10);
        }
        static void Page(double m, int n)
        {
            Console.WriteLine(Math.Ceiling(m / n));
        }
    }
}
