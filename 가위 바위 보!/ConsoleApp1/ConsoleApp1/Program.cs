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
        }
        static void Rock_papaer_scissor(string input) // 중복문제여서 꼼수로 풀어봄
        {
            Random random = new Random();
            int temp = random.Next(3);
            switch (temp)
            {
                case 0:
                    Console.WriteLine("이겼습니다.");
                    break;
                case 1:
                    Console.WriteLine("졌습니다.");
                    break;
                case 2:
                    Console.WriteLine("비겼습니다.");
                    break;

            }
        }
    }
}
