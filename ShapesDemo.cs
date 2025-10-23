using System;
using static System.Console;
using System.Globalization;

namespace ShapesDemo
{
    public class Rectangle
    {
        private int height;
        private int width;
        private double area;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Area
        {
            get { return area; }
        }

        public Rectangle(int h, int w)
        {
            height = h;
            width = w;
        }

        public void ComputeArea()
        {
            area = height * width;
        }
    }

    public class Square
    {
        private int height;
        private int width;
        private double area;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Area
        {
            get { return area; }
        }

        public Square(int h, int w)
        {
            height = h;
            width = w;
        }

        public void ComputeArea()
        {
            area = height * width;
        }
    }

    public class Triangle
    {
        private int height;
        private int width;
        private double area;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Area
        {
            get { return area; }
        }

        public Triangle(int h, int w)
        {
            height = h;
            width = w;
        }

        public void ComputeArea()
        {
            area = 0.5 * height * width;
        }
    }

    public class ShapesDemo
    {
        public static void Main()
        {
            Rectangle r1 = new Rectangle(3, 4);
            ShapeCalc(r1);

            Square s1 = new Square(3, 4);
            ShapeCalc(s1);

            Triangle t1 = new Triangle(3, 4);
            ShapeCalc(t1);
        }

        static void ShapeCalc(object shape)
        {
            if (shape is Rectangle r)
            {
                r.ComputeArea();
                Console.WriteLine($"Rectangle area = {r.Area}");
            }
            else if (shape is Square s)
            {
                s.ComputeArea();
                Console.WriteLine($"Square area = {s.Area}");
            }
            else if (shape is Triangle t)
            {
                t.ComputeArea();
                Console.WriteLine($"Triangle area = {t.Area}");
            }
        }
    }
}
