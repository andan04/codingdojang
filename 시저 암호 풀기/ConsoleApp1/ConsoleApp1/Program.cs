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
            Caesar("CAT", 5);
        }
        static void Caesar(string input, int n)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(Convert.ToChar((Convert.ToInt32(input[i]) - 65 + n % 26) % 26 + 65)); // 아스키로 변환 후 값을 더하고 다시 문자로 출력
                // n만큼 더했을때 Z를 넘어가면 다시 앞으로 돌아감
            }
            Console.WriteLine();
        }
    }
}
