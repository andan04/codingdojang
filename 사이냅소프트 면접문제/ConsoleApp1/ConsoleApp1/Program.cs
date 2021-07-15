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
            Name("이유덕,이재영,권종표,이재영,박민호,강상희,이재영,김지완,최승혁,이성연,박영서,박민호,전경헌,송정환,김재성,이유덕,전경헌");
        
        }
        static void Name(string input)
        {
            int kim_or_lee = 0; // 김씨와 이씨의 수
            int jaeyoung_lee = 0; // 이름이 이재영인 수
            string[] name_array = input.Split(','); // ','로 나눠 array 에 저장
            for(int i = 0; i <  name_array.Length; i++)
            {
                if(name_array[i][0] == '김' || name_array[i][0] == '이') // 성이 '김' 또는 '이'일 경우 kim_or_lee++
                {
                    kim_or_lee++;
                }
                if(name_array[i] == "이재영") // 이름이 "이재영"일 경우 jaeyoung_lee++
                {
                    jaeyoung_lee++;
                }
            }
            Console.WriteLine("1." + kim_or_lee);
            Console.WriteLine("2."+ jaeyoung_lee);
            List<string> name_list = new List<string> { }; // 중복 제거를 위해 list로 변환
            foreach(string i in name_array)
            {
                name_list.Add(i);
            }
            name_list = name_list.Distinct().ToList(); // 중복 제거
            Console.Write("3.");
            foreach(string i in name_list)
            {
                Console.Write(i +' ');
            }
            Console.WriteLine();
            name_list.Sort(); // 오름차순 정렬
            Console.Write("4.");
            foreach(string i in name_list)
            {
                Console.Write(i + ' ');
            }
            Console.WriteLine();
        }
    }
}
