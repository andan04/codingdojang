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
            Duplicate("0123456789");
            Duplicate("01234");
            Duplicate("01234567890");
            Duplicate("6789012345");
            Duplicate("012322456789");
        }
        static void Duplicate(string input)
        {
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 입력값과 비교할 리스트
            List<int> input_list = new List<int> { };
            bool duplicate = true; // 중복이 있으면 false 아니면 true
            for (int i = 0; i < input.Length; i++) // 오름차순 정렬 하기 위해 리스트로 변경
            {
                input_list.Add(int.Parse(input[i].ToString()));
            }
            input_list.Sort();
            if(list.Count != input_list.Count) // 길이가 다르면 false
            {
                duplicate = false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++) // list와 비교해 값이 다르면 false
                {
                    if (input_list[i] != list[i])
                    {
                        duplicate = false;
                    }
                }

            }
            Console.WriteLine(duplicate);
        }
    }
}
