using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ를 이용한 조건 검색과 정렬
namespace C__200_Example
{
    internal class Example_121
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 67, 878, 321, 344, 43, 2, 1 };

            Print("data : ", data);

            // 100보다 큰 홀수 판별 및 오름차순 정렬 LINQ
            var oddValue = from value in data
                            where value % 2 != 0 && value > 100
                            orderby value
                            select value;
            // 100보다 큰 짝수 판별 및 오름차순 정렬 LINQ
            var evenValue = from value in data
                           where value % 2 == 0 && value > 100
                           orderby value
                           select value;

            Print("100보다 큰 홀수 : ", oddValue);
            Print("100보다 큰 짝수 : ", evenValue);

            // 리스트의 값에 2를 곱하여 오름차순 정렬 LINQ (조건이 필요없어 where 생략 가능)
            var sortedValue = from value in data
                              orderby value
                              select value * 2;

            Print("2를 곱해서 오름차순 정렬 : ", sortedValue);
        }

        // 값 출력
        private static void Print(string ex, IEnumerable<int> data)
        {
            Console.Write(ex);

            foreach(int value in data)
            {
                Console.Write(value + ", ");
            }

            Console.WriteLine();
        }
    }
}
