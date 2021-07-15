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
            Ones(3);
            Ones(7);
            Ones(9901);
        }
        static void Ones(int input)
        {
            string temp = "1"; // 자릿수가 1인 경우
            long count = 1; // 자릿수 변수
            while (true)
            {
                if (long.Parse(temp) % input == 0) // temp가 input으로 나누어지면 break하고 count 출력
                {
                    break;
                }
                else
                {
                    temp += "1";
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
