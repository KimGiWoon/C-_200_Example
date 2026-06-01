using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 재귀메서드로 팩토리얼 계산
namespace C__200_Example
{
    internal class Example_80
    {
        static void Main(string[] args)
        {
            int factNum = 0;

            Console.WriteLine("입력한 수의 팩토리얼을 계산합니다.");

            factNum = InputValue();

            // 팩토리얼 계산 재귀메서드 호출
            Console.WriteLine($"{factNum}! = {FactCal(factNum)}");
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

        // 팩토리얼 계산
        private static int FactCal(int value)
        {
            // 종료조건
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value * FactCal(value - 1);

                // 3! ex)
                // return value * FactCal(value - 1);   3 * FactCal(2)  (return 6)
                // return value * FactCal(value - 1);   2 * FactCal(1)  (return 2)
                // return value * FactCal(value - 1);   value == 1  (return 1)
            }
        }
    }
}
