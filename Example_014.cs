using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{   
    // 문자열과 숫자의 변환
    internal class Example_14
    {
        static void Main(string[] srgs)
        {
            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하세요 : ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result)
            {
                Console.WriteLine($"{input}은 int로 변환될 수 없습니다.");
            }
            else
            {
                Console.WriteLine($"int {value}로 변환되었습니다.");
            }

            Console.Write("2. double로 변환할 문자열을 입력하세요 : ");
            input = Console.ReadLine();

            try
            {
                double a = Double.Parse(input);     // Double : .NET 구조체 타입, double : C# 키워드
                //double b = Convert.ToDouble(input);


                Console.WriteLine($"double '{a}'으로 변환되었습니다.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
