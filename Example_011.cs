using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 형식지정자를 사용하는 String.Format()과 ToString()
    internal class Example_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678); // 천 단위, 소수점 2자리까지 출력
            Console.WriteLine("{0:D8}", 1234);      // 8자리로 출력, 빈 자리는 앞에 0을 채움
            Console.WriteLine("{0:F3}", 1234.56);   // 고정 소수점 형식으로 소수점 3자리까지 출력
            Console.WriteLine("{0,8}", 1234);       // 8자리 출력, 오른쪽 정렬
            Console.WriteLine("{0,-8}", 1234);      // 8자리 출력, 왼쪽 정렬
            Console.WriteLine();                    

            // String.Format에서 형식지정자 사용
            string s;                               

            s = string.Format("{0:N2}", 1234.5678); // N2 형식 문자열로 변환
            Console.WriteLine(s);                   

            s = string.Format("{0:D8}", 1234);      // D8 형식 문자열로 변환
            Console.WriteLine(s);                   

            s = string.Format("{0:F3}", 1234.56);   // F3 형식 문자열로 변환
            Console.WriteLine(s);                   

            Console.WriteLine();                   

            // ToString에서 형식지정자 사용
            Console.WriteLine(1234.5678.ToString("N2")); // N2 형식 문자열로 변환
            Console.WriteLine(1234.ToString("D8"));      // D8 형식 문자열로 변환
            Console.WriteLine(1234.56.ToString("F3"));   // F3 형식 문자열로 변환
            Console.WriteLine();                         

            // 사용자 지정 형식지정자 사용
            Console.WriteLine("{0:#.##}", 1234.5678);    // 소수점 2자리까지 출력
            Console.WriteLine("{0:0,0.00}", 1234.5678);  // 천 단위, 소수점 2자리까지 출력 
            Console.WriteLine("{0:#,#.##}", 1234.5678);  // 천 단위, 소수점 2자리까지 출력 
            Console.WriteLine("{0:000000.00}", 1234.5678); // 정수 6자리, 소수점 2자리로 출력 (0이 앞에 붙음)
            Console.WriteLine("{0:######.##}", 1234.5678); // 정수 6자리, 소수점 2자리로 출력 (0이 앞에 붙지 않음)
            Console.WriteLine();                         

            // 섹션 구분 기호 사용
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.567);  // 양수 형식
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567); // 음수 형식(괄호로 표시)
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);         // 0은 지정한 문자열 출력(zero)
        }
    }
}
