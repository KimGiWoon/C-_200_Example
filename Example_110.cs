using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hashtable과 Dictionary<TKey, TValue> 사용
namespace C__200_Example
{
    internal class Example_110
    {
        static void Main(string[] args)
        {
            // 문자열 키와 문자열 값을 가지고 있는 색상 딕셔너리 생성
            Dictionary<string, string> colorTable = new Dictionary<string, string>();

            // 딕셔너리 추가
            colorTable.Add("Red", "빨간색");
            colorTable.Add("Orange", "주황색");
            colorTable.Add("Yellow", "노란색");
            colorTable.Add("Green", "초록색");

            foreach(var v in colorTable)
            {
                Console.WriteLine($"colorTable[{v.Key}] = {v.Value}");
            }

            //colorTable.Remove("Red"); // 추가되어 있는 키와 값을 지우면 아래 키와 값 추가 가능

            try
            {
                // 중복된 키에 값 입력
                colorTable.Add("Red", "빨강");
            }
            catch (ArgumentException e)
            {
                // "동일한 키를 사용하는 항목이 이미 추가되어 있다"는 메세지 출력
                Console.WriteLine(e.Message);
            }

            //colorTable.Add("Blue", "파랑색");  // 파랑색을 추가하면 찾을 수 있음

            try
            {
                // 없는 키 찾기
                Console.WriteLine($"Blue => {colorTable["Blue"]}");
            }
            catch (KeyNotFoundException e)
            {
                // "지정한 키가 Dictionary에 없다"는 메세지 출력
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"\n{colorTable["Red"]}");
            Console.WriteLine($"{colorTable["Orange"]}");
            Console.WriteLine($"{colorTable["Yellow"]}");
            Console.WriteLine($"{colorTable["Green"]}");
        }
    }
}
