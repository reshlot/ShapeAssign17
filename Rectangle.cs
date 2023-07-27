using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAss17
{
    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
        }
    }
}
