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
            Every_other_digit("a1b2cde3~g45hi6");
        }
        static void Every_other_digit(string input)
        {
            int temp;
            for (int i = 0; i < input.Length; i++)
            {
                if ((i + 1) % 2 == 0 && int.TryParse(input[i].ToString(), out temp) == true) // i가 짝수이고 숫자이면 *로 변경
                {
                    input = input.Insert(i, "*");
                    input = input.Remove(i + 1, 1);
                }
            }
            Console.WriteLine(input);
        }
    }
}
