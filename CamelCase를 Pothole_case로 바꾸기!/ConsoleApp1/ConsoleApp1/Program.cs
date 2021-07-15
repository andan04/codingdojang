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
            Case("codingDojang");
            Case("numGoat30");
        }
        static void Case(string input)
        {
            string temp = input.ToLower(); // input을 소문자로 변경
            int e = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != temp[i] || int.TryParse(input[i].ToString(), out e) == true) // input[i]가 대문자이거나 숫자면 '_'를 넣고 소문자로 변경
                {
                    temp = temp.Insert(i, "_");
                    input = input.Insert(i, " ");
                    i++;
                }
            }
            Console.WriteLine(temp);
        }
    }
}
