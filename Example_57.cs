using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 배열의 초기화와 배열 요소의 출력
    internal class Example_57
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            NotNewArrayCreate(a, b, c);
            NotSizeArrayCreate(a, b, c);
            SizeArrayCreate(a, b, c);
            NotInitArrayCreate(a, b, c);
        }

        // 1. new 키워드 없이 생성
        private static void NotNewArrayCreate(int a, int b, int c)
        {
            // 배열을 new 키워드 없이 생성, 초기화
            int[] array = { a, b, c };

            Console.Write("1번 배열의 요소는 a[] : ");

            foreach (int value in array)
            {
                Console.Write(value + ", ");
            }
        }

        // 2. 크기를 정하지 않고 생성
        private static void NotSizeArrayCreate(int a, int b, int c)
        {
            // 배열의 크기를 정하지 않고 생성, 초기화
            int[] array = new int[] { a, b, c };

            Console.Write("\n2번 배열의 요소는 a[] : ");

            foreach (int value in array)
            {
                Console.Write(value + ", ");
            }
        }

        // 3. 크기를 정하고 생성
        private static void SizeArrayCreate(int a, int b, int c)
        {
            // 배열의 크기를 정하고 생성, 초기화
            int[] array = new int[3] { a, b, c };

            Console.Write("\n3번 배열의 요소는 a[] : ");

            foreach (int value in array)
            {
                Console.Write(value + ", ");
            }
        }

        // 4. 배열을 생성 후 초기화 하지 않음
        private static void NotInitArrayCreate(int a, int b, int c)
        {
            // 배열 생성 후 초기화 하지 않음
            int[] array = new int[3];

            // 값 할당
            array[0] = a;
            array[1] = b;
            array[2] = c;

            Console.Write("\n4번 배열의 요소는 a[] : ");

            foreach (int value in array)
            {
                Console.Write(value + ", ");
            }
        }
    }
}
