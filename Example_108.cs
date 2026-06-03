using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Queue<T> 컬렉션의 사용 방법
namespace C__200_Example
{
    internal class Example_108
    {
        static void Main(string[] args)
        {
            // 일반화 Queue 객체 생성
            Queue<string> queue1 = new Queue<string>();
            string[] animalName = { "Tiger", "Lion", "Zebra", "Cow", "Rabbit" };

            // Queue에 값 넣기
            foreach (string animal in animalName)
            {
                queue1.Enqueue(animal);
            }

            // 값 확인
            PrintQueueData("Queue1 : ", queue1);

            // Queue에서 값 내보내기
            Console.WriteLine($"    Dequeue : {queue1.Dequeue()}");
            // Queue에서 다음 내보낼 값 확인
            Console.WriteLine($"    Peek : {queue1.Peek()}");

            // Queue1의 값을 복사하여 Queue2를 생성
            Queue<string> queue2 = new Queue<string>(queue1.ToArray());
            PrintQueueData("Queue2 : ", queue2);

            // 배열을 만들어 Queue1의 값을 배열의 0번째부터 복사
            string[] array = new string[queue1.Count];
            queue1.CopyTo(array, 0);

            // 복사한 배열의 값으로 Queue객체 생성
            Queue<string> queue3 = new Queue<string>(array);
            PrintQueueData("Queue3 : ", queue3);

            // Queue에 있는 값 찾기
            Console.WriteLine($"Queue1.Contains(Zebra) : {queue1.Contains("Zebra")}");
            Console.WriteLine($"Queue1.Contains(Monkey) : {queue1.Contains("Monkey")}");

            // queue3 값 초기화
            queue3.Clear();
            Console.WriteLine($"Count = {queue1.Count}, {queue2.Count}, {queue3.Count}");


        }

        // Queue에 넣은 값 출력
        private static void PrintQueueData(string comment, Queue<string> queue)
        {
            Console.Write($"{comment}");

            foreach(string animal in queue)
            {
                Console.Write($"{animal}, ");
            }

            Console.WriteLine();
        }
    }
}
