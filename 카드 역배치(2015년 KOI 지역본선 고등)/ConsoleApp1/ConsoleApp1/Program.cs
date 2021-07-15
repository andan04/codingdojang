using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> card = new List<int> { };

        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                card.Add(i);
            }
            Array(5, 10); // 임의로 10개
            Array(9, 11);
            Array(7, 14);
            Array(6, 18);
            Array(2, 19);
            Array(4, 17);
            Array(7, 12);
            Array(3, 13);
            Array(8, 20);
            Array(1, 11);
            foreach (var i in card)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Array(int a, int b)
        {
            int ai = a - 1;
            int bi = b - 1;
            for (int i = 0; i < (b - a) / 2; i++) // 일정 구간 뒤집기
            {
                int temp = card[ai];
                card[ai] = card[bi];
                card[bi] = temp;
                ai++;
                bi--;
            }
        }
    } 
}
