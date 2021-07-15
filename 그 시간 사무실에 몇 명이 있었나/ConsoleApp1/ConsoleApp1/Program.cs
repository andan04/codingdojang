using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int people = 0;
        static void Main(string[] args)
        {
            Time("09:12:23", "11:14:35");
            Time("10:34:01", "13:23:40");
            Time("10:34:31", "11:20:10");
            Console.WriteLine(people);
        }
        static void Time(string go_to_work, string get_off_work) // 출퇴근 시간을 받아 회사에 있었는지 확인하는 메소드
        {
            string time = "11:05:20";
            string[] time_split = time.Split(':');
            string[] go_to_work_split = go_to_work.Split(':');
            string[] get_off_work_split = get_off_work.Split(':');
            int time_second = To_second(time_split); // 특정 시간의 초
            int go_to_work_second = To_second(go_to_work_split); //출근 시간의 초
            int get_off_work_second = To_second(get_off_work_split); // 퇴근 시간의 초
            if(go_to_work_second <= time_second && get_off_work_second >= time_second)
            {
                people++;
            }
        }
        static int To_second(string[] input) // 시간을 초로 바꾸는 메소드
        {
            int second = 0;
            second += int.Parse(input[0]) * 3600;
            second += int.Parse(input[1]) * 60;
            second += int.Parse(input[2]);
            return second;
        }
    }
}
