using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 증가 연산자, 감소 연산자, 대입 연산자의 압축
    internal class Example_24
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);  // 대입 연산자 압축
            Console.WriteLine(x -= 10);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++); // 후증가 연산자
            Console.WriteLine(--x); // 선감소 연산자
        }
    }
}
