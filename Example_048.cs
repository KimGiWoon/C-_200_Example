using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 팩토리얼 구하기
    internal class Example_48
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("n!을 계산합니다.");

            while (true)
            {
                Console.Write("정수 n을 입력하세요 : ");

                if (int.TryParse(Console.ReadLine(), out n) && n >= 0 && n <= 12)   // 13은 int의 범위 초과
                {
                    break;
                }

                Console.WriteLine("0이상 12이하의 정수를 다시 입력해 주세요.");
            }

            // 입력한 수 계승 구하기
            FactorialCal(n);
        }

        private static void FactorialCal(int n)
        {
            int facValue = 1;

            for (int i = 1; i <= n; i++)
            {
                facValue *= i;
            }

            Console.WriteLine($"{n}! = {facValue}입니다.");
        }
    }
}
