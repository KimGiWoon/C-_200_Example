using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 소수인지를 알아내는 정적 메서드
namespace C__200_Example
{
    internal class Example_71
    {
        static void Main(string[] args)
        {
            int count = 0;
            int maxValue = 100;

            Console.WriteLine("2~100까지의 숫자 중 소수를 찾아보겠습니다.");
            Console.Write("\n소수는 : ");

            // 소수를 찾는 반복문 (1은 소수가 아니므로 제외), 소수의 정의 : 1보다 큰 자연수 중에서, 약수가 1과 자기 자신 딱 2개뿐인 수
            for (int i = 2; i <= maxValue; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }

            Console.WriteLine($"\n2~100까지 소수는 모두 {count}개 있습니다.");
        }
        
        // 소수 확인 정적 메서드
        private static bool IsPrime(int value)
        {
            for(int i = 2; i < value; i++)
            {
                // 자신 의외 숫자와 나뉘어지면 소수가 아님
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
