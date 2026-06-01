using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 정적 메서드와 인스턴스 메서드를 가진 클래스
    class DateCalculator
    {
        // 날짜 정보를 저장하는 멤버 변수
        public int year;
        public int month;
        public int day;

        // 각 월이 시작되기 전까지의 누적 일수
        static int[] days = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        // 정적 메서드 (윤년 확인)
        public static bool IsLeapYear(int year)
        {
            // 윤년 조건으로 4로 나누어지고, 100으로 나누어지지 않거나 400으로 나누어지는 해
            bool leapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            return leapYear;
        }

        // 인스턴스 메서드
        public int DayOfYear()
        {
            // 해당 날짜가 1년 중 며칠째인지 계산하고 윤년은 1을 더하여 계산
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }

    internal class Example_67
    {
        static void Main(string[] args)
        {
            DateCalculator dateCalculator = new DateCalculator();

            dateCalculator.year = DateTime.Now.Year;
            dateCalculator.month = DateTime.Now.Month;
            dateCalculator.day = DateTime.Now.Day;

            // 인스턴스 메서드는 객체 이름으로 호출
            Console.WriteLine($"Today : {dateCalculator.year}/{dateCalculator.month}/{dateCalculator.day}는 {dateCalculator.DayOfYear()}일째 되는 날입니다.");

            // 정적 메서드는 객체 생성없이 클래스 이름으로 호출
            if (DateCalculator.IsLeapYear(dateCalculator.year) == true)
            {
                Console.WriteLine($"{dateCalculator.year}는 윤년입니다.");
            }
            else
            {
                Console.WriteLine($"{dateCalculator.year}는 평년입니다.");
            }
        }
    }
}
