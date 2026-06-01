using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로퍼티 (속성)
namespace C__200_Example
{
    class Rectangle1
    {
        private double _width;
        private double _height;

        // Width 값을 가져오는 메서드
        public double GetWidth()
        {
            return _width;
        }

        // Height 값을 가져오는 메서드
        public double GetHeight()
        {
            return _height;
        }

        // Width 변수에 값을 저장하는 메서드
        public void SetWidth(double value)
        {
            if (value > 0)
            {
                _width = value;
            }
            else
            {
                _width = 0;
            }
        }

        // Height 변수에 값을 저장하는 메서드
        public void SetHeight(double value)
        {
            if (value > 0)
            {
                _height = value;
            }
            else
            {
                _height = 0;
            }
        }
    }

    class Rectangle2
    {
        public double Width { get; set; }   // Width 값을 읽고 쓰는 자동 구현 프로퍼티
        public double Height { get; set; }  // Height 값을 읽고 쓰는 자동 구현 프로퍼티
    }

    class Rectangle3
    {
        private double _width;
        private double _height;

        public double Width { get { return _width; } set { _width = value; } }
        public double Height { get { return _height; } set { _height = value; } }
    }

    internal class Example_69
    {
        static void Main(string[] args)
        {
            double _width = 10;
            double _height = 10;

            // 1번 직사각형 객체 생성 후 메서드로 데이터 저장
            Rectangle1 rectangle1 = new Rectangle1();
            rectangle1.SetWidth(_width);
            rectangle1.SetHeight(_height);

            // 2번 직사각형 객체 생성 후 자동 구현 프로퍼티로 데이터 저장
            Rectangle2 rectangle2 = new Rectangle2();
            rectangle2.Width = _width + 10;
            rectangle2.Height = _height + 10;

            // 3번 직사각형 객체 생성 후 직접 구현 프로퍼티로 데이터 저장
            Rectangle3 rectangle3 = new Rectangle3();
            rectangle3.Width = _width + 20;
            rectangle3.Height = _height + 20;

            // 1번 직사각형의 면적 출력
            RectangleArea(rectangle1.GetWidth(), rectangle1.GetHeight());
            // 2번 직사각형의 면적 출력
            RectangleArea(rectangle2.Width, rectangle2.Height);
            // 3번 직사각형의 면적 출력
            RectangleArea(rectangle3.Width, rectangle3.Height);
        }

        // 직사각형의 면적 출력 메서드
        private static void RectangleArea(double width, double height)
        {
            Console.WriteLine($"직사각형의 면적은 너비({width}) 곱하기 높이({height}) = {width * height} 입니다.");
        }
    }
}
