using System;

namespace AbstractionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(400);
            
            Shape circle = new Circle(7);


            Console.WriteLine("Square: " + square.GetArea());
            Console.WriteLine("Circle: " + circle.GetArea());
        }
    }
}
