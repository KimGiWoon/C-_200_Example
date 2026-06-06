using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// List<T>에서 Predicate<T> 델리게이트 사용
namespace C__200_Example
{
    internal class Example_119
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> { "mouse", "cow", "tiger", "rabbit", "dragon", "snake" };
            Action<string> print = s => Console.WriteLine(s);

            print("mouse, cow, tiger, rabbit, dragon, snake 6마리의 동물이 있습니다.");

            bool check = myList.Exists(s => s.Contains("x"));
            print($"이름에 'x'를 포함하는 동물이 있나요? {check}");

            string nameCheck = myList.Find(s => s.Length == 3);
            print($"이름이 3글자인 첫 번째 동물은? {nameCheck}");

            print("이름이 6글자 이상의 동물들은?");
            List<string> longName = myList.FindAll(s => s.Length >= 6);
            AllAnimalPrint(longName);

            print("모든 동물의 이름을 대문자로 변경합니다.");
            List<string> capList = myList.ConvertAll(s => s.ToUpper()); // ConvertAll()은 List의 모든 요소를 하나씩 변환해서 새로운 List로 반환하는 메서드
            AllAnimalPrint(capList);
        }

        // 모든 동물 출력
        private static void AllAnimalPrint(List<string> animals)
        {
            foreach (string animal in animals)
            {
                Console.Write(animal + ", ");
            }
            Console.WriteLine();
        }
    }
}
