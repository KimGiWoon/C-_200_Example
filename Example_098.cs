using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stack<T> 구현
namespace C__200_Example
{
    class MyStack<T>
    {
        const int maxSize = 10;
        private int top;

        private T[] arr = new T[maxSize];

        public MyStack()
        {
            top = 0;
        }

        // 스택에 값 넣기
        public void Push(T value)
        {
            if (top < arr.Count())
            {
                arr[top] = value;
                top++;
            }
            else
            {
                Console.WriteLine("Stack Full");
                return;
            }
        }

        // 스택에 값 내보내기
        public T Pop()
        {
            if (top > 0)
            {
                top--;
                return arr[top];
            }
            else
            {
                Console.WriteLine("Stack Empty");
                return default(T);
            }
        }

        // 스택 쌓을 수 있는 최대 수 가져오기
        public int GetStackCount()
        {
            return arr.Count();
        }
    }
}
