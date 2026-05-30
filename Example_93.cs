using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일반화 메서드 (제네릭 메서드)
namespace C__200_Example
{
    internal class Example_93
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            double[] b = { 0.1, 0.2, 0.3, 0.4 };
            string[] c = { "Apple", "Banana", "Camel", "Danger" };
            object[] d = { 1, 1, 5, 'A', "haha" };

            // 형식 매개변수 전달 및 출력
            PrintArray<int>(a);
            PrintArray<double>(b);
            PrintArray<string>(c);
            PrintArray<object>(d);

            Console.WriteLine();

            // 형식 매개변수 생략 가능
            PrintArray(a);
            PrintArray(b);
            PrintArray(c);
            PrintArray(d);
        }

        // 배열 출력 일반화 메서드
        private static void PrintArray<T>(T[] a)
        {
            foreach(var item in a)
            {
                Console.Write($"{item,8}");
            }

            Console.WriteLine();
        }
    }
}
