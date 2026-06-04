using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

// SortedList와 SortedList<TKey, TValue>
namespace C__200_Example
{
    enum Test
    {
        One = 1,
        Two,
        Three,
        Four
    }

    internal class Example_111
    {
        static void Main(String[] args)
        {
            // int 키와 string 값을 지정하는 SortedList 생성
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add((int)Test.Three, Test.Three.ToString());    // 3
            sortedList.Add((int)Test.Four, Test.One.ToString());   // 4
            sortedList.Add((int)Test.One, Test.One.ToString());    // 1
            sortedList.Add((int)Test.Two, Test.Two.ToString());    // 2

            // string 키와 int 값을 지정하는 SortedList2 생성
            SortedList<string, int> sortedList2 = new SortedList<string, int>();
            sortedList2.Add(Test.One.ToString(), (int)Test.One);
            sortedList2.Add(Test.Two.ToString(), (int)Test.Two);
            sortedList2.Add(Test.Three.ToString(), (int)Test.Three);
            sortedList2.Add(Test.Four.ToString(), (int)Test.Four);

            // SortedList 출력
            SortedListPrint(sortedList);

            // SortedList2 출력과 키와 값 찾기
            SortedList2FindKeyValue(sortedList2);

            // 키와 값이 있는지 확인
            KeyValueFine(sortedList2);

            // 요소 삭제 후 출력
            ElementRemove(sortedList2);
        }

        // 키와 값이 있는지 확인
        private static void KeyValueFine(SortedList<string, int> sortedList)
        {
            Console.WriteLine($"sortedList2에 One 키가 있나요? {sortedList.ContainsKey("One")}"); // One 키가 있는지 확인하여 bool 반환
            Console.WriteLine($"sortedList2에 Ten 키가 있나요? {sortedList.ContainsKey("Ten")}"); // Ten 키가 있는지 확인하여 bool 반환
            Console.WriteLine($"sortedList2에 2 값이 있나요? {sortedList.ContainsValue(2)}"); // 2 값이 있는지 확인하여 bool 반환
            Console.WriteLine($"sortedList2에 6 값이 있나요? {sortedList.ContainsValue(6)}"); // 6 값이 있는지 확인하여 bool 반환
        }

        // SortedList 출력
        private static void SortedListPrint(SortedList<int, string> sortedList)
        {
            Console.WriteLine("[sorrtedList]");

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"Key : {sortedList.Keys[i]}, Value : {sortedList.Values[i]}");
            }
            Console.WriteLine();

            foreach (var k in sortedList)
            {
                Console.WriteLine($"{k} ");
            }
            Console.WriteLine();
        }

        // SortedList2 출력과 키와 값 찾기
        private static void SortedList2FindKeyValue(SortedList<string, int> sortedList)
        {
            int value;

            Console.WriteLine("[sorrtedList2]");

            foreach (var k in sortedList)
            {
                Console.WriteLine($"{k.Key} : {k.Value}");
            }
            Console.WriteLine();

            // ten 키가 있으면 값을 value에 저장
            if (sortedList.TryGetValue("Ten", out value))
            {
                Console.WriteLine($"Key : Ten, Valye : {value}");
            }
            else
            {
                Console.WriteLine("Ten으로 저장된 키, 값이 없습니다.");
            }

            // One 키가 있으면 값을 value에 저장
            if (sortedList.TryGetValue("One", out value))
            {
                Console.WriteLine($"Key : One, Valye : {value}");
            }
            else
            {
                Console.WriteLine("Ten으로 저장된 키, 값이 없습니다.");
            }
        }

        // 요소 삭제 후 출력
        private static void ElementRemove(SortedList<string, int> sortedList)
        {
            Console.WriteLine("\nsortedList2의 One 키와 첫번째 요소를 삭제 합니다.");
            sortedList.Remove("One");   // 키 One 요소 삭제
            sortedList.RemoveAt(0); // 첫번째 요소 삭제

            Console.WriteLine("[sorrtedList2]");
            // sortedList의 키와 값 출력
            foreach (KeyValuePair<string, int> k in sortedList)
            {
                Console.WriteLine($"{k}");
            }

            Console.WriteLine();
        }
    }
}
