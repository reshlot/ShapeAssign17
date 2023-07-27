using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAss17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Shape Hierarchy***\n");

            Circle circle = new Circle(5);
            circle.PrintInfo();
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.PrintInfo();
            Console.WriteLine();


            Triangle triangle = new Triangle(3, 4, 5);
            triangle.PrintInfo();
            Console.ReadKey();
        }


    }
}
