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
            Digit(3);
            Digit(649);
        }
        static void Digit(int input)
        {
            Console.Write(input.ToString().Length);
            Console.WriteLine("자리수");
        }
    }
}
