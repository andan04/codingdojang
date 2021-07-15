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
            Type("c910m6ia 1ho");

        }
        static void Type(string input)
        {
            string str = "";
            string int_ = "";
            int temp;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out temp) == true)
                {
                    int_ += temp;
                }
                else
                {
                    str += input[i];
                }
            }
            Console.WriteLine("str : {0}", str);
            Console.WriteLine("int : {0}", int_);
        }
    }
}
