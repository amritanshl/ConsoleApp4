using AmazonSystem.Core;
using AmazonSystem.Models;
using AmazonSystem.Models.Customer;

namespace AmazonSystem.App
{


    class Program
    {
        static void Main(string[] args)
        {
            Customer customer   = new Customer("amrit@microsoft.com", "9876542121252");
            customer.ShowAccountInfo();
                
        }
    }
}