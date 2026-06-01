using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 1000까지의 소수를 출력하고 몇 개인지 출력
    internal class Example_55
    {
        static void Main(string[] args)
        {
            int _checkPrimeNumber = 0;

            Console.WriteLine("입력한 수까지의 모든 소수를 출력하고 개수를 확인합니다.");
            Console.Write("숫자를 입력해 주세요 : ");

            while (!int.TryParse(Console.ReadLine(), out _checkPrimeNumber) || _checkPrimeNumber <= 1 )
            {
                Console.WriteLine("1보다 큰 수를 입력해 주세요.");
                Console.Write("숫자를 입력해 주세요 : ");
            }

            Console.WriteLine();
            PrimeNumberCal(_checkPrimeNumber);
        }

        // 소수 계산
        private static void PrimeNumberCal(int checkPrimeNumber)
        {
            int _primeNumberCount = 0;
            int index;

            Console.Write("입력한 숫자 사이의 소수는 ");
            // 소수 확인 수
            for (int i = 2; i < checkPrimeNumber; i++)
            {
                // 자신 외 나눠지는 수가 있는지 확인
                for (index = 2; index < i; index++)
                {
                    // 나누어지면 약수이므로 다음 수 확인
                    if (i % index == 0)
                    {
                        break;
                    }
                }
                
                // 나눠지는 수가 자기 자신이면 소수
                if (i == index)
                {
                    _primeNumberCount++;

                    Console.Write($"{i}, ");
                }
            }

            Console.WriteLine($"\n 2부터 {checkPrimeNumber} 사이의 소수의 개수는 {_primeNumberCount}개 입니다.");
        }
    }
}
