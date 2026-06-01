using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LinkedList 구현 (연결 리스트)
namespace C__200_Example
{
    //internal class Example_96
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}

    // internal은 어셈블리 내부에서 public, 외부에서 private와 같은 역할을 함
    //-----------------------------------------------------------------------------------------
    // Node 사용 클래스
    internal class Node
    {
        private int _nodeData;
        private Node _nextNode;

        internal Node(int data)
        {
            _nodeData = data;
            _nextNode = null;
        }

        // 다음 노드 가져오기
        internal Node GetNextNode()
        {
            return _nextNode;
        }

        // 다음 노드 설정하기
        internal void SetNextNode(Node next)
        {
            _nextNode = next;
        }

        // 노드 데이터 가져오기
        internal int GetNodeData()
        {
            return _nodeData;
        }

        // 노드 데이터 설정하기
        internal void SetNodeData(int data)
        {
            _nodeData = data;
        }
    }

    //-----------------------------------------------------------------------------------------
    // LinkedList 사용 클래스
    internal class LinkedList
    {
        private Node _headNode;

        // 헤드 노드 설정
        internal void SetHeadNode(Node node)
        {
            _headNode = node;
        }

        // 헤드 노드 가져오기
        internal Node GetHeadNode()
        {
            return _headNode;
        }

        // 끝 노드 가져오기
        internal Node GetLastNode()
        {
            Node lastNode = GetHeadNode();

            while (lastNode.GetNextNode != null)
            {
                lastNode = lastNode.GetNextNode();
            }

            return lastNode;
        }

        // prev 뒤에 data를 갖는 노드 삽입
        internal void InsertAfter(int prev, int data)
        {
            Node previousNode = null;

            // prev 찾기
            for (Node temp = GetHeadNode(); temp != null; temp = temp.GetNextNode())
            {
                if (temp.GetNodeData() == prev)
                {
                    previousNode = temp;
                }
            }

            if (previousNode == null)
            {
                Console.WriteLine("{0} data is not in the list");
                return;
            }

            Node node = new Node(data);
            node.SetNextNode(previousNode.GetNextNode());
            previousNode.SetNextNode(node);
        }

        // key값을 저장하고 있는 노드 삭제하기
        internal void DeleteNode(int key)
        {
            Node temp = GetHeadNode();
            Node previousNode = null;

            if (temp != null && temp.GetNodeData() == key)  // HeadNode가 찾는 값이면
            {
                SetHeadNode(temp.GetNextNode());
                return;
            }

            while (temp != null && temp.GetNodeData() != key)   // HeadNode가 찾는 값이 아니면 prev와 temp를 한 칸씩 이동
            {
                previousNode = temp;
                temp = temp.GetNextNode();
            }

            if (temp == null)    // 끝까지 찾는 값이 없으면 나가기
            {
                return;
            }

            // 이전 노드가 삭제할 노드의 다음 노드를 가리키게함
            previousNode.SetNextNode(temp.GetNextNode());
        }

        // 노드 뒤집기
        internal void NodeReverse()
        {
            Node previousNode = null;
            Node currentNode = GetHeadNode();
            Node temp = null;

            while(currentNode != null)
            {
                temp = currentNode.GetNextNode();
                currentNode.SetNextNode(previousNode);
                previousNode = currentNode;
                currentNode = temp;
            }

            SetHeadNode(temp);
        }

        // 맨 앞에 노드 추가
        internal void InsertFront(int data)
        {
            Node node = new Node(data);
            node.SetNextNode(_headNode);
            SetHeadNode(node);
        }

        // 맨 끝에 노드 추가
        internal void InsertLast(int data)
        {
            Node node = new Node(data);
            
            if (_headNode == null)
            {
                SetHeadNode(node);
                return;
            }

            Node lastNode = GetLastNode();
            lastNode.SetNextNode(node);
        }

        // 노드 출력
        internal void PrintNode()
        {
            for (Node node = GetHeadNode(); node != null; node = node.GetNextNode())
            {
                Console.Write($"{node.GetNodeData()} -> ");
            }

            Console.WriteLine();
        }
    }
}
