using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 구구단 출력
    internal class Example_45
    {
        private enum STRINGCHECK
        {
            일 = 1,
            이,
            삼,
            사,
            오,
            육,
            칠,
            팔,
            구
        }
        static void Main(string[] args)
        {
            int value = 0;
            bool reStart = false;

            Console.Write("구구단을 출력할 단수를 입력하세요 : ");
            string result = Console.ReadLine().Replace("단", "");

            foreach (STRINGCHECK a in Enum.GetValues(typeof(STRINGCHECK)))
            {
                // 입력 문자 확인
                if (result == a.ToString())
                {
                    value = (int)a;

                    MultiplicationTable(value);
                    break;
                }

                // 입력 숫자 확인
                if(int.TryParse(result, out int number) && number == (int)a)
                {
                    number = (int)a;

                    MultiplicationTable(number);
                    break;
                }

                reStart = true;
            }

            if (reStart)
            {
                Console.WriteLine("9단 이상을 입력하여 구구단의 범위에 벗어났습니다. 다시 실행해 주세요");
            }
        }

        // 구구단 계산
        private static void MultiplicationTable(int result)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{result} X {i} = {result * i}");
            }
        }
    }
}
