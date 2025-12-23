using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Models.Customer
{
    public partial class Customer
    {

        public void ShowAccountInfo()
        {
            string cardNumer = _creditCardDetail;
            Console.WriteLine($"Customer: {Email} | Payment {cardNumer}");
        }
    }
}
