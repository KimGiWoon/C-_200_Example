using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{   
    // 산술 연산자
    internal class Example_17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수의 계산");
            Console.WriteLine(123 + 45);    // 연산자 계산 출력
            Console.WriteLine(123 - 45);
            Console.WriteLine(123 * 45);
            Console.WriteLine(123 / 45);
            Console.WriteLine(123 % 45);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine(123.45 + 65.78);
            Console.WriteLine(123.45 - 65.78);
            Console.WriteLine(123.45 * 65.78);
            Console.WriteLine(123.45 / 65.78);
            Console.WriteLine(123.45 % 65.78);
        }
    }
}
