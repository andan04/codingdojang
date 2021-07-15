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
            Jolly_jumper("4 1 4 2 3");
            Jolly_jumper("5 1 4 2 -1 6");
        }
        static void Jolly_jumper(string input)
        {
            string[] input_split = input.Split(' '); // input을 공백으로 나눈배열
            List<int> sequence = new List<int> { }; // input_split을 리스트로 변경
            List<int> compare = new List<int> { }; // 숫자 차의 절댓값을 비교
            bool jolly = true; // 배열이 jolly인지 아닌지 비교
            for (int i = 0; i < input_split.Length - 1; i++) // input_split의 각 값의 차 저장
            {
                sequence.Add(Math.Abs(int.Parse(input_split[i]) - int.Parse(input_split[i + 1]))); 
            }
            for(int i = 1; i < input_split.Length - 1; i++) // 1부터 sequnce의 길이 만큼 비교값 지정
            {
                compare.Add(i);
            }
            sequence.RemoveAt(0); // 각 줄의 맨 앞 수는 수열의 갯수이므로 제거 
            sequence.Sort(); // sequence를 정렬 후 비교
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] != compare[i])
                {
                    jolly = false;
                }
            }
            Console.WriteLine("{0}jolly", jolly ? "" : "not ");
        }
    }
}
