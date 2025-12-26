namespace sample
{

    class Program
    {

        public static bool isEven (int x)
        {
            return x % 2 == 0;
        }
       
        static void Display(string message)
        {
            Console.WriteLine(message); 
        }
        public static void Main(string[] args)
        {
            //
            Display("Name");
            Func<int, int,int, int> sum = (x, y,z) => x + y+z;
            Func<string,string> p = p=>$"p";
            Func<int,bool> e = e=>e%2==0 ;
            
            var numbers = new List<int> { 12,2,62,65,6916,964} ;
            var evenNumb = numbers.Where(n=>n%2==0).ToList() ;
            Func<int, int> n = n =>
            {
                Console.WriteLine(n);
                return n*10;

            };

            Action<string> mymsg = name => Console.WriteLine(name);
            mymsg("how are you ");

            int counter = 0 ;

            Action increment = () => counter++;




        }
    }
}