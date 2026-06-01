using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 윤년인지 알아내는 정적 메서드
namespace C__200_Example
{
    internal class Example_72
    {
        static void Main(string[] args)
        {
            int startYear = 0;
            int endYear = 0;
            bool isInput = false;
            

            Console.WriteLine("윤년을 찾는 예제입니다.");

            while (true)
            {
                if (isInput == true)
                {
                    Console.Write("끝 년 수를 입력하세요 : ");

                    if (int.TryParse(Console.ReadLine(), out endYear) && endYear > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0이상의 숫자를 입력하세요");
                    }
                }
                else
                {
                    Console.Write("시작 년 수를 입력하세요 : ");

                    if (int.TryParse(Console.ReadLine(), out startYear) && startYear > 0)
                    {
                        isInput = true;
                    }
                    else
                    {
                        Console.WriteLine("0이상의 숫자를 입력하세요");
                    }
                }
            }

            // 윤년 찾기
            LeapYear(startYear, endYear);
        }

        // 윤년 찾기 메서드
        private static void LeapYear(int startYear, int endYear)
        {
            int count = 0;

            Console.Write("윤년은 : ");

            for (int i = startYear; i <= endYear; i++)
            {
                // Year가 4로 나누어지고 100으로 나누어지지 않거나 400으로 나누어지면 윤년
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }

            Console.WriteLine($"\n{count}개의 윤년이 있습니다.");
        }
    }
}
