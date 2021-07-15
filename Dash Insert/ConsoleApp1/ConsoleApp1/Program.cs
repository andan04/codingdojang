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
            Dash_insert("4546793");
        }
        static void Dash_insert(string input)
        {
            List<string> input_list = new List<string> { };
            foreach(char i in input)
            {
                input_list.Add(i.ToString());
            }
            for(int i = 0; i < input_list.Count - 1; i++)
            {
                if (int.Parse(input_list[i].ToString()) % 2 == 0 && int.Parse(input_list[i + 1].ToString()) % 2 == 0) // 짝수가 연속되면 "*"을 insert
                {
                    input_list.Insert(i + 1, "*");
                    i++;
                }
                else if (int.Parse(input_list[i].ToString()) % 2 != 0 && int.Parse(input_list[i + 1].ToString()) % 2 != 0) // 홀수가 연속되면 "-"를 insert
                {
                    input_list.Insert(i + 1, "-");
                    i++;
                }
            }
            foreach (string i in input_list)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
