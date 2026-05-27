using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 하노이의 탑과 메르센 수

// 하노이의 탑은 한 기둥에 꽃힌 원판들을 다른 기둥으로 옮겨서 다시 쌓는 것 (2가지의 조건이 있음)
// 1 - 한번에 하나의 원판만 옮길 수 있음
// 2 - 큰 원판이 작은 원판 위에 있어서는 안됨
namespace C__200_Example
{
    internal class Example_82
    {
        static void Main(string[] args)
        {
            // 1~50까지 매르센 수 계산
            Console.WriteLine("1부터 50까지 메르센 수를 계산합니다.");

            for (int i = 1; i <= 50; i++)
            {
                double merValue = MersenneCal(i);
                Console.WriteLine($"메르센 수 {i} = {merValue:N0} = {merValue / 3600 / 24:N1}일 = {merValue / 3600 / 24 / 365:N1}년");
            }

            // 하노이의 탑 문제
            Console.WriteLine("\n4개의 원판을 A기둥에서 C기둥으로 쌓아보겠습니다.");
            Console.WriteLine($"Hanoi Tower : {4}, {'A'} -> {'B'} -> {'C'}\n");
            HanoiCal(4, 'A', 'B', 'C');
        }

        // 메르센의 수 계산 (메르센 수 : 2^n - 1)
        private static double MersenneCal(int number)
        {
            return Math.Pow(2, number) - 1;
        }

        // 하노이의 탑의 원반 이동 계산
        private static void HanoiCal(int n, char from, char to, char by)
        {
            // 종료 조건
            if (n == 1)
            {
                Console.WriteLine($"Move : {from} -> {to}");
            }
            else
            {
                HanoiCal(n - 1, from, by, to);
                Console.WriteLine($"Move : {from} -> {to}");
                HanoiCal(n - 1, by, to, from);
            }
        }
    }
}
