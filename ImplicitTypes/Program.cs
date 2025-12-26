//using System.Collections;

//ArrayList list = new ArrayList();

//list.Add(154);
//list.Add("Hello");

//int num = (int)list[1];

//List<int> list2 = new();
//list2.Add(44);
////list2.Add("hello");

//Hashtable ht = new Hashtable();
//ht["id"] = 4545;

//Dictionary<string, int> dict = new();

//Queue q  = new Queue();
//Queue<string> q2 = new();

//Stack s = new Stack();
//Stack<string> stack = new Stack<string>();


using System.Collections;
using static DBT_collection.Program;
namespace DBT_collection;

class Program
{

    public class dataex
    {
        public int id {  get; set; }
    }
    public class Box<T> { 
    public T x {  get; set; }
        public void Display()
        {

            Console.WriteLine($"{x}");
        }
    }

    public class DataResult<T,H>
    {
        public bool IsActive {  get; set; }
        public string Message {  get; set; }

        public T Value { get; set; }
       public H ValueH { get; set; }


        public void Display2<E>(int num, E item)
        {
            Console.WriteLine($"Number {num} Generic type {item}");
            Console.WriteLine($"{Value}");
        }

    }

    static void Main(string[] args)
    {
        ArrayListvList();
        List<dataex> data1 = new List<dataex>();
        data1.Add(new dataex { id = 454 });


        Box<int> boxint = new Box<int>();
        boxint.x = 100;
        Box<string> boxstr = new Box<string>();
        boxstr.x = "Hello";
        boxint.Display();
        boxstr.Display();

        DataResult<int,string> di = new DataResult<int,string>()
        {
            IsActive = true,
            Message = "for int",
            Value = 1003534,
            ValueH = "hello35434"
        };
        DataResult<string, int> ds = new DataResult<string, int>()
        {
            IsActive = true,
            Message = "for int",
            Value = "Hello3453",
            ValueH = 8418

        };

        di.Display2(55,"my string");
        ds.Display2(875,678);
        ds.Display2(875,true);
        ds.Display2(875,45.55m);
        ds.Display2(875,DateTime.UtcNow);
    }
     
    static void ArrayListvList()
    {
        ArrayList oldList = new ArrayList {10,20,36 };
        int value1 = (int)oldList[1];

        List<int> list = new List<int>();
        list.Add(55);
        list.Add(558);
        int lisval = list[1];

    }

    static void example()
    {

        
        //List<string> animals = ["Dog", "cat", "lion", "tiger", "Dog"];
        //IEnumerable<string> strings = animals.ToList();
        //animals[2] = "Jaguar";
        //foreach (string animal in animals) { 
        
        //}
        //animals.Count();

        //List<double> lisnt = [5, 12, 8, 20, 3];
        //lisnt.Sort();
        ////lisnt.Reverse();

        //public class sample<T> { 
        //List<T> list = new List<T>()
        //{     

        //};
      
    }

}