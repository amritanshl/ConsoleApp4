//Add a simple method inside the struct that prints these dimensions.
//Hint: Even though it's a struct, it can still have methods just like a class!
//Sample Output: Eagle: Height 0.9m, Wingspan 2.3m.


enum AnimalGroup
{
    Mammal, 
    Bird, 
    Reptile, 
    Fish
}
enum FeedingStatus
{
    Hungry, 
    Eating, 
    Full
}
class Animal
{
    public string Name { get; set; }
    public AnimalGroup Group { get; set; }
}

class Dog
{
    public string Name { get;set; }
    public int Age { get; set; }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"New dog created: {Name}, Age {Age}.");
    }

}

class Cat
{
    public string Name { get; set; }
    public Cat()
    {
        Name = "Stray";
        Console.WriteLine($"You found a cat! Its name is: {Name}.");
    }
    public Cat(string name)
    {
        Name = name;
        Console.WriteLine($"You found a cat! Its name is: {Name}.");
    }
}

struct AnimalLocation
{
    public double X;
    public double Y;
    public AnimalLocation(double x,double y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static string EatingStatus(FeedingStatus fs)
    {
        switch (fs)
        {
            case FeedingStatus.Hungry:
                return "Hungry";
            case FeedingStatus.Eating:
                return "Eating";
            case FeedingStatus.Full:
                return "Full";
            default:
                return "Invalid";
        }

    }
    struct BirdSize
    {
        public double Height;
        public double WingSpan;

        public BirdSize(double height, double wingSpan) { 
            Height = height;
            WingSpan = wingSpan;
        }
        public void PrintSize(string birdName)
        {
            Console.WriteLine($"{birdName}: Height {Height}, Wingspan{WingSpan}.");
        }

    }

    static void Main(string[] args)
    {
        Animal animal = new Animal
        {
            Name="Lion",
            Group = AnimalGroup.Mammal
        };
        Console.WriteLine($"The {animal.Name} is a {animal.Group}");

        FeedingStatus status = FeedingStatus.Eating;
        Console.WriteLine($"The Penguin is currently: {EatingStatus(status)}");

        Dog puppy = new Dog("Buddy", 1);
        Console.WriteLine($"New dog created: {puppy.Name}, Age {puppy.Age}.");
        Cat cat = new Cat("Pheobe");

        AnimalLocation bird1 = new AnimalLocation(10, 20);
        AnimalLocation bird2 = new AnimalLocation(50, 50);
        Console.WriteLine($" Bird 1 at ({bird1.X}, {bird1.Y}). Bird 2 moved to ({bird2.X}, {bird2.Y})");
        BirdSize bird = new BirdSize(0.9, 2.3);
        bird.PrintSize("Eagle");

    }

}