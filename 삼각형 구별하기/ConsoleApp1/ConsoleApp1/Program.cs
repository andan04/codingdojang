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
            Triangle(new List<int> { 60, 60, 60 });
            Triangle(new List<int> { 30, 60, 90 });
            Triangle(new List<int> { 20, 40, 120 });
            Triangle(new List<int> { 0, 90, 90 });
            Triangle(new List<int> { 60, 70, 80 });
            Triangle(new List<int> { 40, 40, 50, 50 });
        }
        static void Triangle(List<int> input)
        {
            if(input.Count != 3 || input[0] + input[1] + input[2] != 180 || input.Contains(0)) // 각이 세개가 아님 or 각의 합이 180이 아님 or 0을 포함함
            {
                Console.WriteLine("삼각형이 아니다.");
            }
            else
            {
                if(input[0] < 90 && input[1] < 90 && input[2] < 90)
                {
                    Console.WriteLine("예각 삼각형");
                }
                else if (input.Contains(90))
                {
                    Console.WriteLine("직각 삼각형");
                }
                else if (input.Max() > 90)
                {
                    Console.WriteLine("둔각 삼각형");
                }
            }
        }
    }
}
