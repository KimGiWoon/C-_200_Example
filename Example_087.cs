using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TimeSpan을 이용한 생애계산기
namespace C__200_Example
{
    internal class Example_87
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 날부터 오늘까지 생애날짜를 계산합니다.");
            Console.Write("태어난 날짜와 시분초를 입력하세요(yyyy-MM-dd HH:mm:ss) : ");
            DateTime birthDay = new DateTime();

            // 예외 처리
            try
            {
                birthDay = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("태어난 날짜와 시분초를 다시 입력하세요");
                return;
            }

            // 현재 날짜
            DateTime today = DateTime.Now;

            // 현재 날짜와 태어난 날의 차이 
            TimeSpan timeSpan = today - birthDay;

            Console.WriteLine($"태어난 날짜 : {birthDay}");
            Console.WriteLine($"오늘 날짜 : {today}");
            Console.WriteLine($"생애 날짜 : {timeSpan}");

            Console.WriteLine($"\n당신은 지금 이 순간까지 {timeSpan.Days}일 {timeSpan.Hours}시간 {timeSpan.Minutes}분 {timeSpan.Seconds}초를 살았습니다.");
        }
    }
}
