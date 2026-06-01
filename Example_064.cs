using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 버블정렬
    internal class Example_64
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] randomArray = new int[10]; // 배열 생성

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 51); // 1~50 숫자 저장
            }

            // 배열 출력
            PrintArray(randomArray);

            // 버블 정렬 실행
            BubbleSort(randomArray);
        }

        // 버블 정렬
        private static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    // 현재 값이 다음 값보다 크면 두 값을 교환
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = 0;
                            
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                // 정렬 과정 출력
                PrintSortProcedure(arr);
            }
        }

        // 배열 출력
        private static void PrintArray(int[] arr)
        {
            Console.Write($"array[{arr.Length}] 배열의 수 : ");

            foreach(int value in arr)
            {
                Console.Write($"[{value}] ");
            }

            Console.WriteLine();
        }

        // 정렬 과정
        private static void PrintSortProcedure(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write($"[{value}] ");
            }

            Console.WriteLine();
        }
    }
}
