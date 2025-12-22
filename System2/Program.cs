using System;
using utitlitySystem;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            accessSystem system = new accessSystem();
            system.publicM();
           
        }
        class childClass : accessSystem2 { 
        public void accesstest()
            {
                publicM();
                protectedM();
            }
        }
    }
}