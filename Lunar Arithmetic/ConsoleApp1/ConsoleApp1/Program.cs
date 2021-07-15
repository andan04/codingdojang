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
            Sum(5, 3);
            Sum(13, 6);
            Sum(169, 248);
            Mul(5, 3);
            Mul(13, 6);
            Mul(169, 248);
        }

        static void Sum (int a, int b) // 덧셈 연산
        {
            int longer_digit = Math.Max(a.ToString().Length, b.ToString().Length); // 큰 자릿수 찾기
            string a_digit = a.ToString().PadLeft(longer_digit, '0'); // 두 수의 자릿수 맞추기
            string b_digit = b.ToString().PadLeft(longer_digit, '0');
            for(int i = 0; i < longer_digit; i++)
            {
                Console.Write((a_digit[i] >= b_digit[i]) ? a_digit[i] : b_digit[i]);
            }
            Console.WriteLine();
        }

        static void Mul (int a, int b) // 곱셈 연산
        {
            List<string> result = new List<string> { };
            int max = 0;
            int digit = 1; // 자릿수
            string temp = ""; // 값 임시 저장
            string a_str = a.ToString();
            string b_str = b.ToString();
            for(int i = b_str.Length - 1; i >= 0; i--) // 곱셈 값 리스트에 저장
            {
                for(int x = a_str.Length - 1; x >= 0; x--)
                {
                    temp = ((b_str[i] <= a_str[x]) ? b_str[i] : a_str[x]) + temp;
                }
                result.Insert(0, (int.Parse(temp) * digit).ToString());
                digit *= 10;
                temp = "";
            }
            int result_length = result[0].Length;
            for(int i = 0; i < result.Count; i++)  // 자릿수  맞춤
            {
                result[i] = result[i].PadLeft(result_length, '0');
            }
            for (int i = 0; i < result_length; i++) // 곱셈 값의 각 자릿수 최댓값 출력
            {
                for(int x = 0; x < result.Count; x++)
                {
                    max = Math.Max(int.Parse(result[x][i].ToString()), max);
                }
                Console.Write(max);
                max = 0;
            }
            Console.WriteLine();
        }
    }
}
