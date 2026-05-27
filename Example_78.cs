using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 원의 면적을 계산하는 메서드
namespace C__200_Example
{
    internal class Example_78
    {
        static void Main(string[] args)
        {
            int firstRadius = 1;
            int maxValue = 10;

            Console.WriteLine("1~10cm까지 원의 면적을 구합니다.");

            for (int i = firstRadius; i <= maxValue; i++)
            {
                Console.WriteLine($"반지름 {i,2}cm인 원의 넓이는 : {CalculateCircleArea(i):F2} 입니다.");
            }
        }

        // 원의 넚이 구하기 (파이 X 반지름 X 반지름)
        private static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
