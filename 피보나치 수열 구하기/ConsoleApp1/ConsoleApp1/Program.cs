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
            Fibonacci(1000);
        }
        static void Fibonacci(int input)
        {
            List<int> fibonacci_list = new List<int> { 0, 1 }; // 피보나치 수열 리스트
            for (int i = 0; fibonacci_list[i] + fibonacci_list[i + 1] <= input; i++) // input 이하의 피보나치 수열 찾기
            {
                fibonacci_list.Add(fibonacci_list[i] + fibonacci_list[i + 1]);
            }
            foreach(int i in fibonacci_list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
