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
            Pattern(new List<int> { 1, 2, 5, 6, 4 });
            Pattern(new List<int> { 1, 2, 3, 6 });
            Pattern(new List<int> { 3, 8, 4, 1, 7 });
            Pattern(new List<int> { 2, 8, 4, 6 });
        }
        static void Pattern(List<int> input)
        {
            List<int> temp = new List<int> { };
            bool possible = true;
            bool overlap = false;
            for (int i = 0; i < input.Count - 1; i++) // 중복 확인
            {
                for (int e = i + 1; e < input.Count; e++)
                {
                    if (input[i] == input[e])
                    {
                        overlap = true;
                        break;
                    }
                }
            }
            if (overlap == false)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    temp.Add(input[i]);
                    if (input[i] % 2 != 0 && input[i + 1] % 2 != 0 && input[i] != 5 && input[i + 1] != 5 && temp.Contains((input[i] + input[i + 1]) / 2) == false)
                    {
                        possible = false;
                    }
                    else if (input[i] % 2 == 0 && input[i + 1] % 2 == 0 && (input[i] + input[i + 1]) / 2 == 5 && temp.Contains(5) == false)
                    {
                        possible = false;
                    }
                }
                Console.WriteLine(possible);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
