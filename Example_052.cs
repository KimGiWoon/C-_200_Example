using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 합계가 10000을 넘는 순간 확인하기 (for문 무한루프, 응용)
    internal class Example_52
    {
        static void Main(string[] args)
        {
            int maxValue = 10000;
            int sum = 0;

            Console.WriteLine("1부터 순차적으로 더해서 합이 10000이 넘는 순간을 확인하겠습니다.");

            // 조건이 없어 무한 루프 for문
            for (int i = 1; ; i++)
            {
                sum += i;

                if (sum >= maxValue)
                {
                    Console.WriteLine($"for문 무한루프의 1~{i}의 합 : {sum}");
                    break;
                }
            }

            sum = 0;
            int count = 1;

            for (;sum <= 10000;) // 초기식을 밖에서 생성, while문 처럼 사용
            {
                sum += count;
                count++;    // 내부에서 증감식
            }

            Console.WriteLine($"for문 응용식의 1~{count - 1}의 합 : {sum}");
        }
    }
}
