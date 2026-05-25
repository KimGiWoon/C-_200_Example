using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__200_Example
{
    // 클래스의 멤버 변수, 정적 변수와 상수

    // 일반 멤버 변수를 가진 클래스
    class Product
    {
        public string name;
        public int price;
    }

    // 정적 멤버 변수를 가진 클래스
    class MyMath
    {
        public static double PI = 3.14;
    }

    // 상수를 가진 클래스
    class MyCalendar
    {
        // 상수는 선언 후 반드시 초기화를 해야하며 초기화된 값을 변경할 수 없다
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / weeks; // 한 주 평균 일수
        public const double daysPerMonth = (double)days / months;   // 한 달 평균 일수
    }

    internal class Example_66
    {
        static void Main(string[] args)
        {
            // Product 객체 생성
            Product product = new Product();

            // 객체에 값 저장
            product.name = "시계";
            product.price = 100000;

            // 일반 멤버 필드는 객체 생성하고 이름으로 접근
            Console.WriteLine($"{product.name} : {product.price:C}");

            // static 필드는 객체를 생성하지 않고 클래스 이름으로 접근 가능함
            Console.WriteLine($"원주율 : {MyMath.PI}");

            // const 상수도 객체를 생성하지 않고 클래스 이름으로 접근 가능함
            Console.WriteLine($"한 달은 평균 : {MyCalendar.daysPerMonth:F3}일 입니다.");
        }
    }
}
