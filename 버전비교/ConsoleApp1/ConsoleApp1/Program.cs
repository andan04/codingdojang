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
            Version("0.0.2", "0.0.1");
            Version("1.0.10", "1.0.3");
            Version("1.2.0", "1.1.99");
            Version("1.1", "1.0.1");
        }
        static void Version(string a, string b)
        {
            string[] a_split = a.Split('.'); // a를 '.'로 나눔
            string[] b_split = b.Split('.'); // b를 '.'로 나눔
            for(int i = 0; i < Math.Min(a_split.Length, b_split.Length); i++)
            {
                if(int.Parse(a_split[i]) > int.Parse(b_split[i])) // a_split[i]값이 b_split[i]값보다 크면 a출력후 Exit로 이동
                {
                    Console.WriteLine("{0} > {1}", a, b);
                    goto Exit;
                }
                else if(int.Parse(a_split[i]) < int.Parse(b_split[i])) // a_split[i]값이 b_split[i]값보다 작으면 b출력후 Exit로 이동
                {
                    Console.WriteLine("{0} > {1}", b, a);
                    goto Exit;
                }
            }
            Console.WriteLine((a_split.Length > b_split.Length) ? a : b); // 길이 차이로 버전 차이가 날 경우 길이가 긴 버전 출력
            Exit: // 중복 출력 막기 위해
                Console.WriteLine();
        }
    }
}
