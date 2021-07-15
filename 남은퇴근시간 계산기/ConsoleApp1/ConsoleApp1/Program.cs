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
            Time_sec();
            Time_hour();
        }
        static void Time_sec()
        {
            int leave_time = 63000; // 현우의 퇴근 시간 값(초)
            int time = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second; // 현재 시간 값
            Console.WriteLine("퇴근까지 {0}초 남음", (leave_time - time < 0)? leave_time + 86400 - time : leave_time - time);
        }
        static void Time_hour()
        {
            int leave_time = 173000; // 현우의 퇴근 시간 값
            string time = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            string temp = ((leave_time - int.Parse(time) < 0) ? leave_time + 240000 - int.Parse(time) : leave_time - int.Parse(time)).ToString();
            temp = temp.PadLeft(6, '0');
            temp = temp.Insert(2, ":");
            temp = temp.Insert(5, ":");

            Console.WriteLine("퇴근까지 {0}남음", temp);
        }
    }
}
