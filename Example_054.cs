using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 이중 루프로 구구단 출력
    internal class Example_54
    {
        static void Main(string[] args)
        {
            int _number = 9;

            Console.WriteLine("                          구구단을 출력합니다.");
            Console.WriteLine("-----------------------------------------------------------------------");

            // 단수 제목 출력
            for (int x = 2; x <= _number; x++)
            {
                Console.Write($"[ {x}단  ] ");
            }

            Console.WriteLine();

            // 곱하는 수
            for (int i = 1; i <= _number; i++)
            {
                // 구구단의 단수
                for (int j = 2; j <= _number; j++)
                {
                    Console.Write($"[{j}X{i}={j * i,2}] ");
                }

                Console.WriteLine();
            }
        }
    }
}
