using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem5
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var sortedByMrpAsc = products.OrderBy(p => p.ProMrp);
            Console.WriteLine("\nSorted by Mrp Ascending:");
            foreach (var p in sortedByMrpAsc)
                Console.WriteLine($"{p.ProName} - Rs.{p.ProMrp}");

            Console.ReadLine();
        }
    }
}

