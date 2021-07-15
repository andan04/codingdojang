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
            Time_three();
        }
        static void Time_three()
        {
            int total = 0; // 3이 표시되는 시간의 초

            for (int hour = 0; hour < 24; hour++) // 시
            {
                for (int minute_ten = 0; minute_ten < 6; minute_ten++) // 분의 십의 자리
                {
                    for (int minute_one = 0; minute_one < 10; minute_one++) // 분의 일의 자리
                    {
                        string time = hour.ToString() + minute_ten.ToString() + minute_one.ToString(); // 시간

                        bool t = time.Contains("3"); // time에 3이 있으면 true, total에 1분(60초) 더함

                        if (t == true)
                        {
                            total += 60;
                        }
                    }
                }
            }

            Console.WriteLine(total);
        }
    }
}
