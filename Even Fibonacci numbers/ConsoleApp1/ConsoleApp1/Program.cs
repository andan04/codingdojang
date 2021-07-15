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
            Even_fibonacci(4000000);
        }
        static void Even_fibonacci(int input)
        {
            List<int> fibonacci_list = new List<int> { 1, 2 }; // 피보나치 수열 리스트
            int total = 0;
            for (int i = 0; fibonacci_list[i] < input; i++) // input(여기서는 4000000) 이하의 피보나치 수열 만듬
            {
                fibonacci_list.Add(fibonacci_list[i] + fibonacci_list[i + 1]);
            }
            foreach (var i in fibonacci_list) // 짝수면 total에 더해 total 출력
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
