using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 연산자와 식
    internal class Example_16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5);   // 곱하기 먼저
            Console.WriteLine((3 + 4) * 5); // 괄호 먼저
            Console.WriteLine(3 * 4 / 5);   // *, /는 연산 순서가 같아서 좌에서 우로 계산
            Console.WriteLine(3 / 4 * 5);   // 3 / 4가 0

            int a = 10;
            int b = 20;
            int c;

            Console.WriteLine(c = a + b);   // a + b를 하고 C에 대입
        }
    }
}
