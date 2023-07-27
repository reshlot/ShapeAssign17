using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAss17
{//Base class
    public  class Shape
    {
        public string ShapeType { get; set; }

        public virtual double Area { get; }
        public virtual double Perimeter { get; }

        public Shape(string shapeType)
        {
            ShapeType = shapeType;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
