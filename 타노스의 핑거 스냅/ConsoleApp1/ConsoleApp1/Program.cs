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
            Thanos(new List<int> { 2, 3, 1, 6, 5, 7 });
        }
        static void Thanos(List<int> input)
        {
            Random random = new Random();
            int count = input.Count;
            if (count % 2 == 0) // 짝수일 경우
            {
                for (int i = 0; i < count / 2; i++)
                {
                    input.RemoveAt(random.Next(0, input.Count));
                }
            }
            else if (count % 2 == 1) // 홀수일 경우
            {
                int temp = random.Next(1, 3);
                if (temp % 2 == 0) // 절반
                {
                    for (int i = 0; i < count / 2; i++)
                    {
                        input.RemoveAt(random.Next(0, input.Count));
                    }

                }
                else if (temp % 2 != 0) // 절반 + 1
                {
                    for (int i = 0; i < (count / 2) + 1; i++)
                    {
                        input.RemoveAt(random.Next(0, input.Count));
                    }

                }
            }
            foreach (var i in input)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
