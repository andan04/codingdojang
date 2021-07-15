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
            Pythagoras(3, 4);
        }

        static void Pythagoras(int a, int b) // 대각선의 길이를 구하는 메소드
        {
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}
