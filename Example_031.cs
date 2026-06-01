using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // String과 StringBuilder 차이점
    internal class Example_31
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test");
            Console.WriteLine($"{sb.ToString()} ({sb.Length} characters)");

            sb.Clear(); // 객체의 모든 문자 삭제
            Console.WriteLine($"{sb.ToString()} ({sb.Length} characters)");

            sb.Append("This is a New String");  // 객체의 끝에 문자열 추가
            Console.WriteLine($"{sb.ToString()} ({sb.Length} characters)");

            sb.Insert(5, "xyz ", 2);    // 특정한 위치에 문자열 삽입
            Console.WriteLine($"{sb.ToString()} ({sb.Length} characters)");

            sb.Remove(5, 4);    // 특정한 위치의 문자열 삭제
            Console.WriteLine($"{sb.ToString()} ({sb.Length} characters)");

            sb.Replace("xyz", "abc");   // 지정한 문자열로 변경
            Console.WriteLine($"{sb.ToString()} ({sb.Length} characters)");

            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start();

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }
            time.Stop();

            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");    // 지난 시간 확인

            StringBuilder test2 = new StringBuilder();
            time.Reset();
            time.Start();

            for (int i = 0; i < 100000; i++)
            {
                test2.Append(i);
            }
            time.Stop();

            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + "ms");    // 지난 시간 확인
        }
    }
}
