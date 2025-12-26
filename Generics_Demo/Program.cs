using System.ComponentModel;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericDemo;
//1.The "Dual Holder"(Generic Class)
//Goal: Create a class that holds two variables of different types.
class program {
    // TODO: Define a class named 'DualHolder' with two generic types <T1, T2>.
public class DualHolder<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public DualHolder(T1 item1, T2 item2) { 
            Item1 = item1;
            Item2 = item2;
        }
        public void Show()
        {
            Console.WriteLine($"Item 1: {Item1}");
            Console.WriteLine($"Item 2: {Item2}");
        }
    }
        
  

// TODO: Define a static void method 'Swap' with one generic type <T>.

public static class Swapping
    {
        public static void Swap<T>(ref T a,  ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
   
// TODO: Define a class 'Triple' with one generic type <T>.
public class Triple<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
        public T Third { get; set; }

        public Triple(T first, T second, T third) { 
            First = first; Second = second; Third = third;
        
        }
        public void PrintAll()
        {
            Console.WriteLine($"{First}: {Second} : {Third}");
        }



    }
    // SAMPLE INPUT: 
    // var nums = new Triple<int>(1, 5, 9);
    // nums.PrintAll();

    // SAMPLE OUTPUT:
    // 1, 5, 9



// TODO: Define a static void method 'Inspect' with one generic type <T>.
public static class Inspector
    {
        public static void Inspect<T>(T item)
        {
            Console.WriteLine($"Value: {item} is type {item.GetType().Name}");
        }
    }
    // SAMPLE INPUT: 
    // Inspect(45.5);
    // Inspect("Hello");

    // SAMPLE OUTPUT:
    // Value: 45.5 is type Double
    // Value: Hello is type String

public static class Checker
    {
        public static void CheckEqual<T>(T a, T b)
        {
            if (EqualityComparer<T>.Default.Equals(a, b))
            {
                Console.WriteLine("Equal");
            }
            else {
                Console.WriteLine("Not equal");
            }
        }
    }

// SAMPLE INPUT: 
// CheckEqual(10, 10);
// CheckEqual(10, 5);

// SAMPLE OUTPUT:
// Equal
// Not Equal

public static class Generator
    {
        public static T GetDefault<T>()
        {
            return default(T);
        }


    }

public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; } 
        public Result(bool success, T data) { Success = success; Data = data; }
    }



//8. The "Array Printer" (Generic Method)
//Goal: Loop through an array of any type and print the elements.

    public static class Printer
    {
        public static void PrintArray<T>(T[] items)
        {
            foreach(var item in items)
            {
                Console.WriteLine($"{item}");

            }
            Console.WriteLine();
        }
    }
// TODO: Define a static void method 'PrintArray' with type <T>.
// TODO: Accept a parameter 'T[] items'.
// TODO: Use a foreach loop to print each item followed by a comma.

// SAMPLE INPUT: 
// string[] names = { "Sam", "Joe" };
// PrintArray(names);

// SAMPLE OUTPUT:
// Sam, Joe,

// SAMPLE INPUT: 
// var res = new Result<string>(true, "File Found");
// Console.WriteLine(res.Success + " - " + res.Data);

// SAMPLE OUTPUT:
// True - File Found
// TODO: Define a static method 'GetDefault' that returns type T.
// TODO: The method takes no parameters.
// TODO: It should return 'default(T)'.

// SAMPLE INPUT: 
// int i = GetDefault<int>();
// bool b = GetDefault<bool>();
// Console.WriteLine($"Int: {i}, Bool: {b}");

// SAMPLE OUTPUT:
// Int: 0, Bool: False

public static void Main() { 
        var holder1 = new DualHolder<string, int>("Age", 30);
        holder1.Show();


        int x=10, y=20;
        Swapping.Swap(ref x, ref y);
        Console.WriteLine($"x={x}, y={y}");

        var nums = new Triple<int>(1, 5, 9);
        nums.PrintAll();

        Inspector.Inspect(45.5);

        Checker.CheckEqual(15, 66);
        Checker.CheckEqual(66, 66);

        int i = Generator.GetDefault<int>(); 
        bool b = Generator.GetDefault<bool>();
        Console.WriteLine($"Int: {i}, Bool: {b}");

       var res = new Result<string>(true, "File Found");
       Console.WriteLine(res.Success + " - " + res.Data);


        string[] names = { "Sam", "Joe" };
       Printer.PrintArray(names);
    }

}

