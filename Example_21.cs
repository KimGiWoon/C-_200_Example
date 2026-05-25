using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 논리 연산자
    internal class Example_21
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10;
            int second = 20;

            result = (first == second) || (first > 5);  // 논리합 연산자
            Console.WriteLine($"{first == second} || {first > 5} : {result}");

            result = (first == second) && (first > 5);  // 논리곱 연산자
            Console.WriteLine($"{first == second} && {first > 5} : {result}");

            result = true ^ false;  // 배타적 논리합 연산자
            Console.WriteLine($"{true} ^ {false} : {result}");

            result = !(first > second); // NOT 연산자
            Console.WriteLine($"!{first > second} : {result}");
        }
    }
}
