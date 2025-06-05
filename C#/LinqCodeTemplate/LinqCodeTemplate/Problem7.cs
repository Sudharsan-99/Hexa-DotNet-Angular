using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem7
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var groupByCategory = products.GroupBy(p => p.ProCategory);
            Console.WriteLine("\nGrouped by Category:");
            foreach (var group in groupByCategory)
            {
                Console.WriteLine($"{group.Key}:");
                foreach (var p in group)
                    Console.WriteLine($"  {p.ProName}");
            }

            Console.ReadLine();
        }
    }
}

