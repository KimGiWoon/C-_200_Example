using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

// List<T>와 배열의 정렬
namespace C__200_Example
{
    enum AnimalName
    {
        Sheep,
        Dog,
        Goat,
        Cat,
        Rabbit,
    }

    internal class Example_104
    {
        static void Main(string[] args)
        {
            // 리스트와 배열 객체 생성
            List<string> nameList = new List<string>();
            string[] nameArray = new string[5];

            Console.WriteLine("배열과 리스트에 정해진 동물을 넣고 정렬을 합니다.");
            Console.WriteLine("넣을 이름 : Sheep, Dog, Goat, Cat, Rabbit");

            GetValueList(nameList);
            GetValueArray(nameArray);
            Console.WriteLine();

            // 리스트와 배열에 넣은 데이터 출력
            PrintValue(nameList, nameArray);

            // 정렬
            nameList.Sort();
            Array.Sort(nameArray);

            Console.WriteLine("\n<오름차순 정렬 후>\n");
            PrintValue(nameList, nameArray);
        }

        // 리스트에 값 넣기
        private static void GetValueList(List<string> list)
        {
            foreach (AnimalName name in Enum.GetValues(typeof(AnimalName)))
            {
                list.Add(name.ToString());
            }
        }

        // 배열에 값 넣기
        private static void GetValueArray(string[] array)
        {
            int index = 0;

            foreach (AnimalName name in Enum.GetValues(typeof(AnimalName)))
            {
                array[index] = name.ToString();
                index++;
            }
        }

        // 리스트와 배열에 넣은 데이터 출력
        private static void PrintValue(List<string> list, string[] array)
        {
            Console.Write("List에 넣은 이름 데이터 : ");
            foreach (string name in list)
            {
                Console.Write($"{name}, ");
            }

            Console.WriteLine();

            Console.Write("Array에 넣은 이름 데이터 : ");
            foreach (string name in array)
            {
                Console.Write($"{name}, ");
            }

            Console.WriteLine();
        }
    }
}
