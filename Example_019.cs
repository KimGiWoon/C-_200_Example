using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 오버플로 예외 처리 (checked 키워드)
    internal class Example_19
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"int.MaxValue = {int.MaxValue}"); // int MaxValue : 2147483647
            //int x = int.MaxValue;
            //int y = x + 10;

            //Console.WriteLine($"int.MaxValue + 10 = {y}");      // 오버플로 발생으로 -2147483639 출력

            int x = int.MaxValue;
            int y = 0;

            try
            {
                checked
                {
                    y = x + 10;     // checked 안에서 오버플로 발생 시 OverflowException 예외 발생하여 대입이 되지 않음
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);   // 오류 메세지 출력
            }
            Console.WriteLine($"int.MaxValue + 10 = {y}");
        }
    }
}
