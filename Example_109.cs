using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stack<T>와 Polish 계산기
namespace C__200_Example
{
    internal class Example_109
    {
        // 후위 표기법(Reverse Polish Notation, RPN) 계산 방식 : 연산자를 피연산자 뒤에 배치하는 표기법

        static void Main(string[] args)
        {
            Console.Write("계산할 수식을 Polish 표기법으로 입력하세요 : ");
            string[] tokens = Console.ReadLine().Split();

            foreach(string token in tokens)
            {
                Console.Write($" {token}");
            }
            Console.Write(" = ");

            // Stack 컬렉션 객체 생성
            Stack<double> stack = new Stack<double>();

            foreach(string token in tokens)
            {
                // 연산자 확인
                if (isOperator(token))
                {
                    switch (token)
                    {
                        case "+":
                            stack.Push(stack.Pop() + stack.Pop());  // 숫자 2개를 꺼내 더한 후 Stack에 저장
                            break;
                        case "-":
                            stack.Push(-(stack.Pop() - stack.Pop()));   // 숫자 2개를 꺼내 뺀 후 Stack에 저장, Pop 순서 때문에 계산 순서를 맞추기 위해 부호를 반대로 처리
                            break;
                        case "*":
                            stack.Push(stack.Pop() * stack.Pop());  // 숫자 2개를 꺼내 곱한 후 Stack에 저장
                            break;
                        case "/":
                            stack.Push(1.0/(stack.Pop() / stack.Pop())); // 숫자 2개를 꺼내 나눈 후 Stack에 저장, Pop 순서 때문에 계산 순서를 맞추기 위해 역수 형태로 처리
                            break;
                    }
                }
                else
                {
                    stack.Push(double.Parse(token));
                }
            }

            // 결과 출력
            Console.WriteLine(stack.Pop());
        }

        // 연산자인지 확인 
        private static bool isOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
