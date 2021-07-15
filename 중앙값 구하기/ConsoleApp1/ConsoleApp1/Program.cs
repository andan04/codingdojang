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
            Middle(new List<int> { 7, 9, 14 });
            Middle(new List<int> { 24, 31, 35, 49 });
            Middle(new List<int> { 17, 37, 37, 47, 57 });
        }
        static void Middle(List<int> input)
        {
            if (input.Count % 2 == 1) // 홀수일 경우
            {
                Console.WriteLine(input[input.Count / 2]);
            }
            else if (input.Count % 2 == 0) // 짝수일 경우
            {
                Console.WriteLine((input[input.Count / 2 - 1] + input[input.Count / 2]) / 2);
            }
        }
    }
}
