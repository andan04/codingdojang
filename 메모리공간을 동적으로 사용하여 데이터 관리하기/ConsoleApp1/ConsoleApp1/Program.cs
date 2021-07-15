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
            new Coding_dojang().Memory(int.Parse(Console.ReadLine()));
        }
        class Coding_dojang
        {
            public void Memory(int input)
            {
                int sum = 0;

                for (int i = 0; i < input; i++)
                {
                    sum += int.Parse(Console.ReadLine());
                }

                Console.WriteLine(sum);
                Console.WriteLine(sum / input);
            }

            // 소멸자
            ~Coding_dojang()
            {
            }
        }
    }
}
