using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 배열과 객체를 메서드 매개변수로 전달
    class Student
    {
        public string name;
    }

    internal class Example_35
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine($"Main() before : arr[0] = {arr[0]}");
            Change(arr);
            Console.WriteLine($"Main() after : arr[0] = {arr[0]}");

            Student s1 = new Student();
            s1.name = "철수";

            // 참조 형식이라 힙에 있는 배열, 클래스 객체의 참조값을 복사

            Console.WriteLine($"Main() before : s1 name = {s1.name}");
            Change(s1);
            Console.WriteLine($"Main() after : s1 name = {s1.name}");
        }

        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private static void Change(Student s1)
        {
            s1.name = "동수";
        }
    }
}
