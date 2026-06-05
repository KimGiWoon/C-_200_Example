using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이름 없는 델리케이트
namespace C__200_Example
{
    internal class Example_114
    {
        // bool값을 리턴하는 델리게이드 선언
        delegate bool MemberTest(int a);

        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 4, 2, 6, 4, 6, 8, 28, 59, 46, 9, 10 };

            Console.Write($"배열의 값 : ");

            foreach (int n in arr)
            {
                Console.Write($"{n}, ");
            }

            int count = Count(arr, delegate (int a) { return a % 2 != 0; });    // 무명 델리케이트에 홀수 조건 전달
            Console.WriteLine($"홀수의 개수 : {count}개");

            count = Count(arr, delegate (int a) { return a % 2 == 0; });    // 무명 델리게이트에 짝수 조건 전달
            Console.WriteLine($"짝수의 개수 : {count}개");
        }

        // 개수 확인 (델리케이트 사용)
        private static int Count(int[] arr, MemberTest memberTest)
        {
            int count = 0;

            foreach(int value in arr)
            {
                if (memberTest(value))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
