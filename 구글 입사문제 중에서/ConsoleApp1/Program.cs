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
            int total = 0; //총합

            for (int i = 1; i < 10000; i++)
            {
                int temp = i;

                while (temp != 0)
                {
                    if (temp % 10 == 8) // temp를 10으로 나눈 나머지가 8일 경우 total += 1 하고 10으로 나눔
                    {
                        total++;

                        temp /= 10;
                    }
                    else
                    {
                        temp /= 10;
                    }

                }
            }

            Console.WriteLine(total);
        }
    }
}
