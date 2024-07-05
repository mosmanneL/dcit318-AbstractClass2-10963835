using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{ // Abstract class
    abstract class Shape
    {
        // Abstract method
        public abstract double GetArea();
    }

    // Derived class
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementing the abstract method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Another derived class
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing the abstract method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 7);

            // Display the areas
            Console.WriteLine($"Area of the circle: {circle.GetArea()}");     // Output: Area of the circle: 78.53981633974483
            Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}"); // Output: Area of the rectangle: 28
        }
    }
}
