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
            List("1 10 20 30 40 50");
            List("4 가 나 다 라 마 바 사");
            List("-2 A B C D E F G");
            List("0 똘기 떵이 호치 새초미");
        }
        static void List(string input)
        {
            string[] array = input.Split(' '); // 입력을 Array로 바꾼 후 List로 변경
            List<string> list = new List<string> { };
            foreach (string i in array)
            {
                list.Add(i);
            }
            int num = int.Parse(list[0].ToString()); // 회전 양과 방향을 정하는 값을 저장하고 리스트에서 제거
            list.RemoveAt(0);
            for (int i = 0; i < ((num >= 0) ? num : list.Count + num); i++) // 회전 양에 맞춰 마지막 값을 앞으로 옮기고 마지막 값 제거
            {
                list.Insert(0, list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
            }
            foreach (string i in list) // 바뀐 값 출력
            {
                Console.Write(i + ' ');
            }
            Console.WriteLine();
        }
    }
}
