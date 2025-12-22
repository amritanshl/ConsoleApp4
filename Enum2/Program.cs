
//using System.Runtime.Intrinsics.X86;

//Question 2: Endangered Status Check
//Create an enum called ConservationStatus with values LeastConcern, Vulnerable, and Endangered. Write a method that takes this enum and returns a warning message.

//Hint: Use a switch statement to return different strings based on the status.

//Sample Output: Alert: The Red Panda is Endangered!
enum HabitatType
{
    Jungle, Ocean, Desert, Arctic
}
enum ConservationStatus
{
    LeastConcern, Vulnerable,  Endangered
}

class PrintMessage
{
    public string Name;
    public ConservationStatus status;

    public string PrintIt(ConservationStatus status)
    {
        switch (status) { 
        case ConservationStatus.LeastConcern:
                return "LeastConcern";
        case ConservationStatus.Endangered:
                return "Endangered";
        case ConservationStatus.Vulnerable:
                return "Vulnerable";
        
        default:
                return "Invalid";
        }
    }
}
class WildAnimal
{
    public string Name { get; set; }
    public HabitatType Habitat{ get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        WildAnimal wildAnimal = new WildAnimal();
        wildAnimal.Name = "Polar Bear";
        wildAnimal.Habitat = HabitatType.Arctic;

        Console.WriteLine($"The {wildAnimal.Name} lives in the {wildAnimal.Habitat}.");

        ConservationStatus status = ConservationStatus.Endangered;
        Console.WriteLine($"Alert: The Red Panda is {status}!");
    }
}