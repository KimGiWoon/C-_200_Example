using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메서드 오버로딩
namespace C__200_Example
{
    internal class Example_92
    {
        static void Main(string[] args)
        {
            Print(10);
            Print(Math.PI);
            Print("Sum", 123.4);
        }

        // 값 출력
        private static void Print(double x)
        {
            Console.WriteLine(x);
        }

        // 값 출력 오버로딩1
        private static void Print(string s, double x)
        {
            Console.WriteLine($"{s} = {x}");
        }

        // 값 출력 오버로딩2
        private static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
