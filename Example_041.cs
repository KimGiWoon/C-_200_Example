using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // Switch 문
    internal class Example_41
    {   
        private enum GRADE
        {
            A = 9,
            B = 8,
            C = 7,
            D = 6,
            F = 5
        }

        static void Main(string[] args)
        {
            int _score;

            while (true)
            {
                Console.Write("점수를 입력하세요 : ");
                bool check = int.TryParse(Console.ReadLine(), out _score);

                if (check)
                {
                    break;
                }

                Console.WriteLine("숫자를 입력해주세요\n");
            }

            char ifResult = Score_If_Result(_score);
            char switchResult = Score_Switch_Result(_score);
            char switchEnumResult = Score_Switch_Enum_Result(_score);

            Console.WriteLine($"if ~ elst if 결과 : {ifResult}");
            Console.WriteLine($"Switch 결과 : {switchResult}");
            Console.WriteLine($"Switch (enum응용) 결과 : {switchResult}");
        }

        // 점수 결과 (if ~ else if)
        private static char Score_If_Result(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70)
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        // 점수 결과 (Switch)
        private static char Score_Switch_Result(int score)
        {
            switch (score / 10)
            {
                case 9:
                    return 'A';
                case 8:
                    return 'B';
                case 7:
                    return 'C';
                case 6:
                    return 'D';
                default:
                    return 'F';
            }
        }

        // 점수 결과 (Switch - enum 응용)
        private static char Score_Switch_Enum_Result(int score)
        {
            switch ((GRADE)(score / 10))
            {
                case GRADE.A:
                    return 'A';
                case GRADE.B:
                    return 'B';
                case GRADE.C:
                    return 'C';
                case GRADE.D:
                    return 'D';
                case GRADE.F:
                default:
                    return 'F';
            }
        }
    }
}
