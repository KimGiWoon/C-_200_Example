using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stopwatch로 피보나치 수열의 실행 시간 측정
namespace C__200_Example
{
    internal class Example_84
    {
        static long[] fibonacci = new long[51];

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("피보나치 수열을 입력한 숫자까지 출력합니다.");

            int number = InputNumber();

            FibonacciExecution(number, stopwatch);
        }

        // 숫자 입력
        private static int InputNumber()
        {
            int number = 0;

            Console.Write("숫자를 입력하세요 : ");

            while(!int.TryParse(Console.ReadLine(), out number) || number < 10 || number >= fibonacci.Length)
            {
                Console.WriteLine("10이상의 50이하의 숫자를 입력하세요");
                Console.Write("숫자를 입력하세요 : ");
            }

            return number;
        }

        // 피보나치 수열 실행
        private static void FibonacciExecution(int number, Stopwatch stopwatch)
        {
            // 스탑워치가 실행하지 않으면 시작
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }

            fibonacci[1] = 1;
            fibonacci[2] = 1;

            // 피보나치 수열 계산
            for (int i = 3; i <= number; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            // 반복문으로 피보나치 수열 실행 시간 출력
            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{fibonacci[i]} ");
            }

            Console.WriteLine();

            // 스탑워치 정지
            StopwatchStop(stopwatch);

            // 피보나치 수열 재귀 메서드
            for (int i = 1; i <= number; i++)
            {
                // 재귀메서드로 피보나치 수열 실행 시간 출력
                Console.Write($"{FibonacciRecursive(i, stopwatch)} ");
            }

            Console.WriteLine();

            // 스탑워치 정지
            StopwatchStop(stopwatch);
        }

        // 피보나치 재귀메서드 실행
        private static long FibonacciRecursive(int number, Stopwatch stopwatch)
        {
            // 스탑워치가 실행하지 않으면 시작
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }

            // 종료 조건
            if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursive(number - 1, stopwatch) + FibonacciRecursive(number - 2, stopwatch);
            }
        }

        // 스탑워치 시간 확인
        private static void StopwatchStop(Stopwatch stopwatch)
        {
            // 실행중이면 정지
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }

            long elapsedMillisencond = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"실행 시간은 : {elapsedMillisencond}ms 입니다.\n");

            // 스탑워치 리셋
            stopwatch.Reset();
        }
    }
}
