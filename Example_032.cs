using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 열거형 enum
    internal class Example_32
    {
        // 사이즈 enum
        enum SIZE
        {
            Short,
            Tall,
            Grande,
            Venti
        }

        // 컬러 enum
        enum COLOR
        {
            Red = 1,
            Green,
            Blue = 4,
            Yellow = 8
        }

        // 커피 enum
        enum COFFEE
        {
            Short = 3300,
            Tall = 3800,
            Grande = 4300,
            Venti = 4800
        }

        // 가격 정수 배열
        static int[] price = { 3300, 3800, 4300, 4800 };

        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표");

            for (int i = 0; i < 4; i++) // for문으로 가격표 만들기
            {
                if (i == (int)SIZE.Short)
                {
                    Console.WriteLine($"{SIZE.Short,10} : {price[i]:C}");
                }
                else if (i == (int)SIZE.Tall)
                {
                    Console.WriteLine($"{SIZE.Tall,10} : {price[i]:C}");
                }
                else if (i == (int)SIZE.Grande)
                {
                    Console.WriteLine($"{SIZE.Grande,10} : {price[i]:C}");
                }
                else if (i == (int)SIZE.Venti)
                {
                    Console.WriteLine($"{SIZE.Venti,10} : {price[i]:C}");
                }
            }

            Console.WriteLine("\n커피 가격표(Enum iteration)");  // enum값을 가져와 반복하여 가격표 만들기

            foreach(var size in Enum.GetValues(typeof(SIZE)))
            {
                Console.WriteLine($"{size,10} : {price[(int)size]:C}");
            }

            Console.WriteLine("\nColors Enum iteration");   // Color enum의 값을 가져오고 정수값 표현

            foreach(var color in Enum.GetValues(typeof(COLOR)))
            {
                Console.WriteLine($"{color,10} : {Convert.ToInt32(color)}");
            }

            Console.WriteLine("\n커피 가격표(Enum iteration with value)");   // Coffee Enum의 이름과 가격으로 가격표 만들기

            foreach(var coffee in Enum.GetValues(typeof(COFFEE)))
            {
                Console.WriteLine($"{coffee,10} : {Convert.ToInt32(coffee):C}");
            }
        }
    }
}
