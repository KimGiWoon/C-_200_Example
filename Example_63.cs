using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 선형탐색과 이진탐색
    internal class Example_63
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomArray = new int[30]; // 배열 생성
            int findValue = 0;

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 1000); // 1~999 숫자 저장
            }

            Console.WriteLine("30개의 랜덤값에서 특정 수를 선형탐색, 이진탐색으로 찾아보기");
            Console.WriteLine();

            PrintArray("<정렬 전>", randomArray);  // 정렬전 배열 출력

            Array.Sort(randomArray); // 배열 정렬
            Console.WriteLine();

            PrintArray("<정렬 후>", randomArray);  // 정렬후 배열 출력 (이진탐색은 정렬을 해야 효율 및 사용가능)

            // 찾을 수 입력
            findValue = FindValue(randomArray);

            // 선형탐색
            LinearSearch(randomArray, findValue);

            // 이진탐색
            BinarySearch(randomArray, findValue);
        }

        // 찾을 수 입력
        private static int FindValue(int[] randomValue)
        {
            int value = 0;

            while(true)
            {
                Console.Write("\n찾을 숫자를 입력하세요 : ");

                if (int.TryParse(Console.ReadLine(), out value))
                {
                    // 배열에 없는 숫자는 입력하지 못하도록 확인 (Contains()는 선형 탐색)
                    if (!randomValue.Contains(value))
                    {
                        Console.WriteLine("주어진 수 이외의 수는 입력할 수 없습니다.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("숫자만 입력해 주세요.");
                }
            }

            return value;
        }

        // 선형탐색
        private static void LinearSearch(int[] randomArray, int findValue)
        {
            int searchCount = 1;

            // 순차적으로 탐색
            for (int i = 0; i < randomArray.Length; i++)
            {
                searchCount++;

                // 찾으려는 값을 찾으면
                if (randomArray[i] == findValue)
                {
                    Console.WriteLine($"선형탐색에서 {findValue}를 찾기 위해 {searchCount}번 비교를 했습니다.");
                    break;
                }
            }
        }

        // 이진탐색
        private static void BinarySearch(int[] randomArray, int findValue)
        {
            int searchCount = 1;
            int leftIndex = 0;
            int rightIndex = randomArray.Length - 1;

            while (leftIndex <= rightIndex)
            {
                searchCount++;

                // 중간 값 설정
                int middleIndex = (leftIndex + rightIndex) / 2;

                // 중간 값이 찾으려는 값이면
                if (randomArray[middleIndex] == findValue)
                {
                    Console.WriteLine($"이진탐색에서 {findValue}를 찾기 위해 {searchCount}번 비교를 했습니다.");
                    break;
                }
                else if (randomArray[middleIndex] < findValue)  // 찾으려는 값이 중간 값보다 크면
                {
                    leftIndex = middleIndex + 1;
                }
                else    // 찾으려는 값이 중간 값보다 작으면
                {
                    rightIndex = middleIndex - 1;
                }
            }
        }

        // 배열 출력
        private static void PrintArray(string str, int[] values)
        {
            int nextLine = 10;
            int count = 0;

            Console.WriteLine(str);

            foreach(int value in values)
            {
                Console.Write("[{0,3}]{1}", value, count % nextLine == 9 ? "\n" : " ");  // 10개 마다 줄 바꿈

                count++;
            }
        }
    }
}
