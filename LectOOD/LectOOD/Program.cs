using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LectOOD
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle();
            Circle c2 = new Circle(2.0);
            Circle c3 = new Circle(3.0, "blue");

            Console.WriteLine("The radius of c1 is " + c1.getRadius() + " and area is " + c1.getArea() + ", The color is " + c1.getColor());

            Console.WriteLine("The radius of c2 is " + c2.getRadius() + " and area is " + c2.getArea() + ", The color is " + c2.getColor());

            Console.WriteLine("The radius of c3 is " + c3.getRadius() + " and area is " + c3.getArea() + ", The color is " + c3.getColor());

        }
    }
}
