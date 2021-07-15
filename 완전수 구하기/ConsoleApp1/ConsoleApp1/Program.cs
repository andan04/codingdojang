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
            Perfect(9000);
        }
        static void Perfect(int input)
        {
            int total = 0; // 약수의 합
            for (int i = 1; i < input; i++)
            {
                for (int e = 1; e <= i / 2; e++) // 약수를 모두 더함
                {
                    if (i % e == 0)
                    {
                        total += e;
                    }
                }
                if (total == i) // 약수의 합 == i이면 i 출력
                {
                    Console.WriteLine(i);
                }
                total = 0;
            }
        }
    }
}
