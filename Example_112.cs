using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인덱서 (인스턴스 내의 데이터에 접근하는 방법이며, 프로퍼티와 똑같은데 다른점은 배열과 같이 인덱스를 사용할 수 있다는 점이 다르다)
namespace C__200_Example
{
    // 제네릭 클래스
    class MyCollection<T>
    {
        // T자료형으로 3개 저장할 수 있는 배열 생성
        private T[] array = new T[3];

        // this[]로 인덱서 정의
        public T this[int i]    
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public int GetLength()
        {
            return array.Length;
        }
    }

    internal class Example_112
    {
        static void Main(string[] args)
        {
            // string형 MyCollection 클래스 객체 생성
            MyCollection<string> myString = new MyCollection<string>();

            // 클래스에 인덱서를 만들어서 배열과 같이 [] 연산자 사용가능
            myString[0] = "Hello, World";
            myString[1] = "Hello, C#";
            myString[2] = "Hello, Indexer!";

            ArrayPrint(myString);
        }

        // 배열 출력
        private static void ArrayPrint(MyCollection<string> myString)
        {
            for (int i = 0; i < myString.GetLength(); i++)
            {
                Console.WriteLine($"myString[{i}] : {myString[i]}");
            }
        }
    }
}
