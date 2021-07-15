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
            Binary(79);
        }
        static void Binary(int input)
        {
            string binary = "";
            while (input > 0)
            {
                binary = binary.Insert(0, (input % 2).ToString());
                input /= 2;
            }
            Console.WriteLine(binary);
        }
    }
}
