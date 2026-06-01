using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생애 계산기
namespace C__200_Example
{
    internal class Example_73
    {
        static void Main(string[] args)
        {
            // 생일 입력
            BirthDayInput();
        }

        // 생일 입력
        private static void BirthDayInput()
        {
            // 생일 데이터
            int year;
            int month;
            int day;

            // 오늘 날짜 데이터
            int tYear;
            int tMonth;
            int tDay;

            int totalDay = 0;

            Console.Write("생일을 입력하세요(yyyy/mm/dd) : ");

            string? birth = Console.ReadLine();

            if (birth == null)
            {
                Console.WriteLine("빈 문자를 입력하면 안됩니다. 다시 입력해 주세요");
                return;
            }

            // 입력 받은 생일을 년/월/일로 나누기
            string[] birthArray = birth.Split('/');

            // 나눈 생일을 저장
            year = int.Parse(birthArray[0]);
            month = int.Parse(birthArray[1]);
            day = int.Parse(birthArray[2]);

            // 오늘 날짜 저장
            tYear = DateTime.Now.Year;
            tMonth = DateTime.Now.Month;
            tDay = DateTime.Now.Day;

            // 올해 1월1일부터 오늘까지 날짜 수 계산
            totalDay += DayOfYear(tYear, tMonth, tDay);

            // 태어난 해의 생일부터 마지막 날까지의 남은 날짜 수 계산
            int yearDays = IsLeapYear(year) ? 366 : 365;
            totalDay += yearDays - DayOfYear(year, month, day);

            for (int i = year + 1; i < tYear; i++)
            {
                if (IsLeapYear(i))
                {
                    totalDay += 366;
                }
                else
                {
                    totalDay += 365;
                }
            }

            Console.WriteLine($"태어난 날부터 지금까지 총 경과 일수 : {totalDay}일");
        }

        // 해당 날짜가 1년 중 몇 번째 날인지 계산
        private static int DayOfYear(int year, int month, int day)
        {
            // 다음 달까지의 남은 일 수
            int[] nextDays = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

            int result = nextDays[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);

            return result;
        }

        // 윤년 계산
        private static bool IsLeapYear(int year)
        {
            bool result = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            return result;
        }
    }
}
