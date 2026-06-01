using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 원주율 계산 (라이프니츠의 원주율 계산)
    internal class Example_50
    {
        static void Main(string[] args)
        {
            int count;

            Console.WriteLine("원주율을 계산합니다.");

            while (true)
            {
                Console.Write("반복 횟수를 입력하세요 : ");

                if (int.TryParse(Console.ReadLine(), out count) && count > 0)
                {
                    break;
                }

                Console.WriteLine("1이상의 정수를 입력해 주세요.");
            }

            // 원주율 계산 진행
            CalculatePi(count);
        }

        // 원주율 계산
        private static void CalculatePi(int count)
        {
            bool sign = false;  // false : 더하기, true : 빼기
            int denominator = 0;    // 분모 구하기
            double pi = 0;

            for (int i = 0; i < count; i++)
            {
                denominator = (2 * i) + 1;  // 라이프니츠 계산식의 분모는 1,3,5,7....인 홀수열로 계산

                if (sign == false)
                {
                    pi += 1.0 / denominator;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / denominator;
                    sign = false;
                }
            }

            pi *= 4;

            Console.WriteLine($"\n{count}회 반복하여 계산된 원주율 : {pi}");
            Console.WriteLine($"Math.PI 값   : {Math.PI}");
        }
    }
}
