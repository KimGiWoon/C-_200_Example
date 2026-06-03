using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 컬렉션, ArrayList의 사용
namespace C__200_Example
{
    internal class Example_102
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            int maxCount = 10;

            PrintValue(arrayList); // 값을 넣기 전 출력

            for (int i = 0; i < maxCount; i++)
            {
                arrayList.Add(random.Next(100));    // 0 ~ 99의 랜덤 값을 ArrayList에 저장
            }

            PrintValue(arrayList); // 값을 넣은 후 출력
            arrayList.Sort();   // 정렬
            PrintValue(arrayList);  // 정렬 후 출력

            Console.WriteLine($"\n4번째의 {arrayList[3]}값을 삭제합니다");
            arrayList.RemoveAt(3);  // 4번째 값 삭제
            PrintValue(arrayList);

            Console.WriteLine($"\n4번째에 100값을 추가합니다");
            arrayList.Insert(3, 100);   // 4번째 위치 100을 추가
            PrintValue(arrayList);

            // 55의 숫자가 있으면 55삭제
            if (arrayList.Contains(55))
            {
                Console.WriteLine("\n55 숫자를 찾았고 삭제했습니다.");
                arrayList.Remove(55);

                PrintValue(arrayList);
            }

            Console.WriteLine("\nArrayList의 데이터를 전부 삭제합니다.");
            arrayList.Clear();  // 리스트 값 전부 삭제
            PrintValue(arrayList);
        }

        // ArrayList 데이터 출력
        private static void PrintValue(ArrayList arr)
        {
            Console.WriteLine("\nArrayList의 값을 출력합니다.");
            Console.WriteLine($"ArrayList의 Count 값은 {arr.Count}개 입니다.");
            Console.WriteLine($"ArrayList의 Capacity 속성 값은 {arr.Capacity} 입니다.");    // Capacity는 Arraylist의 데이터 저장 공간이며 4 -> 8 -> 16 -> 32로 2배씩 증가

            foreach(var i in arr)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine();
        }
    }
}
