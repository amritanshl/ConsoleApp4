using System;
using System.Collections.Generic;

namespace AmazonSystem
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
        void ShowReceipt();
    }
    public class CreditCardProcessor : IPaymentProcessor
    {
        public string TransactionId { get; private set; }

        public void ProcessPayment(double amount)
        {
            TransactionId = "CC-" + Guid.NewGuid().ToString().Substring(0, 8);
            Console.WriteLine($"[Credit Card] Processing ${amount}...");
            Console.WriteLine("Validating Card Details... Authorized!");
        }

        public void ShowReceipt()
        {
            Console.WriteLine($"Receipt: Paid via Credit Card. ID: {TransactionId}");
        }
    }
    public class PayPalProcessor : IPaymentProcessor
    {
        public string TransactionId { get; private set; }

        public void ProcessPayment(double amount)
        {
            TransactionId = "PP-" + Guid.NewGuid().ToString().Substring(0, 8);
            Console.WriteLine($"[PayPal] Redirecting to PayPal Sandbox for ${amount}...");
            Console.WriteLine("Login Successful... Payment Confirmed!");
        }

        public void ShowReceipt()
        {
            Console.WriteLine($"Receipt: Paid via PayPal Account. ID: {TransactionId}");
        }
    }
    public class AmazonCheckout
    {
        // Yahan interface ka asli power hai. 
        // Ye method kisi bhi payment type ko handle kar sakta hai (CreditCard ya PayPal).
        public void CompleteOrder(IPaymentProcessor paymentMethod, double totalAmount)
        {
            Console.WriteLine("\n--- Amazon Checkout Started ---");

            // Interface method call ho raha hai (Dynamic logic)
            paymentMethod.ProcessPayment(totalAmount);
            paymentMethod.ShowReceipt();

            Console.WriteLine("Order Status: Shipped! Thank you for shopping.");
            Console.WriteLine("--------------------------------\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AmazonCheckout amazon = new AmazonCheckout();

            // Customer 1: Credit Card use karna chahta hai
            IPaymentProcessor customer1Card = new CreditCardProcessor();
            amazon.CompleteOrder(customer1Card, 250.00);

            // Customer 2: PayPal use karna chahta hai
            IPaymentProcessor customer2PayPal = new PayPalProcessor();
            amazon.CompleteOrder(customer2PayPal, 45.99);

            // Technical Concept: Interface List
            // Hum saare transactions ka record ek hi list mein rakh sakte hain
            List<IPaymentProcessor> history = new List<IPaymentProcessor>();
            history.Add(customer1Card);
            history.Add(customer2PayPal);
        }
    }
}