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
            Length("공백을 제외한" +
                "글자수만을 세는 코드 테스트");
        }
        static void Length(string input)
        {
            input = input.Replace(" ", "");
            input = input.Replace("\n", "");
            Console.WriteLine(input.Length);
        }
    }
}
