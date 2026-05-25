using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // try ~ catch 문
    internal class Example_18
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;

            //Console.WriteLine(10.0 / y);    // 무한 출력
            //Console.WriteLine(x / y);       // 0으로 나눔으로 예외 발생 프로그램 종료

            try
            {
                Console.WriteLine(x / y);   // 예외 발생
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   // "0으로 나누려고 했다"는 오류 메세지 출력
            }
        }
    }
}
