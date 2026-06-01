using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 반복문 (1에서 100까지 더하기, 홀수의 합, 역수의 합)
    internal class Example_43
    {
        static void Main(string[] args)
        {
            Console.Write("1 부터 순차적으로 더하고 싶은 숫자를 입력하세요 : ");
            bool check = int.TryParse(Console.ReadLine(), out int value);

            if (!check)
            {
                Console.WriteLine("잘못된 입력으로 종료합니다!! 숫자를 입력하세요.");
                return;
            }
            
            // for문 더하기
            For_1_100_Sum(value);
            // While문 더하기
            Whlie_1_100_Sum(value);
            // Do While문 더하기
            DoWhile_1_100_Sum(value);
        }

        // for문 더하기
        private static void For_1_100_Sum(int value)
        {
            int sum = 0;
            int oddSum = 0;
            double reciprocalSum = 0;

            for (int i = 1; i <= value; i++)
            {
                // 정수의 합
                sum += i;
                // 역수의 합
                reciprocalSum += 1.0 / i;

                // 홀수의 합
                if (i % 2 == 1) 
                {
                    oddSum += i;
                }
            }

            Console.WriteLine($"\nfor문을 활용한 1에서 {value}까지 더하기 값 : {sum}");
            Console.WriteLine($"for문을 활용한 1에서 {value}까지 홀수의 합 값 : {oddSum}");
            Console.WriteLine($"for문을 활용한 1에서 {value}까지 역수의 합 값 : {reciprocalSum}\n");
        }

        // While문 더하기
        private static void Whlie_1_100_Sum(int value)
        {
            int count = 1;
            int sum = 0;
            int oddSum = 0;
            double reciprocalSum = 0;

            while (count <= value)
            {
                sum += count;
                reciprocalSum += 1.0 / count;

                if (count % 2 == 1)
                {
                    oddSum += count;
                }

                count++;
            }

            Console.WriteLine($"While문을 활용한 1에서 {value}까지 더하기 값 : {sum}");
            Console.WriteLine($"While문을 활용한 1에서 {value}까지 홀수의 합 값 : {oddSum}");
            Console.WriteLine($"While문을 활용한 1에서 {value}까지 역수의 합 값 : {reciprocalSum}\n");
        }

        // Do While문 더하기
        private static void DoWhile_1_100_Sum(int value)
        {
            int count = 1;
            int sum = 0;
            int oddSum = 0;
            double reciprocalSum = 0;
            do
            {
                sum += count;
                reciprocalSum += 1.0 / count;

                if (count % 2 == 1)
                {
                    oddSum += count;
                }

                count++;

            } while (count <= value);

            Console.WriteLine($"Do While문을 활용한 1에서 {value}까지 더하기 값 : {sum}");
            Console.WriteLine($"Do While문을 활용한 1에서 {value}까지 홀수의 합 값 : {oddSum}");
            Console.WriteLine($"Do While문을 활용한 1에서 {value}까지 역수의 합 값 : {reciprocalSum}");
        }
    }
}
