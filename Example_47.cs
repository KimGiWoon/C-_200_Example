using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{   
    // X의 N승 구하기
    internal class Example_47
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = 0;

            Console.WriteLine("x의 n승을 계산합니다.");
            InPut(out x, out n);

            Console.WriteLine($"\n{x}의 {n}승을 계산하겠습니다.");
            PowerCal(x, n);
        }

        // 값 입력
        private static void InPut(out int x, out int n)
        {
            while (true)
            {
                Console.Write("X의 값을 입력하세요 : ");

                if (int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write($"\n입력된 x의 값은 : {x} 입니다.");
                    break;
                }

                Console.WriteLine("값을 숫자로 다시 입력해 주세요.");
            }

            while (true)
            {
                Console.Write("\nN의 값을 입력하세요 : ");

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write($"\n입력된 n의 값은 : {n} 입니다.");
                    break;
                }

                Console.WriteLine("값을 숫자로 다시 입력해 주세요.");
            }
        }

        // n승 계산
        private static void PowerCal(int x, int n)
        {
            int power = 1;

            for (int i = 0; i < n; i++)
            {
                power *= x;
            }

            Console.WriteLine($"\n{x}의 {n}승은 {power}입니다.");
        }
    }
}
