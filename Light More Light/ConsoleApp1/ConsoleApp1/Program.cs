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
            Light(3);
            Light(6241);
            Light(8191);
            Light(0);
        }
        static void Light(int n)
        {
            bool on_off = false; // 마지막 전구가 켜저있는지에 대한 변수

            if (n == 0) // 입력이 0이면 프로그램 종료
            {
                Environment.Exit(0);
            }

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) // n이 i의 배수이면 마지막 전구의 스위치를 건드림
                {
                    on_off = !on_off;
                }
            }
            Console.WriteLine(on_off ? "yes" : "no");
        }
    }
}
