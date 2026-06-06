using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ, Group By로 데이터 분류
namespace C__200_Example
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }

    internal class Example_124
    {
        static List<Student> students;

        static void Main(string[] args)
        {
            students = new List<Student>{
                new Student { Name = "GwKim", Id = 19920914, Scores = new List<int> { 86,90,76} },
                new Student { Name = "DsKim", Id = 19900114, Scores = new List<int> { 66,93,56} },
                new Student { Name = "YjLee", Id = 19950211, Scores = new List<int> { 76,90,86} },
                new Student { Name = "YsKang", Id = 19931221, Scores = new List<int> { 56,70,96} }
            };

            var result = from student in students
                         group student by student.Scores.Average() >= 80 into g // 평균 점수를 80이상, 이하로 구분하여 그룹변수 g에 저장
                         select new
                         {
                             key = g.Key == true ? "80점 이상" : "80점 이하",
                             count = g.Count(),
                             average = g.Average(student => student.Scores.Average()),  // 각 학생의 평균점수의 평균을 저장
                             max = g.Max(student => student.Scores.Average())   // 각 학생의 평균점수에서 가장큰 평균점수 저장
                         };

            Print(students);

            foreach (var data in result)
            {
                Console.WriteLine($"{data.key} : 학생 수 = {data.count}");
                Console.WriteLine($"{data.key} : 평균 점수 = {data.average:F2}");
                Console.WriteLine($"{data.key} : 평균 최고 점수 = {data.max:F2}");
                Console.WriteLine();
            }
        }

        // 출력
        private static void Print(List<Student> students)
        {
            Console.WriteLine("[학생ID]  [이름]  [국어] [수학] [영어]   [평균]");

            foreach (Student student in students)
            {
                Console.Write($"{student.Id,-10}{student.Name,-10}");

                foreach (int score in student.Scores)
                {
                    Console.Write($"{score,-7}");
                }

                Console.WriteLine(student.Scores.Average().ToString("F2"));
            }

            Console.WriteLine();
        }
    }
}
