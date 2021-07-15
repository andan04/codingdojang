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
            int input_count = int.Parse(Console.ReadLine());
            for (int i = 0; i < input_count; i++)
            {
                Reverse_and_add(int.Parse(Console.ReadLine()));
            }
        }
        static void Reverse_and_add(int input)
        {
            bool palindrome = false; // 회문 참 거짓
            int count = 0; // 횟수
            while (palindrome == false)
            {
                string input_reverse = ""; // 입력값 거꾸로
                int temp = input; // input값을 리버스 하기 위한 변수
                for (int i = 0; i < input.ToString().Length; i++)
                {
                    input_reverse = input_reverse.Insert(i, (temp % 10).ToString());
                    temp /= 10;
                }
                if (input.ToString() == input_reverse) // 회문이면 palindrome = true 
                {
                    palindrome = true;
                    break;
                }
                input = (input + int.Parse(input_reverse));
                count++;
            }
            Console.Write(count + " ");
            Console.WriteLine(input);
        }
    }
}
