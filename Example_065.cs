using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 클래스와 구조체
    internal class Example_65
    {
        // 날짜 구조체
        struct DateStruct
        {
            public int year;
            public int month;
            public int day;
        }

        // 날짜 클래스
        class DateClass
        {
            public int year;
            public int month;
            public int day;
        }

        static void Main(string[] args)
        {
            // 구조체 생성
            DateStruct firstStructDay = new DateStruct();
            // 클래스 생성
            DateClass firstClassDay = new DateClass();

            // 값을 할당하지 않으면 디폴트 값이 할당 됨
            PrintResult("구조체 초기값", firstStructDay.year, firstStructDay.month, firstStructDay.day);
            PrintResult("클래스 초기값", firstClassDay.year, firstClassDay.month, firstClassDay.day);
            Console.WriteLine();

            // 구조체 데이터 테스트
            StructDateTest(firstStructDay, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            Console.WriteLine();
            // 클래스 데이터 테스트
            ClassDateTest(firstClassDay, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        // 구조체 테스트
        private static void StructDateTest(DateStruct structDay, int year, int month, int day)
        {
            structDay.year = year;
            structDay.month = month;
            structDay.day = day;

            // 값 할당 결과 출력
            PrintResult("구조체 값 할당", structDay.year, structDay.month, structDay.day);

            // 두번째 구조체를 만들어 원본 구조체 복사
            DateStruct secondStructDay = structDay;

            secondStructDay.year = year - 10;
            secondStructDay.month = month - 10;
            secondStructDay.day = day - 10;

            // 값 할당 결과 출력
            PrintResult("복사한 구조체 값 변경", secondStructDay.year, secondStructDay.month, secondStructDay.day);

            PrintResult("원본 구조체 값", structDay.year, structDay.month, structDay.day);
        }

        // 클래스 테스트
        private static void ClassDateTest(DateClass classDay, int year, int month, int day)
        {
            classDay.year = year;
            classDay.month = month;
            classDay.day = day;

            // 값 할당 결과 출력
            PrintResult("클래스 값 할당", classDay.year, classDay.month, classDay.day);

            // 두번째 클래스를 만들어 원본 클래스 복사
            DateClass secondclassDay = classDay;

            secondclassDay.year = year - 10;
            secondclassDay.month = month - 10;
            secondclassDay.day = day - 10;

            // 값 할당 결과 출력
            PrintResult("복사한 클래스 값 변경", secondclassDay.year, secondclassDay.month, secondclassDay.day);

            PrintResult("원본 클래스 값", classDay.year, classDay.month, classDay.day);
        }

        // 결과 출력
        private static void PrintResult(string text, int year, int month, int day)
        {
            Console.WriteLine($"{text} : {year}/{month}/{day}");
        }
    }
}
