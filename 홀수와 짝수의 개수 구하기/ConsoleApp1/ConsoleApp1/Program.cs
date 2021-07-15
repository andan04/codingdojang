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
            Odd_even(new List<int> { 3, 4, 5, 6 ,7 });
            Odd_even(new List<int> { 12, 16, 22, 24, 29 });
            Odd_even(new List<int> { 41, 43, 45, 47, 49 });
        }
        static void Odd_even(List<int> input)
        {
            int odd = 0;
            int even = 0;
            foreach(int i in input)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("홀수 {0}개, 짝수 {1}개", odd, even);
        }
    }
}
