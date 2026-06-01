using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{    
    // Const와 readonly

    class ConstEx
    {
        public const int number = 3;    // 컴파일 시점에 고정 (클래스에 속한 고정값이라 객체를 생성하지 않고 접근 가능)
    }

    class ReadonlyEx
    {
        public readonly int number = 10;

        // 생성자 초기화
        public ReadonlyEx()
        {
            number = 20;
        }

        // 매개변수 전달 초기화
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }

    internal class Example_33
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number);

            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }

}
