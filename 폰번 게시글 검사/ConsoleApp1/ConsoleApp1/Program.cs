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
            Number("영일영 - 구구칠8 - 일구팔사");
            Number("0일영.칠칠칠팔.이삼사");
            Number("영 일 칠 삼 칠 오 팔 이 팔 이");
            Number("영일일 34구구 4 오 9 이");
        }
        static void Number(string input)
        {
            input = input.Replace(" ", ""); // 공백, -, .등 제거
            input = input.Replace("-", "");
            input = input.Replace(".", "");
            string number = "";
            string temp = "";
            Dictionary<string, string> convert = new Dictionary<string, string> { { "영", "0" }, { "일", "1" }, { "이", "2" }, { "삼", "3" },
                { "사", "4" }, { "오", "5" }, { "육", "6" }, { "칠", "7" }, { "팔", "8" }, { "구", "9" } };
            for (int i = 0; i < input.Length; i++)
            {
                try // 한글을 숫자로 변환
                {
                    int.Parse(input[i].ToString());
                    temp = input[i].ToString();
                }
                catch
                {
                    temp = convert[input[i].ToString()];
                }
                number += temp;
            }
            Console.WriteLine(number);
            string length = number[0].ToString() + number[1].ToString() + number[2].ToString();
            if (length == "010" && number.Length == 11) // 앞번호가 010이고 11자리
            {
                Console.WriteLine(true);
            }
            else if (int.Parse(length) < 020 && int.Parse(length) > 010) // 앞번호가 011~019이고 10자리 또는 11자리
            {
                if (number.Length == 11 || number.Length == 10)
                {
                    Console.WriteLine(true);
                }
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
