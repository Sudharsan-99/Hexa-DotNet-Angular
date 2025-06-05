using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem12
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var maxPrice = products.Max(p => p.ProMrp);
            Console.WriteLine($"Max Price: Rs.{maxPrice}");

            Console.ReadLine();
        }
    }
}

