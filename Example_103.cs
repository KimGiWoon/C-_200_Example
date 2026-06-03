using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// List<T> 컬렉션
namespace C__200_Example
{
    internal class Example_103
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Random random = new Random();
            int maxCount = 17;

            PrintList(intList);

            for (int i = 0; i < maxCount; i++)
            {
                intList.Add(random.Next(100));
            }

            PrintList(intList);
            Console.WriteLine("\nList의 데이터를 오름차순으로 정렬 합니다");
            intList.Sort();
            PrintList(intList);

            Console.WriteLine($"\n6번째의 {intList[5]}값을 삭제합니다");
            intList.RemoveAt(5);  // 5번째 값 삭제
            PrintList(intList);

            Console.WriteLine($"\n6번째에 255값을 추가합니다");
            intList.Insert(5, 255);   // 6번째 위치 100을 추가
            PrintList(intList);

            // 70의 숫자가 있으면 70삭제
            if (intList.Contains(70))
            {
                Console.WriteLine("\n70 숫자를 찾았고 삭제했습니다.");
                intList.Remove(70);

                PrintList(intList);
            }

            Console.WriteLine("\nintList의 데이터를 전부 삭제합니다.");
            intList.Clear();  // 리스트 값 전부 삭제
            PrintList(intList);
        }

        // 리스트 데이터 출력
        private static void PrintList(List<int> list)
        {
            Console.WriteLine("\nList<int>의 값을 출력합니다.");
            Console.WriteLine($"List<int>의 Count 값은 {list.Count}개 입니다.");
            Console.WriteLine($"List<int>의 Capacity 속성 값은 {list.Capacity} 입니다.");    // Capacity는 List<int>의 데이터 저장 공간이며 4 -> 8 -> 16 -> 32로 2배씩 증가\

            foreach(int i in list)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine();
        }
    }
}
