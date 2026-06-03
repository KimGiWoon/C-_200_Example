using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열을 내림차순으로 정렬하는 방법
namespace C__200_Example
{
    class ReverseComparer : IComparer
    {
        // 두 수를 비교
        public int Compare(object? x, object? y)
        {
            string s1 = (string)x;
            string s2 = (string)y;

            // s2, s1를 비교해서 s2이 작으면 음수(앞으로 보냄), s2이 크면 양수(뒤로 보냄)
            return string.Compare(s2, s1);
        }
    }

    internal class Example_105
    {
        static void Main(string[] args)
        {
            string[] animalEnName = { "Dog", "Cow", "Rabbit", "Goat", "Sheep", "Mouse", "Horse", "Deer" };
            string[] animalKoName = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };

            // 영어 이름 배열 내림차순 정렬
            DescendingOrder_1(animalEnName);
            DescendingOrder_2(animalEnName);

            // 한글 이름 배열 내림차순 정렬
            DescendingOrder_1(animalKoName);
            DescendingOrder_2(animalKoName);


        }

        // 내림차순 정렬
        private static void DescendingOrder_1(string[] array)
        {
            Display("초기 배열(En)", array);
            Array.Sort(array);
            Array.Reverse(array);
            Display("Sort() 후 Reverse()", array);

            Console.WriteLine();
        }

        // 내림차순 정렬
        private static void DescendingOrder_2(string[] array)
        {
            Display("초기 배열(Ko)", array);

            IComparer reverseComparer = new ReverseComparer();

            Array.Sort(array, reverseComparer);
            Display("내림차순 정렬", array);

            Console.WriteLine();
        }

        // 출력
        private static void Display(string comment, string[] array)
        {
            Console.WriteLine(comment);

            // GetLowerBound : 배열의 시작 인덱스, GetUpperBound : 배열의 마지막 인덱스
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                Console.Write($" {array[i]}");
            }

            //// 같은 내용임
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($" {array[i]}");
            //}

            Console.WriteLine();
        }
    }
}
