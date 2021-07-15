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
            Eratosthenes(2, 1000);
        }
        static void Eratosthenes(int from, int to)
        {
            List<int> temp = new List<int> { }; // 소수 리스트
            for (int i = from; i <= to; i++)
            {
                for (int e = 0; e < temp.Count; e++) // i가 i이하의 소수로 나누어지는지 확인
                {
                    if (i % temp[e] == 0) // i가 소수가 아니면 temp에 추가하지 않음
                    {
                        goto Exit;
                    }
                }
                temp.Add(i);
                Exit:
                continue;
            }
            foreach (var i in temp)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
