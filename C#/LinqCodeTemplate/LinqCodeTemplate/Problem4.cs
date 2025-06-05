using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem4
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var sortedByCategory = products.OrderBy(p => p.ProCategory);
            Console.WriteLine("\nSorted by Category:");
            foreach (var p in sortedByCategory)
                Console.WriteLine(p.ProName);

            Console.ReadLine();
        }
    }
}

