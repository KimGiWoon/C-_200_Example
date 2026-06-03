using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Queue를 이용한 프로그램
namespace C__200_Example
{
    internal class Example_101
    {
        static void Main(string[] args)
        {
            QueueTest1();
            QueueTest2();
        }

        // 만든 Queue 객체 사용
        private static void QueueTest1()
        {
            MyQueue<int> queue = new MyQueue<int>();
            Random random = new Random();
            int count = 5;

            Console.WriteLine("0부터 99까지의 랜덤 숫자 5개를 Queue에 넣습니다. (구현 Queue)");

            for (int i = 0; i < count; i++)
            {
                queue.EnQueue(new Node<int>(random.Next(100)));
            }

            queue.PrintQueue();

            Console.WriteLine("\nQueue에 넣은 값 3개를 내보냅니다.");

            for (int i = 0; i < count - 2; i++)
            {
                Console.WriteLine($"DeQueue: {queue.DeQueue()}");
            }

            queue.PrintQueue();
        }

        // Queue 클래스 객체 사용
        private static void QueueTest2()
        {
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            int count = 5;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n0부터 99까지의 랜덤 숫자 5개를 Queue에 넣습니다. (Queue 클래스)");

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(random.Next(100));
            }

            PrintQueue(queue);

            Console.WriteLine("");
            Console.WriteLine("\nQueue에 넣은 값 3개를 내보냅니다.");

            for (int i = 0; i < count - 2; i++)
            {
                Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            }

            PrintQueue(queue);
        }

        // Queue에 있는 값 출력
        private static void PrintQueue(Queue<int> queue)
        {
            Console.Write("Queue에 넣은 값 : ");

            foreach(int value in queue)
            {
                Console.Write($"{value} -> ");
            }

            Console.WriteLine();
        }
    }
}
