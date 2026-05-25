using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 캐스팅과 자료형 변환
    internal class Example_13
    {
        static void Main(string[] srgs)
        {
            int num = 2147483647;
            long bigNum = num;  // 암시적 형변환

            Console.WriteLine(bigNum);


            float x = 1234.5f;
            int a;

            a = (int)x; // 명시적 형변환 (캐스팅)

            Console.WriteLine(a);
        }
    }
}
