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
            Pair(new int[] { 1, 3, 4, 8, 13, 17, 20 });
        }
        static void Pair(int[] input)
        {
            int min = input[1] - input[0]; // 가장 짧은 거리
            int num1 = 0; // 가장 짧은 거리 앞의 수
            int num2 = 0; // 가장 짧은 거리 뒤의 수
            for(int i = 0; i < input.Length - 1; i++)
            {
                if(input[i + 1] - input[i] <= min) // input의 i번째와 i + 1번째의 차가 min보다 짧으면 num1, num2, min에 값 할당
                {
                    min = input[i + 1] - input[i];
                    num1 = input[i];
                    num2 = input[i + 1];
                }
            }
            Console.WriteLine("({0}, {1})", num1, num2);
        }
    }
}
