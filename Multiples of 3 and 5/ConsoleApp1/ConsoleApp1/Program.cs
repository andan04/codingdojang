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
            Multiples(1000);
        }
        static void Multiples(int input)
        {
            int total = 0; // 총합
            for(int i = 0; i < input; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
