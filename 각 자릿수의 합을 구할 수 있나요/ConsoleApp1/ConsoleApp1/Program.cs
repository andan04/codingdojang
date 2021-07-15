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
            Digit_sum(5923);
            Digit_sum(200);
            Digit_sum(6719283);
        }
        static void Digit_sum(int input)
        {
            int total = 0;
            while (input > 0)
            {
                total += input % 10;
                input /= 10;
            }
            Console.WriteLine(total);
        }
    }
}
