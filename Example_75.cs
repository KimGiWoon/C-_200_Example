using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 팩토리얼을 계산하는 메서드
namespace C__200_Example
{
    internal class Example_75
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("팩토리얼 구하기!");
            Console.Write("팩토리얼을 구할 숫자를 입력하세요 : ");

            // 입력 숫자 체크
            while (!int.TryParse(Console.ReadLine(), out number) || (number < 1 || number > 15))
            {
                Console.Write("1이상 15이하의 숫자를 입력하세요 : ");
            }

            FactorialCal(number);
        }

        // 입력 숫자 팩토리얼 계산
        private static void FactorialCal(int number)
        {
            int fact = 1;
            
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine($"{number}! = {fact:N0}");
        }
    }
}
