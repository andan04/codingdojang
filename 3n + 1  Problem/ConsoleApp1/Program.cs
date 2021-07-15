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
            InputLength(1, 10);
            InputLength(100, 200);
            InputLength(201, 210);
            InputLength(900, 1000);
        }
        static int FindCycle(int n) // 사이클 길이를 구하는 메소드
        {
            int cycle = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    cycle++;
                    n /= 2;
                }
                else
                {
                    cycle++;
                    n = n * 3 + 1;
                }
            }
            return cycle;
        }
        static void InputLength(int a, int b) // 최대 사이클 길이를 구하는 메소드
        {
            int max_cycle = 0;
            for (int i = a; i <= b; i++)
            {
                int result = FindCycle(i);
                if (result > max_cycle)
                {
                    max_cycle = result;
                }
            }
            Console.WriteLine("{0} {1} {2}", a, b, max_cycle + 1);
        }
    }
}
