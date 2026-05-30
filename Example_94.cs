using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일반화 클래스 (제네릭 클래스)
namespace C__200_Example
{
    class Example_94<T>
    {
        private T[] arr;
        private int count = 0;

        // 생성자
        public Example_94(int length)
        {
            arr = new T[length];
            count = length;
        }

        public void Insert(params T[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                arr[i] = args[i];
            }
        }

        public void Print()
        {
            foreach(T i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        public T AddAll()
        {
            // T 타입의 기본값 초기화
            T sum = default(T);

            foreach(T item in arr)
            {
                // 연산이 가능한지 모르지 dynamic으로 변환
                sum += (dynamic)item;
            }

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example_94<int> a = new Example_94<int>(10);
            Example_94<string> s = new Example_94<string>(5);

            a.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            s.Insert("Tiger", "Lion", "Zebra", "Monkey", "Cow");

            a.Print();
            s.Print();

            Console.WriteLine($"a.AddAll() : {a.AddAll()}");
            Console.WriteLine($"s.AddAll() : {s.AddAll()}");
        }
    }
}
