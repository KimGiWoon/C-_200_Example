using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // String.Split() 메서드를 사용한 문자열 구문 분석
    internal class Example_26
    {
        static void Main(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력하세요 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split(); // 빈칸으로 입력 문자를 나누어 배열에 저장

            foreach(var i in v)
            {
                sum += int.Parse(i);
            }

            Console.WriteLine($"결과는 {sum}");
        }
    }
}
