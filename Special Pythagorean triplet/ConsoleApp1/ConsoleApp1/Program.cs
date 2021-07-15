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
            Triplet();
        }
        static void Triplet()
        {
            for(int a = 1; a < 1000; a++)
            {
                for(int b = a + 1; b < 1000; b++)
                {
                    for(int c = b + 1; c < 1000; c++)
                    {
                        if (a + b + c == 1000 && a * a + b * b == c * c)
                        {
                            Console.WriteLine(a * b * c);
                        }
                    }
                }
            }
        }
    }
}
