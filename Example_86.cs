using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TimeSpan 구조체의 사용 방법
namespace C__200_Example
{
    internal class Example_86
    {
        static void Main(string[] args)
        {
            // 오늘 날짜
            DateTime today = DateTime.Now;
            
            // 새해 날짜
            DateTime newYearDay = new DateTime(2027, 1, 1);

            // 새해까지 남은 날짜
            TimeSpan timeSpan = newYearDay - today;
            //TimeSpan timeSpan1 = newYearDay.Subtract(today);  // Subtract 메서드를 사용해서도 차이를 구할 수 있음

            Console.WriteLine("오늘 날짜와 새해 날짜를 출력합니다.");
            Console.WriteLine($"오늘은 {today.ToShortDateString} 입니다.");
            Console.WriteLine($"새해는 {newYearDay.ToShortDateString} 입니다.");

            Console.WriteLine("\n오늘부터 새해까지의 시간 간격을 출력합니다.");
            Console.WriteLine($"{timeSpan} 남았습니다.");    // Day부터 Tick까지 출력
            Console.WriteLine($"{timeSpan.Days} 일 남았습니다.");   // Day만 출력
            Console.WriteLine($"{timeSpan.Hours} 시간 남았습니다.");   // Hour만 출력
            Console.WriteLine($"{timeSpan.Minutes} 분 남았습니다.");   // Minute만 출력
            Console.WriteLine($"{timeSpan.Seconds} 초 남았습니다.");   // Second만 출력
            Console.WriteLine($"{timeSpan.Milliseconds} 밀리초 남았습니다.");   // Milliseconds만 출력

            Console.WriteLine("\n또는 TimeSpan 구조체의 속성을 사용하여 나타낼 수 있습니다.");
            Console.WriteLine($"{timeSpan} 남았습니다.");    // Day부터 Tick까지 출력
            Console.WriteLine($"{(int)timeSpan.TotalDays} 일 남았습니다.");   // Day만 출력
            Console.WriteLine($"{(int)timeSpan.TotalHours} 시간 남았습니다.");   // Hour만 출력
            Console.WriteLine($"{(int)timeSpan.TotalMinutes} 분 남았습니다.");   // Minute만 출력
            Console.WriteLine($"{(int)timeSpan.TotalSeconds} 초 남았습니다.");   // Second만 출력
            Console.WriteLine($"{(long)timeSpan.TotalMilliseconds} 밀리초 남았습니다.");   // Milliseconds만 출력
            Console.WriteLine($"0.1밀리초인 Tick으로는 {timeSpan.Ticks} 남았습니다");   // Tick만 출력
        }
    }
}
