using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 값 형식과 참조 형식, ref 키워드
    // 값 형식 (int. double, char, bool 등, enum, struct)
    // 참조 형식 (object, string, dynamic, class, interface, delegate)
    internal class Example_34
    {
        static void Main(string[] args)
        {
            string s = "Before Passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        // 매개변수로 참조값을 복사해서 전달
        public static void Test(string s)
        {
            s = "After Passing";
        }

        // 매개변수로 원본 변수 자체를 전달
        public static void Test(ref string s)
        {
            s = "After Passing";
        }
    }
}
