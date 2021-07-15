using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string a = "crossword";
        static string b = "boolean";
        static void Main(string[] args)
        {
            Overlap(a, b);
        }
        static void Overlap(string input_a, string input_b) // 중복 알파벳 체크
        {
            string word = "";
            for (int temp_b = 0; temp_b < input_b.Length; temp_b++)
            {
                if (input_a.Contains(input_b[temp_b]) == true)
                {
                    word = input_b[temp_b].ToString();
                }
            }
            if(word == "")
            {
                Console.WriteLine("None");
            }
            else
            {
                word_puzzle(word);
            }
        }
        static void word_puzzle(string input)
        {
            int position_a = a.IndexOf(input);
            int position_b = b.IndexOf(input);
            for (int count = 0; count < b.Length; count++) // 중복 위치 까지 '.'출력, 특정 위치에서 a출력
            {
                if (count == position_b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (i == position_a)
                        {
                            Console.Write(b[count]);
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
