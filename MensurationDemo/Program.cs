using System;


public enum MeasurementUnit { Millimeters, Centimeters, Meters, Inches }


public struct Position
{
    public double X, Y;
    public Position(double x, double y) {  X = x; Y = y; }
   
}


public interface IVolumeCalculatable
{
   double CalculateVolume();
}

public abstract class Shape
{
    public string Name { get; set; }  
    public MeasurementUnit Unit { get; set; }

    public Position Origin { get; set; }



    public Shape(string name, MeasurementUnit unit, Position origin)
    {

        Name = name;
        Unit = unit;
        Origin = origin;
        
    }

    
    public abstract double CalculateArea();

    
    public void PrintMetadata()
    {
        Console.WriteLine($"Name: {Name} | Unit: {Unit} | Origin ({Origin.X}, {Origin.Y})");
    }
}

public class Cylinder : Shape, IVolumeCalculatable
{
    public double Radius { get; set; }  
    public double Height { get; set; }
    public Cylinder(string name, MeasurementUnit unit, Position origin, double radius, double height): base (name, unit,origin )
    {
        Radius = radius;
        Height = height;

    }

   


    public override double CalculateArea()
    {
       
        return 2 * Math.PI* Radius* (Radius+Height);
    }


    public double CalculateVolume()
    {

        return Math.PI * Math.Pow(Radius,2)*Height;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
       {
           new Cylinder("Cylinder", MeasurementUnit.Centimeters, new Position(0,0),10,5)
       };

        foreach (var shape in shapes) { 
            shape.PrintMetadata();
            Console.WriteLine($"Volume: {shape.CalculateArea()}");
            if (shape is IVolumeCalculatable a)
            {
               
                Console.WriteLine($"Volumen is : {a.CalculateVolume()} ");
            }
        }

        



    }
}