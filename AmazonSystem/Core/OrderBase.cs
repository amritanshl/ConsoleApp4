using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Core
{
    public interface ITrackable
    {
        void UpdateTrackingStatus(string status);
    }
    public abstract class OrderBase
    {
        public static int TotalOrderProcessed = 0;
        protected string _orderId { get; set; }
        public string CusomterName { get; set; }
        public double Amount { get; set; }

        public OrderBase(string customerName,  double amount)
        {
            CusomterName = customerName;    
            Amount = amount;
            _orderId = "Amazon--"+Guid.NewGuid().ToString()+DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss");
        }

        public abstract void Deliver();
        
    }
}
