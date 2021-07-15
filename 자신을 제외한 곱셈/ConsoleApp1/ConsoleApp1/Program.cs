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
            Multiple(2, 6, 4, 7);
        }
        static void Multiple(int a, int b, int c, int d)
        {
            int total = 1;
            List<int> input = new List<int> { a, b, c, d };
            for (int i = 0; i < input.Count; i++)
            {
                for (int e = 0; e < input.Count; e++)
                {
                    if (i == e)
                    {
                        continue;
                    }
                    total *= input[e];
                }
                Console.Write(total + " ");
                total = 1;
            }
            Console.WriteLine();
        }
    }   
}
