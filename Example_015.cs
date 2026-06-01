using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // Convert 클래스와 2진수, 8진수, 16진수 출력
    internal class Example_15
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫 번째 숫자를 입력하세요 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("두 번째 숫자를 입력하세요 : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");

            // 2진수, 8진수, 10진수, 16진수로 출력
            short value = short.MaxValue;   // 2바이트 최대값
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);    // 2진수 문자열로 변환
            int i = Convert.ToInt32(s, baseNum);            // 문자열을 2진수로 해석해서 정수로 변환
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");

            baseNum = 8;
            s = Convert.ToString(value, baseNum);           // 8진수 문자열로 변환
            i = Convert.ToInt32(s, baseNum);                // 문자열을 8진수로 해석해서 정수로 변환
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");

            baseNum = 10;
            s = Convert.ToString(value, baseNum);           // 10진수 문자열로 변환
            i = Convert.ToInt32(s, baseNum);                // 문자열을 10진수로 해석해서 정수로 변환
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");

            baseNum = 16;
            s = Convert.ToString(value, baseNum);           // 16진수 문자열로 변환
            i = Convert.ToInt32(s, baseNum);                // 문자열을 16진수로 해석해서 정수로 변환
            Console.WriteLine($"i = {i}, {baseNum,2}진수 = {s,16}");
        }
    }
}
