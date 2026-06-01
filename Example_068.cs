using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자
namespace C__200_Example
{
    class DateInfo
    {
        private int _year;
        private int _month;
        private int _day;
        private string _info;

        // 매개변수가 없는 생성자 (기본 생성자)
        public DateInfo()
        {
            _year = DateTime.Now.Year;
            _month = DateTime.Now.Month;
            _day = DateTime.Now.Day;
            _info = "오늘";
        }

        // 매개변수가 있는 생성자
        public DateInfo (int year, int month, int day, string info)
        {
            _year = year;
            _month = month;
            _day = day;
            _info = info;
        }

        // 날짜 출력
        public void PrintDate()
        {
            Console.WriteLine($"{_info} 날짜 : {_year}/{_month}/{_day}");
        }
    }

    internal class Example_68
    {
        static void Main(string[] args)
        {
            // 생성자 메서드에 매개변수 전달
            DateInfo birthDay = new DateInfo(1992, 9, 14, "생일");
            DateInfo christmasDay = new DateInfo(2026, 12, 25, "크리스마스");

            // 생성자 메서드에 매개변수 미전달
            DateInfo today = new DateInfo();

            birthDay.PrintDate();
            christmasDay.PrintDate();
            today.PrintDate();
        }
    }
}
