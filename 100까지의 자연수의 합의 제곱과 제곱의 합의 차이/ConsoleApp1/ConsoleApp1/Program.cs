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
            Difference(100);
        }
        static void Difference(int input)
        {
            int sum_total = 0;
            int square_total = 0;
            for(int i = 1; i <= input; i++)
            {
                sum_total += i;
                square_total += i * i; 
            }
            sum_total *= sum_total;
            Console.WriteLine(Math.Abs(sum_total - square_total));
        }
    }
}
