using AmazonSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Models.Customer
{
    public class PhysicalProduct: OrderBase,ITrackable
    {

        public double Weight { get; set; }
        public PhysicalProduct(string name,double amount, double weight): base(name,amount)
        {
            Weight=weight;
        }

        public override void Deliver()
        {
            Console.WriteLine($"Weight {Weight} of order by customer {CusomterName}");
        }
        public void UpdateTrackingStatus(string status)
        {
            Console.WriteLine($"Order: {_orderId} with Delivery {status}");
        }
    }
}
