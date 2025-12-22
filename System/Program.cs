using System.Security.Cryptography;

namespace utitlitySystem
{
    public class accessSystem
    {
        public void publicM()
        {
            Console.WriteLine("Public Method");
        }

        internal void internalM()
        {
            Console.WriteLine("Internal Method");

        }

        protected void protectedM()
        {
            Console.WriteLine("Protected Method");
        }
        protected void _privateM()
        {
            Console.WriteLine("Private Method");
        }

    }
    public class accessSystem2 : accessSystem { 
        public void TestAccess()
        {
            publicM();
            internalM();
            protectedM();
            //_privateM();
        }
    }
}