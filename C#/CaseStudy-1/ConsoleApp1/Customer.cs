using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public string Name { get; set; }
    }

    // Derived class with extra property
    class PremiumCustomer : Customer
    {
        public double DiscountPercentage { get; set; } = 10.0;
    }

    class Programone
    {
        static void ApplyDiscount(Customer customer)
        {
            // Try casting to PremiumCustomer using 'as'
            PremiumCustomer premium = customer as PremiumCustomer;

            if (premium != null)
            {
                Console.WriteLine($"{customer.Name} is a Premium Customer and gets {premium.DiscountPercentage}% discount.");
            }
            else
            {
                Console.WriteLine($"{customer.Name} is a regular customer. No discount available.");
            }
        }

        static void Main(string[] args)
        {
            Customer cust1 = new PremiumCustomer { Name = "John" };
            Customer cust2 = new Customer { Name = "Emma" };

            ApplyDiscount(cust1);
            ApplyDiscount(cust2);


            int originalAmount = 1050; // e.g., $10.50 or ₹10.50

            // Convert to double for precise calculation (e.g., applying interest rate)
            double amountWithInterest = (double)originalAmount;

            // Apply 5.5% interest
            amountWithInterest = amountWithInterest * 1.055;

            // Convert back to int for display (rounded)
            int finalAmount = (int)Math.Round(amountWithInterest);

            // Output
            Console.WriteLine($"Original Amount: {originalAmount}");
            Console.WriteLine($"Amount with Interest (double): {amountWithInterest:F2}");
            Console.WriteLine($"Final Rounded Amount (int): {finalAmount}");



            ArrayList shoppingCart = new ArrayList();

            // Add item prices to the cart (boxing: int -> object)
            shoppingCart.Add(100);  // Boxed
            shoppingCart.Add(250);  // Boxed
            shoppingCart.Add(75);   // Boxed

            int total = 0;

            // Calculate total (unboxing: object -> int)
            foreach (object item in shoppingCart)
            {
                int price = (int)item; // Unboxing
                total += price;
            }

            Console.WriteLine($"Total Order Amount: {total}");
        }
    }
}
