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
            Average(new List<int> { 4, 6, 8 });
            Average(new List<int> { 11, 17, 20, 24 });
            Average(new List<int> { 26, 33, 45, 51, 60 });
        }
        static void Average(List<int> input)
        {
            int total = 0;
            foreach (var i in input)
            {
                total += i;
            }
            Console.WriteLine(total / input.Count);
        }
    }
}
