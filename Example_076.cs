using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 두 숫자 사이의 모든 정수 값을 더하는 메서드
namespace C__200_Example
{
    internal class Example_76
    {
        static void Main(string[] args)
        {
            int inputNumber1 = 0;
            int inputNumber2 = 0;
            int sumNumber1 = 0;
            int sumNumber2 = 0;
            int startNum = 1;

            // 첫번째 숫자 입력
            inputNumber1 = InputNumber($"{startNum}부터 입력한 사이의 모든 값을 더합니다.", startNum);
            // 1부터 첫번째 입력 숫자 사이의 더한 값 저장 
            sumNumber1 = SumNumber(inputNumber1, startNum);

            // 결과 출력
            Console.WriteLine($"{startNum}부터 {inputNumber1}까지의 더한 값은 : {sumNumber1}입니다.");

            // 두번째 숫자 입력
            inputNumber2 = InputNumber($"\n첫번째 입력한 숫자인 {inputNumber1}부터 입력한 사이의 모든 값을 더합니다.", inputNumber1);
            // 1부터 첫번째 입력 숫자 사이의 더한 값 저장 
            sumNumber2 = SumNumber(inputNumber2, inputNumber1);

            // 결과 출력
            Console.WriteLine($"{inputNumber1}부터 {inputNumber2}까지의 더한 값은 : {sumNumber2}입니다.");
        }

        // 숫자 입력
        private static int InputNumber(string str, int number)
        {
            int inputNum;
            int startNum = number;

            Console.WriteLine(str);
            Console.Write("숫자를 입력하세요 : ");

            // 1이상의 숫자 입력 확인
            while (!int.TryParse(Console.ReadLine(), out inputNum) || inputNum < startNum + 1)
            {
                Console.WriteLine($"{startNum}이상의 수를 입력하세요");
                Console.Write("숫자를 입력하세요 : ");
            }

            return inputNum;
        }

        // 입력한 수를 더하기
        private static int SumNumber(int number, int startNum)
        {
            int num = startNum;
            int sum = 0;

            for(int i = num; i <= number; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
