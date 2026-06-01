using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 이중 반복문으로 팩토리얼과 합 구하기
    internal class Example_53
    {
        static void Main(string[] args)
        {
            int count = 0;
            int maxCount = 5;
            int factNumber = 0;
            int factSum = 0;
            int factTotalSum = 0;

            Console.WriteLine("팩토리얼 숫자를 다섯번 입력하고 합을 구합니다.");

            while (count < maxCount)
            {
                Console.Write($"{count + 1}번째 팩토리얼 숫자를 입력하세요 : ");
                
                if (!int.TryParse(Console.ReadLine(), out factNumber) || factNumber < 0)
                {
                    Console.WriteLine("1이상의 숫자를 입력하세요");
                    continue;
                }

                FactorialCal(factNumber, out factSum);

                factTotalSum += factSum;
                count++;
            }

            Console.WriteLine($"다섯번 입력한 팩토리얼의 합은 : {factTotalSum:N0}");
        }
        
        // 팩토리얼 계산 (이중 반복문)
        private static void FactorialCal(int factNumber, out int sum)
        {
            sum = 0;
            int fact = 0;

            for (int i = 1; i <= factNumber; i++)
            {
                fact = 1;

                for (int j = 2; j <= i; j++)
                {
                    fact *= j;
                }
                
            }
            sum = fact;

            Console.WriteLine($"{factNumber,2}! = {fact:#,#}");
        }
    }
}
