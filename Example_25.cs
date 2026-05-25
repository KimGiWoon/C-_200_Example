using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // String 클래스
    internal class Example_25
    {
        static void Main(string[] args)
        {
            string s = " Hello, World!!!!!! ";
            string m = "bbc";
            string t;

            Console.WriteLine(s.Length);                            // 문자열의 길이 확인
            Console.WriteLine(s[8]);                                // 8번째 문자 확인
            Console.WriteLine(s.Insert(8, "C# "));                  // 8번째에 해당 문자를 삽입
            Console.WriteLine(s.PadLeft(20, '.'));                  // 앞에 해당 문자을 길이 만큼 삽입
            Console.WriteLine(s.PadRight(20, '.'));                 // 뒤에 해당 문자을 길이 만큼 삽입
            Console.WriteLine(s.Remove(6));                         // 6번째 인덱스 부터 끝까지 삭제
            Console.WriteLine(s.Remove(6, 7));                      // 6번째 인덱스 부터 7개 문자 삭제
            Console.WriteLine(s.Replace('l', 'm'));                 // 'l'을 'm'으로 변경
            Console.WriteLine(s.ToLower());                         // 문자열을 소문자로 변경
            Console.WriteLine(s.ToUpper());                         // 문자열을 대문자로 변경
            Console.WriteLine('/' + s.Trim() + '/');                // 문자열의 앞뒤 공백을 삭제
            Console.WriteLine('/' + s.TrimStart() + '/');           // 문자열의 앞 공백 삭제
            Console.WriteLine('/' + s.TrimEnd() + '/');             // 문자열의 뒤 공백 삭제

            string[] a = s.Split(',');                              // ','를 구분하여 배열 생성

            foreach(var i in a)
            {
                Console.WriteLine('/' + i + '/');
            }

            char[] destination = new char[10];                      
            s.CopyTo(8, destination, 0, 2);                         // 문자열 복사
            Console.WriteLine(destination);
            Console.WriteLine('/' + s.Substring(8) + '/');          // 8번째 인덱스 부터 맨 뒤 문자까지 반환
            Console.WriteLine('/' + s.Substring(8, 5) + '/');       // 8번째 인데스 부터 5번째 까지 문자 반환
                
            Console.WriteLine(s.Contains("ll"));                    // "ll" 찾아서 있으면 true, false 반환
            Console.WriteLine(s.IndexOf('o'));                      // 맨 앞에서 'o'문자의 인덱스
            Console.WriteLine(s.LastIndexOf('o'));                  // 맨 뒤에서 'o'문자의 인덱스
            Console.WriteLine(s.CompareTo("abc"));                  // 문자 하나씩 사전식으로 비교하여 작으면 -1, 같으면 0, 크면 1 반환

            Console.WriteLine(String.Concat("Hi~", s));             // 두개의 문자열을 합치기
            Console.WriteLine(String.Compare("abc", s));            // 문자 하나씩 사전식으로 비교하여 작으면 -1, 같으면 0, 크면 1 반환

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(", ", val);                 // 배열의 각 요소를 ", "으로 연결하여 반환
            Console.WriteLine(result);
        }
    }
}
