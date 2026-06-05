using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 람다식 (익명 메서드를 간단하게 표현하는 방식이며 인수를 메서드로 전달하거나 값을 반환할 수 있다)
namespace C__200_Example
{
    internal class Example_116
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 4, 2, 6, 4, 6, 8, 28, 59, 46, 9, 10 };
            int count;
            Console.Write($"배열의 값 : ");

            foreach(int n in arr)
            {
                Console.Write($"{n}, ");
            }

            count = Count(arr, a => a % 2 != 0);    // 람다식 사용 (매개변수로 받은 a의 값을 n % 2 != 0 의 조건을 적용해 true, false를 반환함)
            Console.WriteLine($"\n홀수의 개수 : {count}개");

            count = Count(arr, a => a % 2 == 0);
            Console.WriteLine($"짝수의 개수 : {count}개");
        }

        // 매개변수로 int형을 받아서 bool형으로 반환하는 Func 델리게이트 사용
        private static int Count(int[] arr, Func<int, bool> testMethod)
        {
            int count = 0;

            foreach(int n in arr)
            {
                if (testMethod(n))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
