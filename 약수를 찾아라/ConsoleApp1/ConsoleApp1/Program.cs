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
            Divisor(24);
            Divisor(36);
            Divisor(2468013579);
        }
        static void Divisor(uint input)
        {
            List<uint> divisor_list = new List<uint> { };
            for(uint i = 1; i <= input; i++)
            {
                if(input % i == 0)
                {
                    divisor_list.Add(i);
                }
            }
            Console.Write("{ ");
            foreach(uint i in divisor_list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("}");
            Console.WriteLine("약수의 개수는 {0}개 입니다.", divisor_list.Count);
        }
    }
}
