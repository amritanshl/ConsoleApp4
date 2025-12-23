namespace AbastactClassDemo { 

    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"{Name} is selected");
        }

        public abstract double Area();
        //public abstract string shape();

        



    }
    public class Circle: Shape
        {
            public double Radius {  get; set; }
            //public string name { get; set; }
            
            public Circle(double radius, string name): base(name) 
        {
            Radius = radius;
        }

        public override double Area() { 
            return Radius*3.14;
        }


        }


    public class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length, string name) : base(name) { 
            Width = width;
            Length = length;
        }
        public override double Area()
        {
            return Width * Length;
        }

    
    }
}