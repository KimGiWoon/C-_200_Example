using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Predicate<T> 델리게이트 : 매개변수를 보내서 bool값을 반환하는 델리게이트
namespace C__200_Example
{
    internal class Example_118
    {
        static void Main(string[] args)
        {
            int number = 6;
            Action<string> explanationPrint = (explanation) => Console.WriteLine(explanation);  // Action 델리게이트 선언
            Action nextLine = () => Console.WriteLine();    // 빈줄 델리게이트 선언
            Predicate<int> isEven = n => n % 2 == 0;    // 홀짝 확인 Predicate 델리게이트 선언
            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());    // 소문자 확인 Predicate 델리게이트 선언

            explanationPrint("숫자 6이 짝수인지 홀수인지 판별하겠습니다.");
            Console.WriteLine($"6을 짝수입니까? {isEven(number)}");

            nextLine();

            explanationPrint("Test와 test는 같습니까?");
            Console.WriteLine(isLowerCase("Test"));
        }
    }
}
