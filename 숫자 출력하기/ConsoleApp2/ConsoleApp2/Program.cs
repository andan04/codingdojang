using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }
        static void Print()
        {
            string two = "  "; // 공백의 길이로 숫자 출력
            string zero = "";
            string one = " ";
            string five = "     ";

            Console.Write(two.Length);
            Console.Write(zero.Length);
            Console.Write(one.Length);
            Console.Write(five.Length);
            Console.Write(zero.Length);
            Console.Write(one.Length);
            Console.Write(one.Length);
            Console.Write(one.Length);
            Console.WriteLine();
        }
    }
}
