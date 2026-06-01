using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 반복문으로 2진, 8진, 16진수 출력
    internal class Example_44
    {
        private enum CHOICE
        {
            for문 = 1,
            while문           
        }
        static void Main(string[] args)
        {
            bool check;
            int value;
            CHOICE choice;

            while (true)
            {
                Console.Write("2진수 ,8진수, 16진수로 확인하고 싶은 숫자를 입력하세요 : ");
                check = int.TryParse(Console.ReadLine(), out value);

                if (check)
                {
                    break;
                }

                Console.WriteLine("다시 숫자를 입력해주세요.");
            }

            Console.Write("어떤 반복문으로 확인하시겠나요? 1.for문  2.while문 : ");
            choice = (CHOICE)int.Parse((Console.ReadLine()));

            switch (choice)
            {
                case CHOICE.for문:
                    ForBinaryNumber(value);
                    break;
                case CHOICE.while문:
                    WhileBinaryNumber(value);
                    break;
                default:
                    Console.WriteLine("선택에서 벗어났습니다. 처음부터 다시 실행해 주세요.");
                    break;
            }
        }

        // 2진, 8진, 16진 for문 사용 확인
        private static void ForBinaryNumber(int value)
        {
            Console.WriteLine($"\n{"10진수",6}{"2진수",8}{"8진수",8}{"16진수",6} (for문 사용)");

            // for문 사용
            for (int i = 1; i <= value; i++)
            {
                Console.WriteLine($"{i,7}{Convert.ToString(i, 2).PadLeft(8, '0'),12}{Convert.ToString(i, 8),8}{Convert.ToString(i, 16),8}");
            }
        }

        // 2진, 8진, 16진 while문 사용 확인
        private static void WhileBinaryNumber(int value)
        {
            int count = 1;

            Console.WriteLine($"\n{"10진수",6}{"2진수",8}{"8진수",8}{"16진수",6} (while문 사용)");

            // while문 사용
            while (count <= value)
            {
                Console.WriteLine($"{count,7}{Convert.ToString(count, 2).PadLeft(8, '0'),12}{Convert.ToString(count, 8),8}{Convert.ToString(count, 16),8}");

                count++;
            }
        }
    }
}
