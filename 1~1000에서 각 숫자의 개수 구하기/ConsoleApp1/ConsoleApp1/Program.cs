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
            Count(10, 15);
            Count(1, 1000);
        }
        static void Count(int from, int to)
        {
            int[] num = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 숫자가 몇개인지 저장하는 배열
            for (int i = from; i <= to; i++)
            {
                int temp = i; // 값이 변하는 임시 변수
                while (temp != 0)
                {
                    num[temp % 10] += 1; // temp의 각 숫자의 위치 +1
                    temp /= 10;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} : {1}개", i, num[i]);
            }
        }
    }
}
