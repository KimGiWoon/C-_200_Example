using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 선택적 인수와 명명된 인수
namespace C__200_Example
{
    internal class Example_91
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(4, 2));
            Console.WriteLine(MyPower(4));
            Console.WriteLine(MyPower(3, 4));

            Console.WriteLine(Area(5, 6));
            Console.WriteLine(Area(w : 7, h : 3));  // 매개변수 이름으로 매칭
            Console.WriteLine(Area(h : 10, w : 6));
        }

        // 입력수 제곱
        static int MyPower(int x, int y = 2)    // y의 기본값 2 설정
        {
            int result = 1;

            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }

        // 사각형의 넓이 구하기
        static int Area(int h, int w)
        {
            return h * w;
        }
    }
}
