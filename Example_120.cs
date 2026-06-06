using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ의 기초 (C#에 통합된 데이터 질의 기능)
namespace C__200_Example
{
    internal class Example_120
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 67, 878, 321, 344, 43, 2, 1 };
            List<int> firstSortedEven = new List<int>();    // 짝수 리스트

            Console.Write("정수 리스트 : ");
            // 짝수를 리스트에 넣기
            foreach (int value in data)
            {
                Console.Write(value + ", ");
                if (value % 2 == 0)
                {
                    firstSortedEven.Add(value);
                }
            }
            Console.WriteLine();

            // 오름차순 정렬
            firstSortedEven.Sort();

            Print("\n<짝수를 판별하고 Sort()로 정렬 후 출력>", firstSortedEven);

            // LINQ로 data에서 짝수를 찾아 오름차순으로 정렬하고 sortedEven에 추가 (from, where, orderby, select)
            var sortedEven = from value in data
                             where value % 2 == 0
                             orderby value
                             select value;

            Print("\n<LINQ로 짝수 판별과 정렬 후 출력>", sortedEven);
        }

        // 리스트 값 출력
        private static void Print(string ex, IEnumerable<int> list)
        {
            Console.WriteLine(ex);

            foreach (var value in list)
            {
                Console.Write(value + ", ");
            }

            Console.WriteLine();
        }
    }
}
