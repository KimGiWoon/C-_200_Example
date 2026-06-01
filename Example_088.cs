using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DateTime Format
namespace C__200_Example
{
    internal class Example_88
    {
        static void Main(string[] args)
        {
            // 오늘 날짜
            DateTime today = DateTime.Now;

            Console.WriteLine($"{today.ToString("yyyy년 MM월 dd일")}");
            Console.WriteLine(string.Format($"{today:yyyy년 MM월 dd일}"));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-US")));

            // 형식 지정자 사용
            // d : 축약된 날짜 형식
            Console.WriteLine($"d : {today.ToString("d")}");

            // D : 긴 날짜 형식
            Console.WriteLine($"D : {today.ToString("D")}");

            // t : 축약된 시간
            Console.WriteLine($"t : {today.ToString("t")}");

            // T : 긴 시간
            Console.WriteLine($"T : {today.ToString("T")}");

            // g : 일반 날짜 및 시간 (초생략)
            Console.WriteLine($"g : {today.ToString("g")}");

            // G : 일반 날짜 및 시간
            Console.WriteLine($"G : {today.ToString("G")}");

            // f : 자세한 날짜 및 시간 (초생략)
            Console.WriteLine($"f : {today.ToString("f")}");

            // F : 자세한 날짜 및 시간
            Console.WriteLine($"F : {today.ToString("F")}");

            // s : 정렬 가능한 서식, ISO 8610 표준 (밀리초 생략)
            Console.WriteLine($"s : {today.ToString("s")}");

            // o : 정렬 가능한 서식, ISO 8610 표준
            Console.WriteLine($"o : {today.ToString("O")}");

            // r : RFC 1123 표시
            Console.WriteLine($"r : {today.ToString("r")}");

            // u : UTC로 출력
            Console.WriteLine($"u : {today.ToString("u")}");
        }
    }
}
