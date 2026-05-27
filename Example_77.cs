using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2의 n승을 계산하는 메서드
namespace C__200_Example
{
    internal class Example_77
    {
        static void Main(string[] args)
        {
            int number = 2;
            int n = 0;

            Console.WriteLine("2의 n승을 구합니다.");
            Console.Write("n의 숫자를 입력하세요 : ");

            // 입력한 n이 1보다 작거나 정수가 아니면 반복
            while(!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("0이상의 숫자를 입력하세요 : ");
            }

            Console.WriteLine($"2의 {n}승을 구합니다.");
            // 결과 출력
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"2 ^ {i} = {GetPowerOfTwo(number, i)}");
            }
        }

        // 2의 n승 구하기
        private static int GetPowerOfTwo(int number, int n)
        {
            int powerNum = 1;

            for (int i = 0; i < n; i++)
            {
                powerNum *= number;
            }

            return powerNum;
        }
    }
}
