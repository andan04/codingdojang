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
            Length(156);
            Length(18961);
        }
        static void Length(int input)
        {
            int total = 1;
            for (int temp = 1; temp <= input.ToString().Length; temp++)
            {
                total *= 10;
            }
            Console.WriteLine($"{total / 10}의 자리수");
        }
    }
}
