using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 평균, 최소, 최대값 구하기
    internal class Example_46
    {
        static void Main(string[] args)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double sumValue = 0;
            bool check = false;
            int count = 1;
            int maxCount = 5;

            Console.WriteLine("평균, 최소, 최대값을 구하는 예제입니다.");

            while(count <= maxCount)
            {
                Console.Write("아무 숫자나 5번 입력하세요 : ");
                check = double.TryParse(Console.ReadLine(), out double value);

                if (!check)
                {
                    Console.WriteLine("\n숫자를 입력하세요.");
                }
                else
                {
                    // 최대값 확인
                    if (value > maxValue)
                    {
                        maxValue = value;
                    }

                    // 최소값 확인
                    if (value < minValue)
                    {
                        minValue = value;
                    }

                    // 합계
                    sumValue += value;

                    Console.WriteLine($"{count}번째 숫자를 입력했습니다. 최대값 : {maxValue}, 최소값 : {minValue} 입니다.");
                    count++;
                }
            }

            Console.WriteLine($"입력이 끝났습니다. 최대값 : {maxValue}, 최소값 : {minValue}, 총합 : {sumValue}, 평균 : {sumValue / maxCount}입니다.");
        }
    }
}
