using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 배열에서 최소, 최대, 평균 계산
    internal class Example_62
    {
        static void Main(string[] args)
        {
            Random random = new Random();   // 랜덤 객체 생성
            int[] values = new int[10];     // 정수 배열 생성

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(1, 101);    // 1~100까지 10개의 랜덤값 저장
            }

            // 최대값 계산
            MaxValueCal(values);

            // 최소값 계산
            MinValueCal(values);

            // 랜덤값의 합과 평균 계산
            AverageValueCal(values);
        }

        // 최대값 계산
        private static void MaxValueCal(int[] values)
        {
            int maxValue = values[0];    // 비교를 위한 값 저장
            //int maxValue = int.MinValue;    // 가장 작은 값
            //int maxValue = 0;   // 1~100 숫자이니 0으로 해도 가능

            Console.WriteLine("1~100까지 랜덤으로 저장된 10개의 값 중에 최대값, 최소값, 합, 평균을 계산합니다.");
            Console.WriteLine();
            Console.Write("10개의 값 : ");

            foreach (int value in values)
            {
                Console.Write($"[{value}], ");

                if (value > maxValue)   // 값을 비교해서 Max값 보다 크면
                {
                    maxValue = value;  // Max값 업데이트
                }
            }

            Console.WriteLine();
            Console.WriteLine($"\n최대값 : [{maxValue}] 입니다.");
        }

        // 최소값 계산
        private static void MinValueCal(int[] values)
        {
            int minValue = values[0];   // 비교를 위한 값 저장
            //int minValue = int.MaxValue;    // 가장 큰 값
            //int minValue = 101;   // 1~100 숫자이니 101으로 해도 가능

            foreach (int value in values)
            {
                if (value < minValue)   // 값을 비교해서 Min값 보다 작으면
                {
                    minValue = value;  // Min값 업데이트
                }
            }

            Console.WriteLine($"최소값 : [{minValue}] 입니다.");
        }

        // 랜덤값의 합과 평균 계산
        private static void AverageValueCal(int[] values)
        {
            int sumValue = 0;
            double averageValue = 0;

            foreach (int value in values)
            {
                sumValue += value;
            }

            averageValue = values.Average();    // LINQ의 평균값 계산 메서드 사용
            //averageValue = (double)sumValue / values.Length;   // 나누는 값 중 하나를 double로 형변환하면 실수 나눗셈이 되어 소수점까지 계산 가능

            Console.WriteLine($"값의 총합 : [{sumValue}] 입니다.");
            Console.WriteLine($"값의 평균 : [{averageValue}:F2] 입니다.");
        }
    }
}
