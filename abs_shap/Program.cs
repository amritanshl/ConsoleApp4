using System;

namespace ShapesPro
{
    public interface IRotatable
    {
        void Rotate(int degrees);
    }

    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name) { Name = name; }

        // 1. ABSTRACT: No default code. Child MUST implement.
        public abstract double GetArea();

        // 2. VIRTUAL: Default code available. Child CAN override.
        // Humne ek default message set kiya hai resizing ke liye.
        public virtual void Resize(double factor)
        {
            Console.WriteLine($"[Default] Resizing {Name} by {factor}x.");
        }
    }

    // CASE 1: CIRCLE (Uses default Resize)
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r) : base("Circle") { Radius = r; }

        public override double GetArea() => Math.PI * Radius * Radius;

        // Resize ko override NAHI kiya -> Default wala chalega.
    }

    // CASE 2: SQUARE (Customizes Resize)
    public class Square : Shape, IRotatable
    {
        public double Side { get; set; }
        public Square(double s) : base("Square") { Side = s; }

        public override double GetArea() => Side * Side;

        // Resize ko OVERRIDE kiya -> Default wala cancel ho jayega.
        public override void Resize(double factor)
        {
            Side *= factor;
            Console.WriteLine($"[Custom] Square side updated to {Side}. Area is now {GetArea()}.");
        }

        public void Rotate(int degrees) => Console.WriteLine($"Rotating Square {degrees}°.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            // CIRCLE: Default Behavior
            Circle c = new Circle(5);
            c.Resize(2); // Output: [Default] Resizing...

            Console.WriteLine("---");

            // SQUARE: Custom Behavior
            Square s = new Square(10);
            s.Resize(1.5); // Output: [Custom] Square side updated...
            s.Rotate(45);

            Console.ReadKey();
        }
    }
}