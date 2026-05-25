using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 이중 루프와 피라미드 출력
    internal class Example_56
    {
        static void Main(string[] args)
        {
            // 1번 피라미드
            Pyramid_1();
            // 2번 피라미드
            Pyramid_2();
            // 3번 피라미드
            Pyramid_3();
            // 4번 피라미드
            Pyramid_4();
            // 5번 피라미드
            Pyramid_5();
            // 6번 피라미드
            Pyramid_6();
        }

        // 1번 피라미드
        private static void Pyramid_1()
        {
            int maxNum = 5;

            Console.WriteLine("\n1번 피라미드 입니다.");
            Console.WriteLine();

            for (int i = 1; i <= maxNum; i++)
            {
                // 순차 증가 (왼쪽 정렬)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // 2번 피라미드
        private static void Pyramid_2()
        {
            int maxNum = 5;

            Console.WriteLine("\n2번 피라미드 입니다.");
            Console.WriteLine();

            for (int i = 1; i <= maxNum; i++)
            {
                // 홀수의 개수로 별 증가
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // 3번 피라미드
        private static void Pyramid_3()
        {
            int maxNum = 5;

            Console.WriteLine("\n3번 피라미드 입니다.");
            Console.WriteLine();

            for (int i = maxNum; i > 0; i--)
            {
                // 역순 (왼쪽 정렬)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // 4번 피라미드
        private static void Pyramid_4()
        {
            int maxNum = 5;

            Console.WriteLine("\n4번 피라미드 입니다.");
            Console.WriteLine();

            for (int i = 1; i <= maxNum; i++)
            {
                // 순차 증가 (오른쪽 정렬)
                for (int j = 1; j <= maxNum - i; j++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= i; x++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        // 5번 피라미드
        private static void Pyramid_5()
        {
            int maxNum = 5;

            Console.WriteLine("\n5번 피라미드 입니다.");
            Console.WriteLine();

            for (int i = 1; i <= maxNum; i++)
            {
                // 홀수의 개수 증가 (가운데 정렬)
                for (int j = 1; j <= maxNum - i; j++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= i * 2 - 1; x++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        // 6번 피라미드
        private static void Pyramid_6()
        {
            int maxNum = 5;

            Console.WriteLine("\n6번 피라미드 입니다.");
            Console.WriteLine();

            for (int i = maxNum; i > 0; i--)
            {
                // 홀수의 대수 증가 역순 (가운데 정렬)
                for (int j = 1; j <= maxNum - i; j++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= i * 2 - 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
