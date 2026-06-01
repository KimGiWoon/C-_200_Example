using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 재귀 이진탐색
namespace C__200_Example
{
    internal class Example_83
    {
        static void Main(string[] args)
        {
            int arrayMaxLen = 30;   // 배열 크기
            int key;    // 찾을 숫자

            Random random = new Random();
            int[] ranNumbers = new int[arrayMaxLen];

            for (int i = 0; i < ranNumbers.Length; i++)
            {
                ranNumbers[i] = random.Next(1000);  // 0부터 999까지 랜덤 정수 생성
            }

            PrintArray("정렬 전", ranNumbers);

            Array.Sort(ranNumbers); // 이진탐색은 배열 정렬 필요

            PrintArray("정렬 후", ranNumbers);

            // 찾을 숫자 입력
            key = InputValue();

            // 입력한 숫자가 배열에 있는지 찾기
            ArrayFindKey(key, ranNumbers);
        }

        // 입력한 숫자 찾기
        private static void ArrayFindKey(int key, int[] array)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;

            int index = RecBinarySearch(array, startIndex, endIndex, key);

            if (index == -1)
            {
                Console.WriteLine("찾는 값이 배열에 없습니다.");
            }
            else
            {
                Console.WriteLine($"찾는 {key}값은 배열의 {index}번 주소에 있습니다.");
            }
        }

        // 이진탐색
        private static int RecBinarySearch(int[] array, int low, int high, int key)
        {
            if (low <= high)
            {
                int middle = (low + high) / 2;

                // 찾는 값이 가운데 값과 같으면 해당 인덱스 반환
                if (key == array[middle])
                {
                    return middle;
                }
                else if (key > array[middle])   // 찾는 값이 가운데 값보다 크면 오른쪽 범위 탐색
                {
                    return RecBinarySearch(array, middle + 1, high, key);
                }
                else    // 찾는 값이 가운데 값보다 작으면 왼쪽 범위 탐색
                {
                    return RecBinarySearch(array, low, middle - 1, key);
                }
            }

            // 찾는 값이 없으면 -1 반환
            return -1;
        }

        // 숫자 입력
        private static int InputValue()
        {
            int value;

            Console.Write("숫자를 입력해 주세요 : ");

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 1)
            {
                Console.WriteLine("1이상의 숫자를 입력해주세요");
                Console.Write("숫자를 입력해 주세요 : ");
            }

            return value;
        }

        // 배열 출력
        private static void PrintArray(string str, int[] array)
        {
            Console.WriteLine(str);

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,5}{1}", array[i], i % 10 == 9 ? "\n" : "");
            }
        }
    }
}
