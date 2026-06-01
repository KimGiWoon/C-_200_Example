using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LinkedList 클래스를 활용한 프로그램
namespace C__200_Example
{
    internal class Example_97
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Random random = new Random();

            int count = 5;
            int x;
            int y;
            int z;

            for (int i = 0; i < count; i++)
            {
                linkedList.InsertLast(random.Next(100)); // 0 ~ 99 숫자를 맨 끝 노드에 추가
            }

            Console.WriteLine("랜덤한 5개의 값의 리스트입니다.");
            linkedList.PrintNode();

            Console.Write("\n맨 앞에 10, 맨뒤에 90을 삽입합니다. <Enter>를 누르세요");
            Console.ReadLine();

            linkedList.InsertFront(10);
            linkedList.InsertLast(90);
            linkedList.PrintNode();

            Console.WriteLine("\nx 노드 뒤에 y값을 저장하려고 합니다.");
            Console.Write("x값을 입력하세요 : ");
            x = int.Parse(Console.ReadLine());

            Console.Write("y값을 입력하세요 : ");
            y = int.Parse(Console.ReadLine());

            linkedList.InsertAfter(x, y);
            linkedList.PrintNode();

            Console.Write("\n삭제할 노드와 값을 입력하세요 : ");
            z = int.Parse(Console.ReadLine());
            linkedList.DeleteNode(z);
            linkedList.PrintNode();

            Console.WriteLine("\n리스트를 뒤집어 출력합니다. <Enter>를 누르세요.");
            Console.ReadLine();

            linkedList.NodeReverse();
            linkedList.PrintNode();
        }
    }
}
