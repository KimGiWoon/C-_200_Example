using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 실수를 표현하는 float, double, decimal
    internal class Example_12
    {
        static void Main(string[] args)
        {
            float a = 1f / 3;
            double b = 1d / 3;
            decimal c = 1m / 3;

            Console.WriteLine($"float : {a}\ndouble : {b}\ndecimal : {c}"); // 유효 자리수 float : 소수점 7자리, double : 소수점 15~16자리, decimal : 소수점 28~29자리
            Console.WriteLine($"float : {sizeof(float)} byte\ndouble : {sizeof(double)} byte\ndecimal : {sizeof(decimal)} byte"); // 크기 출력 float : 4바이트, double : 8바이트, decimal : 16바이트
            Console.WriteLine($"float : {float.MinValue}~{float.MaxValue}");    // 최소값, 최대값 출력
            Console.WriteLine($"double : {double.MinValue}~{double.MaxValue}");
            Console.WriteLine($"decimal : {decimal.MinValue}~{decimal.MaxValue}");
        }
    }
}
