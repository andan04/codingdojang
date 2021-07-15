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
            Palindrome();
        }
        static void Palindrome()
        {
            for(int x = 999; x > 99; x--)
            {
                for(int y = 999; y > 99; y--)
                {
                    char[] temp = (x * y).ToString().ToArray(); // x * y
                    char[] temp_reverse = temp.ToString().ToCharArray().Reverse().ToArray(); // x * y의 역순
                    if (temp == temp_reverse)
                    {
                        Console.WriteLine(x * y);
                        goto Exit;
                    }
                }
            }
            Exit:
            ;
        }
    }
}
