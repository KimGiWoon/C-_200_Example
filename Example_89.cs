using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메소드에 인수를 전달하는 세 가지 방법
namespace C__200_Example
{
    internal class Example_89
    {
        static void Main(string[] args)
        {
            int a = 3;
            string name;
            int id;

            // 값 전달로 원본의 값이 수정되지 않음
            Sqr(a);
            Console.WriteLine($"Value : {a}");

            // 참조 전달로 원본의 값이 수정
            Sqr(ref a);
            Console.WriteLine($"Ref : {a}");

            // Out으로 반환된 값을 변수에 저장
            Sqr(out name, out id);
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Id : {id}");
        }

        // 값을 매개변수로 전달
        private static void Sqr(int x)
        {
            x *= 3;
        }

        // 참조로 매개변수 전달
        private static void Sqr(ref int x)
        {
            x *= 3;
        }

        // 매개변수는 Out키워드로 반환
        private static void Sqr(out string name, out int id)
        {
            Console.Write($"Enter Name : ");
            name = Console.ReadLine();
            Console.Write($"Enter Id : ");
            id = int.Parse(Console.ReadLine());
        }
    }
}
