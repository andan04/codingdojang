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
            string input = Console.ReadLine();
            Rock_paper_scissors(input);
        }
        static void Rock_paper_scissors(string input)
        {
            List<string> list = new List<string> { "가위", "바위", "보" }; // 가위 == 0, 바위 == 1, 보 == 2
            int input_operation = list.BinarySearch(input); // input을 숫자값으로 변경
            Random random = new Random(); // 랜덤 함수
            int com = random.Next(3);
            if (input_operation - com == 1 || input_operation - com == -2)
            {
                Console.WriteLine("이겼습니다.");
            }
            else if (input_operation == com)
            {
                Console.WriteLine("비겼습니다.");
            }
            else
            {
                Console.WriteLine("졌습니다.");
            }
        }
    }
}
