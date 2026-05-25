using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 다차원 배열
    internal class Example_59
    {
        static void Main(string[] args)
        {
            int arrayValue = 9;

            TwoDimensionalArray(arrayValue);

            Console.WriteLine();

            JaggedArray(arrayValue);
        }

        // 2차원 배열
        private static void TwoDimensionalArray(int number)
        {
            int[,] array = new int[3, 3];

            Console.WriteLine("2차원 배열 array[3,3]에 1부터 9까지 채워넣기");

            for (int i = 1; i <= number; i++)
            {
                if ((i - 1) / 3 == 0)   // 1행의 요소에 들어갈 수 판별
                {
                    array[0, i - 1] = i;  // 1행의 수 채워 넣기
                }

                if ((i - 1) / 3 == 1)   // 2행의 요소에 들어갈 수 판별
                {
                    array[1, i - 4] = i;  // 2행의 수 채워 넣기
                }

                if ((i - 1) / 3 == 2)   // 3행의 요소에 들어갈 수 판별
                {
                    array[2, i - 7] = i;  // 3행의 수 채워 넣기
                }

                // 이렇게 줄여서도 가능함
                //int row = (i - 1) / 3;  // 행 위치 판별
                //int col = (i - 1) % 3;  // 열 위치 판별

                //array_1[row, col] = i;

            }

            PrintArray(array);
        }

        // 가변 배열
        private static void JaggedArray(int number)
        {
            int[][] array= new int[2][];

            array[0] = new int[5];
            array[1] = new int[4];

            Console.WriteLine("가변 배열 array[2][]에 1부터 9까지 나눠서 채워넣기");

            for (int i = 1; i <= number; i++)
            {
                int row = (i - 1) / 5;  // 행 위치 판별
                int col = (i - 1) % 5;  // 열 위치 판별

                array[row][col] = i;
            }

            PrintArray(array);
        }

        // 2차원 배열 출력 (오버로딩)
        private static void PrintArray(int[,] array)
        {
            // 행의 개수 반복 (2차원 배열의 Length는 전체 칸의 개수를 가져온다)
            for (int row = 0; row < array.GetLength(0); row++)
            {
                // 현재 행의 열 개수만큼 반복
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write($"{array[row, col]}");
                }

                Console.WriteLine();
            }
        }

        // 가변 배열 출력 (오버로딩)
        private static void PrintArray(int[][] array)
        {
            // 행의 개수 반복 (가변 배열은 배열 안에 배열이 들어있는 구조라 GetLength() 대신 Length를 사용)
            for (int row = 0; row < array.Length; row++)
            {
                // 현재 행의 열 개수만큼 반복
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write($"{array[row][col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
