using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem6
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var sortedByMrpDesc = products.OrderByDescending(p => p.ProMrp);
            Console.WriteLine("\nSorted by Mrp Descending:");
            foreach (var p in sortedByMrpDesc)
                Console.WriteLine($"{p.ProName} - Rs.{p.ProMrp}");

            Console.ReadLine();
        }
    }
}

