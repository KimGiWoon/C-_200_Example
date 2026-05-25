using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 피라미드 메서드
namespace C__200_Example
{
    internal class Example_74
    {
        static void Main(string[] argd)
        {
            int floor;

            Console.WriteLine("피라미드를 그리겠습니다.");

            while (true)
            {
                Console.Write("그리고 싶은 피마미드의 층 수를 입력하세요 : ");
                
                if (int.TryParse(Console.ReadLine(), out floor))
                {
                    if (floor >= 3)
                    {
                        break;
                    }
                }

                Console.WriteLine("3이상의 숫자를 입력하세요");
            }

            DrawPyramid(floor);
        }

        // 피라미드 그리기 (짝수로 피라미드 그리기)
        private static void DrawPyramid(int floor)
        {
            Console.WriteLine($"{floor}층의 피라미드를 그리겠습니다.");

            // 피라미드의 층 수
            for (int i = 1; i <= floor; i++)
            {
                // 빈공간 생성
                for (int j = i; j < floor; j++)
                {
                    Console.Write(" ");
                }

                // 피라미드 생성
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
