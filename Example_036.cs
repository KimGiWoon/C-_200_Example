using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // Null 조건 연산자
    internal class Example_36
    {
        static void Main(string[] args)
        {
            // null 초기화
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");

            do
            {
                LongNameAnimal(animal);
                Console.Write("동물 이름 : ");
            } while ((animal = Console.ReadLine()) != "");

        }

        private static void LongNameAnimal(string animal)
        {
            // Null 조건 연산자로 Null이면 실행하지 않고 null 반환
            if (animal?.Length >= 4)
            {
                Console.WriteLine($"animal : {animal.Length}");
            }
        }
    }
}
