using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dynamic형을 사용하는 일반화 프로그램
namespace C__200_Example
{
    internal class Example_95
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 45, 32, 47, 85, 46, 93, 47, 50, 71 };
            double[] b = { 0.1, 5.3, 6.7, 8.5, 4.9, 6.1 };
            float[] c = { 1.3f, 5.3f, 7.8f, 6.1f, 3.4f, 8.8f };
            decimal[] d = { 123, 789, 456, 234, 989, 100 };
            string[] e = { "aaa", "bbb", "ccc", "ddd", "eee" };

            // 정수형 배열
            PrintArray<int>("a[] : ", a);
            CalcArray<int>(a);

            // 더블형 배열
            PrintArray<double>("b[] : ", b);
            CalcArray<double>(b);

            // 플로트형 배열
            PrintArray<float>("c[] : ", c);
            CalcArray<float>(c);

            // 데시몰형 배열
            PrintArray<decimal>("d[] : ", d);
            CalcArray<decimal>(d);

            //// 문자열 배열
            //PrintArrayTest<string>("e[] : ", e);  // 문자열은 비교를 할 수 없어 비교를 할 수 없다는 에러 발생함, dynamic형으로 선언하여 컴파일시 에러 없어 실행이 가능하고 런타임중 에러 발생
            //CalcArrayTest<string>(e);

        }

        // 구조체 형식만 받을 수 있는 일반화 배열 계산 메서드
        private static void CalcArray<T> (T[] a) where T : struct
        {
            T sum = default(T); // 초기화를 하지 않으면 기본값 초기화
            T average = default(T);
            T Max = default(T);

            foreach(dynamic item in a)
            {
                if (Max < item)
                {
                    Max = item;
                }

                sum += item;
            }

            average = (dynamic)sum / a.Length;

            Console.WriteLine($"sum = {sum}, Average = {average}, max = {Max}");
        }

        // 구조체 형식만 받을 수 있는 일반화 배열 출력 메서드
        private static void PrintArray<T>(string s, T[] arr) where T : struct
        {
            Console.Write(s);

            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
        }



        // 구조체 형식만 받을 수 있는 일반화 배열 계산 메서드 (Test)
        private static void CalcArrayTest<T>(T[] a) where T : class
        {
            T sum = default(T); // 초기화를 하지 않으면 기본값 초기화
            T average = default(T);
            T Max = default(T);

            foreach (dynamic item in a)
            {
                if (Max < item)
                {
                    Max = item;
                }

                sum += item;
            }

            average = (dynamic)sum / a.Length;

            Console.WriteLine($"sum = {sum}, Average = {average}, max = {Max}");
        }

        // 구조체 형식만 받을 수 있는 일반화 배열 출력 메서드 (Test)
        private static void PrintArrayTest<T>(string s, T[] arr) where T : class
        {
            Console.Write(s);

            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
        }
    }
}
