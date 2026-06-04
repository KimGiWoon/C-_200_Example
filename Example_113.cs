using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Delegate의 기본 배열에서 홀수와 짝수 찾기
namespace C__200_Example
{
    internal class Example_113
    {
        // bool값을 리턴하는 델리케이드 선언
        delegate bool MemberTest(int a);
        //delegate bool MemberTest(double a); // 같은 이름의 델리게이트는 매개변수가 달라도 중복 선언 불가

        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 4, 2, 6, 4, 6, 8, 28, 59, 46, 9, 10 };

            // 홀수와 짝수 개수 출력
            Console.WriteLine($"홀수의 개수 : {Count(arr, IsOdd)}개");
            Console.WriteLine($"짝수의 개수 : {Count(arr, IsEven)}개");
            //Console.WriteLine($"짝수의 개수 : {Count(arr, IsOdd2)}개");
        }

        // 개수 확인 (델리케이트 사용)
        private static int Count(int[] arr, MemberTest memberTest)
        {
            int count = 0;

            foreach(int value in arr)
            {
                if (memberTest(value) == true)
                {
                    count++;
                }
            }

            return count;
        }

        // 홀수 확인
        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        // 짝수 확인
        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        // MemberTest 델리게이트는 bool을 반환하므로 int를 반환하는 메서드는 연결할 수 없음 (반환형이 다른 메서드 연결 확인용)
        //private static int IsOdd2(int value)
        //{
        //    int confirm;

        //    if (value % 2 != 0)
        //    {
        //        confirm = 1;
        //    }
        //    else
        //    {
        //        confirm = -1;
        //    }

        //    return confirm;
        //}
    }
}
