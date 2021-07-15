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
            Sequence(1, 10);
            Sequence(100, 200);
            Sequence(201, 210);
            Sequence(900, 1000);
        }
        static void Sequence(int i, int j)
        {
            int max_count = 0; // count를 비교해 가장 큰 count 저장
            for(int x = i; x <= j; x++)
            {
                int temp = x; // x의 값 임시 저장
                int count = 1; // 사이클이 한번 돌 때마다 +1
                while (temp != 1)
                {
                    temp = (temp % 2 == 0) ? temp / 2 : temp * 3 + 1; // temp가 짝수면 / 2, 홀수면 *3 + 1
                    count++;
                }
                if (count > max_count)
                {
                    max_count = count;
                }
            }
            Console.WriteLine("{0} {1} {2}", i, j, max_count);
        }
    }
}
