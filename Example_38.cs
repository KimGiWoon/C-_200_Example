using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // Nullable형
    internal class Example_38
    {
        static void Main(string[] args)
        {
            // null 값 할당 후 GetValueOrDefault로 값 가져오기
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());

            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }

            Console.WriteLine("Null");

            // Nullable int 변수 선언 및 null 초기화
            int? x = null;
            int j = x ?? 0;
            Console.WriteLine($"x = {x}, j = {j}");

            Console.WriteLine($"x >= 10 ? {x >= 10}");
            Console.WriteLine($"x < 10 ? {x < 10}");

            // 두 값을 비교해서 조건 확인
            if (Nullable.Compare<int>(i, j) < 0)
            {
                Console.WriteLine("i < j");
            }
            else if (Nullable.Compare<int>(i, j) > 0)
            {
                Console.WriteLine("i > j");
            }
            else
            {
                Console.WriteLine("i = j");
            }
        }
    }
}
