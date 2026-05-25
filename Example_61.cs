using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // Random 클래스
    internal class Example_61
    {
        static void Main(string[] args)
        {
            // 랜덤 객체 생성
            Random randomValue = new Random();

            RandomByte(randomValue);
            RandomDouble(randomValue);
            RandomInt(randomValue);
            RandomOneToHundred(randomValue);
        }

        // 바이트 숫자 랜덤값
        private static void RandomByte(Random random)
        {
            byte[] bytes = new byte[5];
            int index = 0;

            Console.WriteLine($"Random 클래스의 Next() 메서드를 사용해서 랜덤 숫자를 채웁니다.");
            Console.WriteLine();
            Console.Write($"Byte 5번 랜덤값 : ");

            // 배열을 랜덤값으로 채움
            random.NextBytes(bytes);

            // 바이트 숫자 랜덤값 확인
            foreach(byte b in bytes)
            {
                if (index == bytes.Length - 1)
                {
                    Console.Write($"{b}");

                    continue;
                }

                Console.Write($"{b}, ");
                index++;
            }

            Console.WriteLine();
        }

        // 더블 숫자 랜덤값
        private static void RandomDouble(Random random)
        {
            double[] doubles = new double[5];
            int index = 0;

            Console.Write($"Double 5번 랜덤값 : ");

            // 랜덤값으로 채움
            for(int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = random.NextDouble();
            }

            // 더블 숫자 랜덤값 확인
            foreach (double d in doubles)
            {
                if (index == doubles.Length - 1)
                {
                    Console.Write($"{d,12:F8}");

                    continue;
                }

                Console.Write($"{d,12:F8}, ");
                index++;
            }

            Console.WriteLine();
        }

        // 정수 숫자 랜덤값
        private static void RandomInt(Random random)
        {
            int[] ints = new int[5];
            int index = 0;

            Console.Write("Int 5번 랜덤값 : ");

            // 랜덤값으로 채움
            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next();
            }

            // 정수 숫자 랜덤값 확인
            foreach (int i in ints)
            {
                if (index == ints.Length - 1)
                {
                    Console.Write($"{i,12}");

                    continue;
                }

                Console.Write($"{i,12}, ");
                index++;
            }

            Console.WriteLine();
        }

        // 1부터 100까지의 랜덤값
        private static void RandomOneToHundred(Random random)
        {
            int[] rand = new int[5];
            int index = 0;

            Console.Write("1부터 100까지 5번 랜덤값 : ");

            // 랜덤값으로 채움
            for (int i = 0; i < rand.Length; i++)
            {
                rand[i] = random.Next(1, 101);  // 1이상 101미만 숫자 (1 ~ 100)

                //rand[i] = random.Next(100); // 0부터 100미만 숫자 (0 ~ 99)

                //rand[i] = random.Next();    // 0부터 Int.MaxValue 미만 숫자 (0 ~ 2,147,483,646)
            }

            // 정수 숫자 랜덤값 확인
            foreach (int r in rand)
            {
                if (index == rand.Length - 1)
                {
                    Console.Write($"{r}");

                    continue;
                }

                Console.Write($"{r}, ");
                index++;
            }

            Console.WriteLine();
        }
    }
}
