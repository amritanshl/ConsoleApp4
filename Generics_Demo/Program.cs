using System.Collections;

Console.WriteLine("--- Legacy ArrayList Demo ---");

// 1. Initialize ArrayList
ArrayList legacyList = new ArrayList();

// 2. Adding different types (Compiler allows this)
legacyList.Add(10);        // Int (Boxed)
legacyList.Add(20);        // Int (Boxed)
legacyList.Add("Oops!");   // String (Reference type)

Console.WriteLine($"Items in list: {legacyList.Count}");

try
{
    // 3. Attempting to process data
    foreach (object obj in legacyList)
    {
        // Explicit casting is REQUIRED because items are 'object'
        int value = (int)obj;
        Console.WriteLine($"Value squared: {value * value}");
    }
}
catch (InvalidCastException ex)
{
    Console.WriteLine("\n[RUNTIME ERROR DETECTED]");
    Console.WriteLine($"Message: Cannot cast '{legacyList[2]}' to an integer.");
    Console.WriteLine($"Exception: {ex.GetType().Name}");
}



string[] names = { "Alice", "Bob", "Charlie" };

// 1. The standard way we write code
Console.WriteLine("--- Standard Foreach ---");
foreach (var name in names)
{
    Console.WriteLine(name);
}

// 2. What the compiler actually does (Under the hood)
Console.WriteLine("\n--- Under the Hood ---");
IEnumerator enumerator = names.GetEnumerator();
try
{
    while (enumerator.MoveNext()) // Moves to the next item
    {
        string currentName = (string)enumerator.Current; // Accesses current item
        Console.WriteLine(currentName);
    }
}
finally
{
    // If the enumerator implements IDisposable, it is cleaned up here
    if (enumerator is IDisposable disposable) disposable.Dispose();
}