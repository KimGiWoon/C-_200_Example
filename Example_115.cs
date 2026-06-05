using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Func과 Action으로 델리게이트 간단히 구현
namespace C__200_Example
{
    internal class Example_115
    {
        // 별도의 델리게이트 선언 없이 Func 델리케이트 사용

        static void Main(string[] args)
        {
            int oddCount = 0;
            int evenCount = 0;

            int[] arr = { 3, 5, 4, 2, 6, 4, 6, 8, 28, 59, 46, 9, 10 };

            Console.Write($"배열의 값 : ");

            foreach (int n in arr)
            {
                Console.Write($"{n}, ");
            }

            Console.WriteLine("Func 델리게이트 사용");
            int count = Count(arr, delegate (int a) { return a % 2 != 0; });    // 무명 델리케이트에 홀수 조건 전달
            Console.WriteLine($"홀수의 개수 : {count}개");

            count = Count(arr, delegate (int a) { return a % 2 == 0; });    // 무명 델리게이트에 짝수 조건 전달
            Console.WriteLine($"짝수의 개수 : {count}개");

            // Action 델리게이트 사용
            Console.WriteLine("\nAction 델리게이트 사용");
            PrintResult(arr, delegate (int a)
            {
                if (a % 2 != 0)
                {
                    oddCount++;
                }
                else
                {
                    evenCount++;
                }
            });

            Console.WriteLine($"홀수의 개수 : {oddCount}개");
            Console.WriteLine($"홀수의 개수 : {evenCount}개");
        }

        // 매개변수로 int형을 받아서 bool형으로 반환하는 Func 델리게이트 사용
        private static int Count(int[] arr, Func<int, bool> testMethod)
        {
            int count = 0;

            foreach(int value in arr)
            {
                if (testMethod(value))
                {
                    count++;
                }
            }

            return count;
        }

        // 매개변수로 전달받은 Action 델리게이트 실행
        private static void PrintResult(int[] arr, Action<int> testMethod)
        {
            foreach (int value in arr)
            {
                testMethod(value);
            }
        }
    }
}
