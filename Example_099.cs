using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stack을 이용한 프로그램
namespace C__200_Example
{
    internal class Example_99
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            Random random = new Random();

            Console.WriteLine("0부터 99까지의 랜덤 숫자 10개를 Stack에 넣습니다.");

            for (int i = 0; i < stack.GetStackCount(); i++)
            {
                int value = random.Next(100);   // 0 ~ 99 랜덤 숫자

                stack.Push(value);
                Console.Write($"Push{i+1} = {value}, ");
            }

            Console.WriteLine();
            Console.WriteLine("\nStack에 넣은 값을 위에서 부터 내보냅니다.");

            for (int i = 0; i < stack.GetStackCount(); i++)
            {
                Console.Write($"Pop({i+1}) = {stack.Pop()}, ");
            }

            Console.WriteLine();
        }
    }
}
