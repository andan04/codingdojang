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
            Ascii('a');
            Ascii('d');
            Ascii('A');
        }
        static void Ascii(char input)
        {
            Console.WriteLine("{0}는 아스키코드로 {1}입니다.", input, Convert.ToInt32(input));
        }
    }
}
