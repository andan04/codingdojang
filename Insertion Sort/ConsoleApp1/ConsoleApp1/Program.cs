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
            Sort(new List<int>() { 5, 2, 4, 6, 1, 3 });
        }
        static void Sort(List<int> input)
        {
            List<string> list = new List<string> { };
            foreach (var i in input) // list에 값 저장
            {
                list.Add(i.ToString());
            }
            for (int i = 1; i < list.Count; i++) // list의 값 비교하고 위치 옮기기
            {
                for (int e = 0; e < i; e++)
                {
                    if (int.Parse(list[i]) < int.Parse(list[e]))
                    {
                        list.Insert(e, list[i]);
                        list.RemoveAt(i + 1);
                        break;
                    }
                }
            }
            foreach (var i in list)
            {
                Console.Write(i + ' ');
            }
            Console.WriteLine();
        }
    }
}
