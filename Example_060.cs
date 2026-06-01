using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 이름을 배열에 저장하고 알파벳 순으로 정렬
    internal class Example_60
    {
        static void Main(string[] args)
        {
            // A ~ G 알파벳으로 시작하는 동물 이름 배열
            string[] animalNames = { "Dog", "Fox", "Bear", "Cat", "Elephant", "Giraffe", "Aligator" };

            Console.WriteLine("Dog, Fox, Bear, Cat, Elephant, Giraffe, Aligator 동물의 이름을 알파벳 순서로 정렬을 합니다.");
            Console.WriteLine();

            // 오름차순 정렬
            ArraySort(animalNames);

            Console.WriteLine();

            // 배열 순서 뒤집기
            ArrayReverse(animalNames);
        }

        // 배열 오름차순 정렬
        private static void ArraySort(string[] array)
        {
            int index = 0;

            Console.Write("오름차순 정렬(Sort) : ");

            // Array 클래스의 Sort메서드로 오름차순 정렬
            Array.Sort(array);

            foreach(string animal in array)
            {
                // 배열의 마지막이면 콤마 쓰지 않음
                if (index == array.Length - 1)
                {
                    Console.Write($"{animal}");
                }
                else
                {
                    Console.Write($"{animal}, ");
                }

                index++;
            }

            Console.WriteLine();
        }

        // 배열 요소 뒤집기
        private static void ArrayReverse(string[] array)
        {
            int index = 0;

            Console.Write("순서 뒤집기 (Reverse) : ");

            // Array 클래스의 Reverse메서드로 요소 뒤집기
            Array.Reverse(array);

            foreach (string animal in array)
            {
                // 배열의 마지막이면 콤마 쓰지 않음
                if (index == array.Length - 1)
                {
                    Console.Write($"{animal}");
                }
                else
                {
                    Console.Write($"{animal}, ");
                }

                index++;
            }

            Console.WriteLine();
        }
    }
}
