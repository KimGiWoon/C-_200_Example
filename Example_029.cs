using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // String.Format의 날짜와 시간 형식 지정
    internal class Example_29
    {
        static void Main(string[] args)
        {
            string max = String.Format("{0:X} {0:E} {0:N}", Int64.MaxValue);    // 16진수, 지수, 구분자가 있는 숫자형으로 변환
            Console.WriteLine(max);

            decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0}입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t}입니다.", DateTime.Now);    // 현재 날짜와 시간을 가져오기 (형식지정자 사용)
            Console.WriteLine(s);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);    // 초기값으로 1일 12시 23분 62초로 세팅
            string output = String.Format("소요 시간 : {0:c}", duration);
            Console.WriteLine(output);
        }
    }
}
