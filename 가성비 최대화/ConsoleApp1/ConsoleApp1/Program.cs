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
            Value_for_money(10, 150, 3, "30, 70, 15, 40, 65");
        }
        static void Value_for_money(int original_price, int original_performance, int add_price, string add_performance)
        {
            string[] add_performance_array = add_performance.Split(','); // add_performance를 내림차순으로 정렬하기 위해 split후 list로 변경
            List<int> add_performance_list = new List<int> { };
            double max = 0; // 최대 가성비 변수
            foreach (string i in add_performance_array)
            {
                add_performance_list.Add(int.Parse(i));
            }
            add_performance_list.Sort();
            add_performance_list.Reverse();
            for(int i = 0; i < add_performance_list.Count; i++) // 값이 같기에 가성비가 가장 높은 것을 찾기 위해 내림차순으로 비교
            {
                if ((original_performance + add_performance[i]) / (original_price + add_price * (i + 1)) >= max)
                {
                    max = (original_performance + add_performance_list[i]) / (original_price + add_price * (i + 1));
                    original_performance += add_performance_list[i];
                }
            }
            Console.WriteLine(Math.Truncate(max));
        }
    }
}
