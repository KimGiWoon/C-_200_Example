using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 문자열 검색
    internal class Example_28
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "cow";

            bool b = s1.Contains(s2);   // 찾고 싶은 단어 찾기
            Console.WriteLine($"'{s2}' is in the string '{s1}' : {b}");

            if (b)
            {
                int index = s1.IndexOf(s2); // 찾은 단어의 시작 인덱스 확인
                if (index >= 0)
                {
                    Console.WriteLine($"{s2} begins at index {index}");
                }
            }
            else
            {
                int index2 = s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase); // 대소문자를 무시하여 찾은 단어의 시작 인덱스 확인 
                if (index2 >= 0)
                {
                    Console.WriteLine($"{s2} is in the string {s1}");
                    Console.WriteLine($"{s2} begins at index {index2}");
                }
            }
        }
    }
}
