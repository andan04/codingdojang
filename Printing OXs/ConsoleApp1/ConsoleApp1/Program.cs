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
            XO(6);
        }
        static void XO(int input)
        {
            int o = input - 1; // 'O'출력 개수
            int x = 1; // 'X'출력 개수
            for (int i = 1; i <= input; i++)
            {
                for (int o_count = 1; o_count <= o; o_count++) // o값 만큼 'O'출력
                {
                    Console.Write("O");
                }
                for (int x_count = 1; x_count <= x; x_count++) // x값 만큼 'X'출력
                {
                    Console.Write("X");
                }
                o--;
                x++;
                Console.WriteLine();
            }
        }
    }
}
