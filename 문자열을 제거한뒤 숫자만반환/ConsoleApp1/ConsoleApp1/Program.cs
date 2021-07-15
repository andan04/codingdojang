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
            String_int("1w627r00o00p00");
        }
        static void String_int(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    int.Parse(input[i].ToString());
                }
                catch (FormatException) // 문자를 숫자로 변환할때 나오는 오류
                {
                    continue;
                }
                Console.Write((int.Parse(input[i].ToString())));
            }
            Console.WriteLine();
        }
    }
}
