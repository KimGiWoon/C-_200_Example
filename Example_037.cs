using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 변수의 초기화와 default
    internal class Example_37
    {
        enum E
        {
            Red,
            Green,
            Blue
        }

        static void Main(string[] args)
        {
            // 디폴트 할당 후 출력
            int a = default;
            string s = default;
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            Console.WriteLine("E = " + default(E));
            Console.WriteLine("E = " + (E)0);

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList : " + iList.GetLast());

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("sList : " + sList.GetLast());
        }

        // 제네릭 리스트 클래스
        public class MyList<T>
        {
            private class Node
            {
                // 노드의 멤버 변수
                public T data;
                public Node next;
            }

            // 첫번째 노드 디폴트
            private Node head = default;

            // Data를 t로 하는 노드를 만들어 맨앞에 추가
            public void AddNode(T t)
            {
                Node newNode = new Node();
                newNode.next = head;
                newNode.data = t;
                head = newNode;
            }

            // 마지막 노드의 데이터 가져오기
            public T GetLast()
            {
                // 디폴트 초기화
                T temp = default(T);

                Node current = head;
                while (current != null)
                {
                    temp = current.data;
                    current = current.next;
                }

                return temp;
            }
        }
    }
}
