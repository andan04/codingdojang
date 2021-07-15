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
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Multiple(int.Parse(input[0]), int.Parse(input[1]));
            }
        }
        static void Multiple(int x, int n)
        {
            int temp = x;
            while (temp > 0)
            {
                temp -= n;
            }
            if (temp == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
