using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Queue<T> 구현
namespace C__200_Example
{
    class Node<T>
    {
        internal T value;
        internal Node<T> next;

        public Node (T value)
        {
            this.value = value;
            next = null;
        }
    }

    class MyQueue<T>
    {
        internal Node<T> first = null;
        internal Node<T> last = null;

        // 큐에 값 넣기
        internal void EnQueue(Node<T> node)
        {
            if (last == null)
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }

        // 큐에 값 내보내기
        internal T DeQueue()
        {
            if (first == null)
            {
                Console.WriteLine("Queue Empty");
                return default(T);
            }
            else
            {
                T value = first.value;
                first = first.next;
                return value;
            }
        }

        // 큐 출력
        internal void PrintQueue()
        {
            Console.Write("Queue에 넣은 값 : ");

            for (Node<T> t = first; t != null; t = t.next)
            {
                Console.Write($"{t.value} -> ");
            }

            Console.WriteLine();
        }
    }
}
