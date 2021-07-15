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
            Total(10, 1000);
        }
        static void Total(int from, int to)
        {
            int total = 0; // 총합
            for (int i = from; i < to; i++)
            {
                int temp = i;
                int temp_mul = 1;
                while (temp != 0) // 각 자릿수의 곱을 합함
                {
                    temp_mul *= temp % 10;
                    temp /= 10;
                }
                total += temp_mul;
            }
            Console.WriteLine(total);
        }
    }
}
