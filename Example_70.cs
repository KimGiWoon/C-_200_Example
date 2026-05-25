using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 세 개의 숫자 중 가장 큰 수를 찾는 정적 메서드
namespace C__200_Example
{
    internal class Example_70
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int count = 1;

            Console.WriteLine("세 개의 숫자 중 가장 큰 수를 찾겠습니다.");

            while(count <= 3)
            {
                Console.Write($"{count}번째 숫자를 입력해 주세요 : ");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    switch (count)
                    {
                        case 1:
                            a = value;
                            break;
                        case 2:
                            b = value;
                            break;
                        case 3:
                            c = value;
                            break;
                    }

                    count++;
                }
                else
                {
                    Console.WriteLine("숫자를 입력하세요");
                }
            }

            // 결과 출력
            Console.WriteLine($"입력한 세 개의 숫자 중 가장 큰 수는 {LargerNumber(a, LargerNumber(b, c))} 입니다.");
        }

        // 큰 수를 찾는 정적 메서드
        private static int LargerNumber(int a, int b)
        {
            int larger = a > b ? a : b;

            return larger;
        }
    }
}
