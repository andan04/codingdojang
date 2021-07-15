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
            Carry(123, 456);
            Carry(555, 555);
            Carry(123, 594);
            Carry(0, 0);
        }
        static void Carry(int a, int b)
        {
            if (a == 0 && b == 0) Environment.Exit(0); // 두 인수가 모두 0이면 프로그램 종료

            bool carry = false; // 올림이 있었는지 확인
            int carry_count = 0; // 올림 개수
            int max = 0; // 자릿수가 더 큰 값

            max = (a.ToString().Length > b.ToString().Length) ? a : b;

            for (int i = 0; i < max.ToString().Length; i++) // 자릿수 별로 비교해서 합이 10 이상이면 carry_count += 1  
            {
                if (a % 10 + b % 10 + ((carry == true) ? 1 : 0) >= 10) // 올림이 있었으면 +1을 해서 계산
                {
                    carry_count++;
                    carry = true; 
                    a /= 10;
                    b /= 10;
                }
                else
                {
                    carry = false;
                    a /= 10;
                    b /= 10;
                }
            }
            Console.WriteLine("{0} carry operation", (carry_count > 0) ? carry_count.ToString() : "No"); // 올림 갯수 출력
        }
    }
}
