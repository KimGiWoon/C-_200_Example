using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 람다식의 사용 (식 람다식 : 연산자 뒤에 조건식, 문 람다식 : 연산자 뒤에 문자 블록)
namespace C__200_Example
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Example_117
    {
        delegate double CalcMethod(double a, double b); // 나이 계산 델리게이트
        delegate bool IsTeenAger(Student student);  // 10대 확인 델리케이트
        delegate bool IsAdult(Student student); // 성인 확인 델리게이트

        static void Main(string[] args)
        {
            // 학생 정보 생성
            Student student1 = new Student() { Name = "기운", Age = 17 };
            Student student2 = new Student() { Name = "찰스", Age = 25 };
            Student student3 = new Student() { Name = "동수", Age = 29 };

            Func<int, int> square = x => x * x; // 제곱수를 구하는 Func 델리게이트

            Console.WriteLine(square(5));

            int[] numbers = { 2, 3, 4, 5, 6, };
            var squareNumbers = numbers.Select(x => x * x); // numbers의 각 요소를 제곱한 결과를 반환
            Console.WriteLine(string.Join(" ", squareNumbers));

            Action line = () => Console.WriteLine();    // 빈줄 Action 델리게이트
            line();

            CalcMethod add = (a, b) => a + b;   // 더하기 CalcMethod 델리게이트
            CalcMethod subtract = (a, b) => a - b;  // 빼기 CalcMethod 델리게이트

            Console.WriteLine(add(10, 20));
            Console.WriteLine(subtract(10.5, 20));

            IsTeenAger isteen = delegate (Student student) { return student.Age > 12 && student.Age < 20; };    // 무명메서드 방식

            Console.WriteLine("{0}은/는 {1}", student1.Name, isteen(student1) ? "청소년입니다." : "청소년이 아닙니다.");

            IsAdult isAdult = student => { int adultAge = 18; return student.Age >= adultAge; };    // 문 람다식 방식
            IsAdult isAdult2 = student => student.Age >= 18;    // 식 람다식 방식

            Console.WriteLine("{0}은/는 {1}", student2.Name, isAdult(student2) ? "성인입니다." : "성인이 아닙니다.");
            Console.WriteLine("{0}은/는 {1}", student3.Name, isAdult2(student3) ? "성인입니다." : "성인이 아닙니다.");
        }
    }
}
