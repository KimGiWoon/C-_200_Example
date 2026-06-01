using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 문자열을 연결하는 네가지 방법 (+ 연산자, 문자열 보간, String.Format, String.Concat과 String.Join 메서드)
    internal class Example_27
    {
        static void Main(string[] args)
        {
            string userName = "giwoon";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello" + userName + ". Today is " + date + ".";   // + 연산자 사용
            Console.WriteLine(strPlus);

            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);   // String.Format 사용
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}.";    // 문자열 보간 사용
            Console.WriteLine(strInterpolation);

            string strConcat = String.Concat("Hello ", userName, ". Today is ", date, "."); // String.Concat 사용
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);  // Concat 사용
            Console.WriteLine(s);

            s = String.Join(",", animals);  // Join 사용 (구분을 할 수 있음)
            Console.WriteLine(s);

        }
    }
}
