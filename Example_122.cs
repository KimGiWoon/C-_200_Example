using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ의 결과를 리스트나 배열로 반환
namespace C__200_Example
{
    internal class Example_122
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 67, 878, 321, 344, 43, 2, 1 };
            List<int> oddList = new List<int>();
            int[] evenArray = new int[data.Count];

            Print("Data : ", data);

            oddList = SelectOddAndSort(data);
            Print("홀수 : ", oddList);

            evenArray = SelectEvenAndSort(data);
            Print("짝수 : ", evenArray);
        }

        // 값 출력
        private static void Print(string ex, IEnumerable<int> data)
        {
            Console.Write(ex);

            foreach (int value in data)
            {
                Console.Write(value + ", ");
            }

            Console.WriteLine();
        }

        // 홀수 판별 후 오름차순 정렬 (리스트)
        private static List<int> SelectOddAndSort(List<int> list)
        {
            var odd = from value in list
                      where value % 2 != 0
                      orderby value
                      select value;

            return odd.ToList<int>();   // 리스트로 변환 (odd의 타입이 List<int>가 아니라 IEnumerable<int>라서 리스트 변환 필요)
        }

        // 짝수 판별 후 오름차순 정렬 (배열)
        private static int[] SelectEvenAndSort(List<int> list)
        {
            var even = from value in list
                       where value % 2 == 0
                       orderby value
                       select value;

            return even.ToArray<int>(); // 배열로 변환 (even의 배열 타입 변환)
        }
    }
}
