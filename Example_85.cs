using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DateTime 구조체
namespace C__200_Example
{
    internal class Example_85
    {
        static void Main(string[] args)
        {
            // 날짜와 시간을 지정하여 DateTime 객체 생성
            DateTime date1 = new DateTime(1992, 7, 4, 8, 44, 0);
            DateTime date2 = new DateTime(1990, 1, 27, 12, 6, 0);

            Console.WriteLine(date1);
            Console.WriteLine(date2);

            // Subtract 메서드로 date1과 date2의 일수의 차이를 구한다
            Console.WriteLine($"{date1.ToString()}과 {date2.ToString()}의 차이는 {date1.Subtract(date2).Days}");

            // Today속성으로 오늘 날짜 확인
            Console.WriteLine($"\n오늘 : {DateTime.Today}");

            // 어제 날짜
            DateTime yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine($"어제 : {yesterday.ToShortDateString()}"); // 날짜를 간단하게 출력

            // 내일 날짜
            DateTime tomorrow = DateTime.Today.AddDays(1);
            Console.WriteLine($"내일 : {yesterday.ToShortDateString()}"); // 날짜를 간단하게 출력
            Console.WriteLine($"내일 : {yesterday.ToShortTimeString()}"); // 시간을 간단하게 출력

            // 윤년 확인
            Console.WriteLine("\n2020년은 {0}", DateTime.IsLeapYear(2020) ? "윤년" : "평년");

            // 월의 날짜 수 확인
            Console.WriteLine($"2020년 2월은 {DateTime.DaysInMonth(2020, 2)}일 입니다.");

            // string을 DateTime으로 형변환 (Parse)
            string date = "1990-1-27 12:6";
            DateTime aDay = DateTime.Parse(date);
            Console.WriteLine($"문자열을 DateTime으로 Parse 형변환 : {aDay}");

            // string을 DateTime으로 형변환 (TryParse)
            string input = "1992/7/4 8:44";
            DateTime bDay;
            if (DateTime.TryParse(input, out bDay))
            {
                Console.WriteLine($"문자열을 DateTime으로 TryParse 형변환 : {bDay}\n");
            }

            // 현재 시간
            DateTime d1 = DateTime.Now;
            // 컴퓨터의 시간
            DateTime d2 = DateTime.UtcNow;

            Console.WriteLine($"현재 시간 : {d1}");
            Console.WriteLine($"컴퓨터 현재 시간 : {d2}");
        }
    }
}
