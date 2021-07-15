using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> ran_list = new List<int> { };
        static List<int> input_list = new List<int> { };
        static int bulls = 0;
        static int cows = 0;
        static bool right = false;
        static void Main(string[] args)
        {
            Collection();
        }
        static void Random_list() // 랜덤 리스트를 만듬
        {
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random ran = new Random();

            for (int i = 0; i < 4; i++)
            {
                ran_list.Add(list[ran.Next(0, list.Count)]);
                list.Remove(ran_list[i]);
            }
        }
        static void User_input()
        {
            string input;
            bool temp = false;
            while (temp == false)
            {
                temp = true;
                input_list.Clear();
                input = Console.ReadLine();
                if (input.Length == 4) // 길이가 4이여야 함
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if ((int)input[i] > 64) // 입력이 숫자가 아닐 경우
                        {
                            Console.WriteLine("다시 입력하세요.");
                            temp = false;
                            break;
                        }
                        input_list.Add(int.Parse(input[i].ToString()));
                    }
                    for (int x = 0; x <= input_list.Count; x++)
                    {
                        for (int y = x + 1; y < input_list.Count; y++)
                        {
                            if (input_list[x] == input_list[y]) // 중복이 있을 경우
                            {
                                Console.WriteLine("다시 입력하세요.");
                                temp = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("다시 입력하세요.");
                    temp = false;
                }
            }
        }
        static void Bulls_and_cows() // 입력에 따라 bulls와 cow의 값을 추가
        {
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    if (a == b && ran_list[b] == input_list[a])
                    {
                        bulls++;
                    }
                    else if (ran_list[b] == input_list[a])
                    {
                        cows++;
                    }
                }
            }
            if (bulls == 4)
            {
                right = true;
            }
        }
        static void Collection()
        {
            Random_list();
            //foreach (var i in ran_list) // 랜덤 문자열 확인(주석 처리)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();
            for (int i = 1; i <= 11; i++)
            {
                if (right == true)
                {
                    Console.WriteLine("정답입니다. 총 입력한 횟수 : {0}", i - 1);
                    break;
                }
                if (i == 11 && right == false)
                {
                    Console.Write("Game Over\n 정답 : ");
                    foreach (var e in ran_list)
                    {
                        Console.Write(e);
                    }
                    Console.WriteLine();
                }
                else
                {
                    User_input();
                    Bulls_and_cows();
                    Console.WriteLine("판정 : {0}B{1}C, 입력한 횟수 : {2}", bulls, cows, i);
                    bulls = cows = 0;
                }
            }
        }
    }
}
