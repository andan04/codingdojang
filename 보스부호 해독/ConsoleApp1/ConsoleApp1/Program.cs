using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Hashtable morse = new Hashtable();

        static void Main(string[] args)
        {
            Morse_decoding(".... .  ... .-.. . . .--. ...  . .- .-. .-.. -.--");
        }
        static void Morse_hashtable() // 모스부호 규칙 정리
        {
            morse.Add(".-", "a");
            morse.Add("-...", "b");
            morse.Add("-.-.", "c");
            morse.Add("-..", "d");
            morse.Add(".", "e");
            morse.Add("..-.", "f");
            morse.Add("--.", "g");
            morse.Add("....", "h");
            morse.Add("..", "i");
            morse.Add(".---", "j");
            morse.Add("-.-", "k");
            morse.Add(".-..", "l");
            morse.Add("--", "m");
            morse.Add("-.", "n");
            morse.Add("---", "o");
            morse.Add(".--.", "p");
            morse.Add("--.-", "q");
            morse.Add(".-.", "r");
            morse.Add("...", "s");
            morse.Add("-", "t");
            morse.Add("..-", "u");
            morse.Add("...-", "v");
            morse.Add(".--", "w");
            morse.Add("-..-", "x");
            morse.Add("-.--", "y");
            morse.Add("--..", "z");
            morse.Add("|", " "); // 두개의 공백을 하나의 공백으로 바꾸기 위한 임시 규칙
        }
        static void Morse_decoding (string input) // 모스 부호 해독
        {
            Morse_hashtable();
            input = input.Replace("  ", " | "); // 단어 사이의 두개의 공백을 하나로 바꾸기 위해 임시로 |로 바꿈
            string[] morse_ex_split = input.Split(' '); // 공백을 기준으로 나눔
            foreach (var i in morse_ex_split)
            {
                Console.Write(morse[i]);
            }
            Console.WriteLine();
        }
    }
}
