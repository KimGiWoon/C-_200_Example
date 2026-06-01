using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 가변길이 매개변수 params의 사용 방법
namespace C__200_Example
{
    internal class Example_90
    {
        static void Main(string[] args)
        {
            PrintIntParams(1, 2, 3, 4);
            PrintObjectParams(1, 1.234, 'a', "Test");
            PrintObjectParams();

            int[] intArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(intArray);

            object[] objectArray = { 1, 2.45, 'b', "Test", "Again" };
            // PrintIntParams(objectArray); // 에러
            PrintObjectParams(objectArray);
            PrintObjectParams(intArray);
        }

        // 가변 정수형 매개변수 출력
        public static void PrintIntParams(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }

        // 가변 오브젝트형 매개변수 출력 (오브젝트는 int, double, char, string의 값을 모두 가질 수 있음)
        public static void PrintObjectParams(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }
    }
}
