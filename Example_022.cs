using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 비트 연산자
    internal class Example_22
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 11;
            int result;

            result = x | y; // 비트 합
            Console.WriteLine($"{x} | {y} = {result}");

            result = x & y; // 비트 곱
            Console.WriteLine($"{x} & {y} = {result}");

            result = x ^ y; // 비트 배타적 논리합
            Console.WriteLine($"{x} ^ {y} = {result}");

            result = ~x;    // 비트 NOT
            Console.WriteLine($"~{x} = {result}");

            result = x << 2;    // 비트 왼쪽 시프트
            Console.WriteLine($"{x} << 2 = {result}");

            result = y >> 1;    // 비트 오른쪽 시프트
            Console.WriteLine($"{y} >> 1 = {result}");
        }
    }
}
