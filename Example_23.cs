using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 조건 연산자 (3항 연산자)
    internal class Example_23
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string result = input > 0 ? "양수입니다." : "음수입니다.";    // 대입에 사용한 조건 연산자 
            Console.WriteLine($"{input}는 {result}");
            Console.WriteLine("{0}는 {1}", input, input % 2 == 0 ? "짝수입니다." : "홀수입니다."); // 출력에 사용한 조건 연산자

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0,3}{1}", i, i % 10 == 0 ? "\n" : "");  // 조건 연산자로 10개 마다 줄바꿈
            }
        }
    }
}
