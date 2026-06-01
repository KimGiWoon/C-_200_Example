using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 소수 판단기
    internal class Example_49
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("소수를 판단합니다.");

            while (true)
            {
                Console.Write("숫자를 입력하세요 : ");

                if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    break;
                }

                Console.WriteLine("1이상의 정수를 입력해 주세요.");
            }

            // 소수 판별
            PrimeNumberCheck(num);
        }

        // 입력 값 소수 판별
        private static void PrimeNumberCheck(int num)
        {
            if (num == 1)
            {
                Console.WriteLine($"{num}는 소수가 아닙니다.");
                return;
            }

            // 1과 자신으로 밖에 나눠지지 않는 수
            for (int i = 2; i <= num; i++)
            {
                if (num == i)
                {
                    Console.WriteLine($"{num}는 1과 {i}로만 나뉘어져 소수가 맞습니다.");
                    break;
                }

                if (num % i == 0)
                {
                    Console.WriteLine($"{num}는 {i}로 나뉘어져 소수가 아닙니다.");
                    break;
                }
            }
        }
    }
}
