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
            Middle(2, 5, 3);
            Middle(4, 6, 4);
        }
        static void Middle(int a, int b, int c)
        {
            List<int> list = new List<int> { a, b, c };
            list.Sort();
            Console.WriteLine(list[1]);
        }
    }
}
