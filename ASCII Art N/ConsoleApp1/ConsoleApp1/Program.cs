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
            Ascii_art(7);
        }
        static void Ascii_art(int input)
        {
            for (int i = 0; i < input; i++) // 앞쪽 세로 출력
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("N");
            }
            for (int i = 1; i < input - 1; i++) // 대각선 출력
            {
                Console.SetCursorPosition(i, i);
                Console.WriteLine("N");
            }
            for (int i = 0; i < input; i++) // 뒤쪽 세로 출력
            {
                Console.SetCursorPosition(input - 1, i);
                Console.WriteLine("N");
            }
            Console.WriteLine();
        }
    }
}
