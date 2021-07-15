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
            Sort("-1 1 3 -2 2");
        }
        static void Sort(string input)
        {
            string[] array = input.Split(' '); // input값을 공백으로 나눈 배열
            List<int> list = new List<int> { };
            foreach (string i in array)
            {
                list.Add(int.Parse(i)); // array값을 list에 적용
            }
            for(int i = list.Count - 1; i >= 0; i--)
            {
                if(list[i] < 0) // list[i]가 0 이하이면 맨 앞에 넣고 list[i] 제거
                {
                    list.Insert(0, list[i]);
                    list.RemoveAt(i + 1);
                }
            }
            foreach (int i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
