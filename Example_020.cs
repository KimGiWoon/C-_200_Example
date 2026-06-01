using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 관계 연산자
    internal class Example_20
    {
        static void Main(string[] args)
        {
            bool result = false;
            int first = 10;
            int second = 20;

            result = (first == second);     // 양쪽 값이 같다
            Console.WriteLine($"{first} == {second} : {result}");

            result = (first > second);      // 왼쪽 값이 더 크다
            Console.WriteLine($"{first} > {second} : {result}");

            result = (first < second);      // 오른쪽 값이 더 크다
            Console.WriteLine($"{first} < {second} : {result}");

            result = (first >= second);     // 왼쪽 값이 오른쪽 값보다 크거나 같다
            Console.WriteLine($"{first} >= {second} : {result}");

            result = (first <= second);     // 오른쪽 값이 왼쪽 값보다 크거나 같다
            Console.WriteLine($"{first} <= {second} : {result}");

            result = (first != second);     // 양쪽 값이 같지 않다
            Console.WriteLine($"{first} != {second} : {result}");
        }
    }
}
