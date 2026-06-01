using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // BMI 계산기 (체질량지수)
    internal class Example_42
    {
        private enum BMI
        {
            저체중,
            정상체중,
            경도비만,
            비만,
            고도비만
        }

        static void Main(string[] args)
        {
            // 초기화
            double weight = 0;
            double height = 0;

            while(true)
            {
                try
                {
                    // 사용자 정보
                    StateInfo(out weight, out height);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                    Console.WriteLine($"{e.Message}\n");
                }
            }

            // BMI 계산
            Bmi_Calculation(weight, height);
        }

        // 정보 입력
        private static void StateInfo(out double weight, out double height)
        {
            Console.WriteLine("몸무게와 키를 입력해주세요");
            Console.Write("몸무게 : ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("키 (단위 : m) : ");
            height = double.Parse(Console.ReadLine());
            height /= 100;  // 키는 m 단위
        }

        // BMI 계산
        private static void Bmi_Calculation(double weight, double height)
        {
            double bmi_value = weight / (height * height);
            BMI comment;

            if (bmi_value < 20)
            {
                comment = BMI.저체중;
            }
            else if (bmi_value < 25)
            {
                comment = BMI.정상체중;
            }
            else if (bmi_value < 30)
            {
                comment = BMI.경도비만;
            }
            else if (bmi_value < 40)
            {
                comment = BMI.비만;
            }
            else
            {
                comment = BMI.고도비만;
            }

            Console.WriteLine($"당신의 BMI 치수는 {bmi_value:F3}이고 {comment}");
        }
    }
}
