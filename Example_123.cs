using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ 쿼리의 결과를 새로운 객체 컬렉션으로 저장하는 방법
namespace C__200_Example
{
    enum Examtype
    {
        국어,
        수학,
        영어
    }

    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }

    internal class Example_123
    {
        static List<Student> students;

        static void Main(string[] args)
        {
            students = new List<Student>
            {
                new Student { Name = "GwKim", Id = 19920914, Scores = new List<int> { 86,90,76} },
                new Student { Name = "DsKim", Id = 19900114, Scores = new List<int> { 66,93,56} },
                new Student { Name = "YjLee", Id = 19950211, Scores = new List<int> { 76,90,86} },
                new Student { Name = "YsKang", Id = 19931221, Scores = new List<int> { 56,70,96} }
            };

            // 모든 학생의 정보 출력
            Print(students);

            HighScore(Examtype.국어, 90);   // 국어 시험에서 90점이 넘는 학생 출력
            HighScore(Examtype.수학, 70);   // 수학 시험에서 70점이 넘는 학생 출력
            HighScore(Examtype.영어, 60);   // 영어 시험에서 60점이 넘는 학생 출력
        }

        // 최고점수 출력
        private static void HighScore(Examtype exam, int cut)
        {
            // 일정 점수 이상의 학생 확인
            var highScore = from student in students
                            where student.Scores[(int)exam] >= cut  // 점수 조건 확인
                            select new { Name = student.Name, Score = student.Scores[(int)exam] };  // 점수의 조건이 맞는 학생의 이름과 점수로 새로운 객체를 만들어 highScore 컬렉션에 저장

            Console.WriteLine($"\n<{exam} 시험에서 {cut} 이상의 점수를 받은 학생>");
            
            if (!highScore.Any())   // Any() : highScore에 요소가 하나라도 있는지 확인하는 메서드 
            {
                Console.WriteLine($"{cut} 이상의 점수를 받은 학생이 없습니다.");
            }

            foreach (var student in highScore)
            {
                Console.WriteLine($"\t{student.Name, -10}, {student.Score}");
            }

        }

        // 출력
        private static void Print(List<Student> students)
        {
            Console.WriteLine("[학생ID]  [이름]  [국어] [수학] [영어]   [평균]");

            foreach(Student student in students)
            {
                Console.Write($"{student.Id, -10}{student.Name, -10}");

                foreach(int score in student.Scores)
                {
                    Console.Write($"{score, -7}");
                }

                Console.WriteLine(student.Scores.Average().ToString("F2"));
            }
        }
    }
}
