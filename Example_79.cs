using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 재귀메서드
namespace C__200_Example
{
    internal class Example_79
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            bool isFirst = false;

            Console.WriteLine("x의 n승을 구합니다");

            InputValue(out x, out n, isFirst);

            // 거듭제곱 구하기
            Console.WriteLine($"{x}의 {n}승은 {GetPower(x, n)}입니다.");

        }

        // 값 입력
        private static void InputValue(out int x, out int n, bool check)
        {
            bool isFirst = check;
            x = 0;
            n = 0;

            while (true)
            {
                if (isFirst == false)
                {
                    Console.Write("x의 값을 입력하세요 : ");

                    if (int.TryParse(Console.ReadLine(), out int xValue) && xValue > 0)
                    {
                        x = xValue;
                        isFirst = true;
                    }
                    else
                    {
                        Console.WriteLine("x의 값을 1이상의 숫자를 입력하세요");
                    }
                }
                else
                {
                    Console.Write("n의 값을 입력하세요 : ");

                    if (int.TryParse(Console.ReadLine(), out int nValue) && nValue >= 0)
                    {
                        n = nValue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("n의 값을 0이상의 숫자를 입력하세요");
                    }
                }
            }
        }
        
        // 거듭제곱 구하기 (재귀메서드)
        private static double GetPower(double x, int n)
        {
            // 종료 조건 (종료 조건이 없으면 무한호출에 빠짐)
            if (n == 0)
            {
                return 1;
            }
            else
            {
                // n을 1씩 줄여가며 재귀호출
                return x * GetPower(x, n - 1);

                // 2의 2승 ex)
                // return x * GetPower(x, n - 1);   2 * GetPower(2, 1) (return 4)
                // return x * GetPower(x, n - 1);   2 * GetPower(2, 0) (return 2)
                // return x * GetPower(x, n - 1);   n == 0 조건 (return 1)
            }
        }
    }
}
