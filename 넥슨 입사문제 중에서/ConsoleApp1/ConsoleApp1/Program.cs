using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> generators = new List<int> { }; // 제네레이터를 가진 수를 모으는 리스트
        static int total = 0; //셀프 넘버의 합을 구하는 변수
        static void Main(string[] args)
        {
            for (int i = 1; i < 5000; i++)
            {
                Generator(i);
            }
            for (int i = 1; i < 5000; i++)
            {
                if (generators.IndexOf(i) == -1) // 셀프 넘버를 total에 더함
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
        static void Generator(int input) //  제네레이터를 찾고 리스트에 추가하는 메소드
        {
            int temp = input;
            while (input > 0) // input과 input의 각 자리수 합을 더해 제네레이터를 가진 수를 찾음
            {
                temp += input % 10;
                input /= 10;
            }
            if (generators.IndexOf(temp) == -1) // generators에 temp가 없으면 제네레이터를 가진 수인 temp를 더함
            {
                generators.Add(temp);
            }
        }
    }
}
