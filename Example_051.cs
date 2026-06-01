using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 무한루프와 Break문
    internal class Example_51
    {
        static void Main(string[] args)
        {
            bool infinity = false;

            while(true)
            {
                Console.Write("무한루프를 보시겠습니까? Y / N : ");

                if (char.TryParse(Console.ReadLine(), out char choice))
                {
                    if (choice == 'Y' || choice == 'y')
                    {
                        infinity = true;
                        break;
                    }

                    if (choice == 'N' || choice == 'n')
                    {
                        Console.WriteLine("10회만 반복하겠습니다.");
                        infinity = false;
                        break;
                    }
                }

                Console.WriteLine("Y 와 N 중에 선택해주세요");
            }

            if (infinity)
            {
                InfinityIteration();
            }
            else
            {
                NotInfinityIteration();
            }
        }

        // 무한 반복
        private static void InfinityIteration()
        {
            long sum = 0;
            long days = 1;
            long money = 1000;

            while (true)
            {
                try
                {
                    checked
                    {
                        sum += money;

                        Console.WriteLine($"{days,3}일차 : {money,15:C} , 다음 더하는 값: {sum,15:C}");

                        days++;
                        money *= 2;
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"{days,3}일차: 값을 초과했습니다. 프로그램을 종료하세요.{e.Message}");
                    days++;
                }
            }
        }

        // 무한이 아닌 반복
        private static void NotInfinityIteration()
        {
            int count = 10;
            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)
            {
                sum += money;
                Console.WriteLine($"{days,3}일차 : {money,15:C} , 다음 더하는 값: {sum,15:C}");

                if(days == count)
                {
                    break;
                }

                days++;
                money *= 2;
            }
        }
    }
}
