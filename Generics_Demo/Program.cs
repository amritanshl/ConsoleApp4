using System.ComponentModel;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericDemo;

class program {
   
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
  
public static class Swapping
    {
        public static void Swap<T>(ref T a,  ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

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
    
public static class Inspector
    {
        public static void Inspect<T>(T item)
        {
            Console.WriteLine($"Value: {item} is type {item.GetType().Name}");
        }
    }

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

