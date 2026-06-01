using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 그룹 분리자를 넣는 방법
    internal class Example_30
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("표시할 숫자를 입력하세요(종료: -1) : ");
                string s = Console.ReadLine();
                double v = double.Parse(s);

                if (v == -1)
                {
                    break;                
                }

                Console.WriteLine(NumberWithGroupSeparator(s));
            }
        }

        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;    // 소수점 아래 자릿수 변수
            double v = Double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - (s.IndexOf('.') + 1);  // 소수점을 아래 자릿수 확인
                string formasStr = "{0:N" + pos + "}";  // 포맷 문자열 만들기
                s = string.Format(formasStr, v);
            }
            else
            {
                s = string.Format("{0:N0}", v);
            }

            return s;
        }
    }
}
