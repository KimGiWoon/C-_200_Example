using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 재귀메서드로 역수의 합 계산
namespace C__200_Example
{
    internal class Example_81
    {
        static void Main(string[] args)
        {
            int value = 0;

            Console.WriteLine("입력한 수의 역수의 합을 계산합니다.");

            value = InputValue();

            // 역수의 합 계산 재귀메서드 호출
            Console.WriteLine($"1~{value}의 역수의 합은 {GetSumOfReciCal(value)}입니다.");
        }

        // 숫자 입력
        private static int InputValue()
        {
            int value;

            Console.Write("숫자를 입력해 주세요 : ");

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 1)
            {
                Console.WriteLine("1이상의 숫자를 입력해주세요");
                Console.Write("숫자를 입력해 주세요 : ");
            }

            return value;
        }

        // 역수의 합 계산
        private static double GetSumOfReciCal(int value)
        {
            // 종료 조건
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return 1.0 / value + GetSumOfReciCal(value - 1);

                // 3의 역수의 합 ex)
                // return 1.0 / value + GetSumOfReciCal(value - 1);   1.0 / 3 + GetSumOfReciCal(2)  (return 1.8333333333...)
                // return 1.0 / value + GetSumOfReciCal(value - 1);   1.0 / 2 + GetSumOfReciCal(1)  (return 1.5)
                // return 1.0 / value + GetSumOfReciCal(value - 1);   value == 1  (return 1)
            }
        }
    }
}
