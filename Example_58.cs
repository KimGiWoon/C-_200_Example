using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 배열과 Array 클래스
    internal class Example_58
    {
        static void Main(string[] args)
        {
            int[] array = { 35, 10, 65, 20, 5 };
            int[] copyArray_1;
            int[] copyArray_2 = new int[7];
            int[] copyArray_3 = new int[7];

            PrintArray(array);
            
            // 배열 복사 1 (Clone)
            copyArray_1 = (int[])array.Clone();
            PrintArray(copyArray_1);

            // 배열 복사 2
            array.CopyTo(copyArray_2, 2);
            PrintArray(copyArray_2);

            // 배열 복사 3 (index 지정)
            Array.Copy(array, 1, copyArray_3, 1, 3);
            PrintArray(copyArray_3);

            // 오름차순으로 정렬
            Array.Sort(array);
            PrintArray(array);

            // 내림차순으로 정렬
            Array.Reverse(array);
            PrintArray(array);

            // 배열 초기화 1-1 (index 지정)
            Array.Clear(array, 2, 3);
            PrintArray(array);

            // 배열 초기화 1-2 (전체 삭제)
            Array.Clear(array);
            PrintArray(array);
        }

        // 배열 출력
        private static void PrintArray(int[] arr)
        {
            foreach(int value in arr)
            {
                Console.Write($"{value,5}");
            }

            Console.WriteLine();
        }
    }
}
