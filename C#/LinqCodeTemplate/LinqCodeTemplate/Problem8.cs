using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem8
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var groupByMrp = products.GroupBy(p => p.ProMrp);
            Console.WriteLine("\nGrouped by Mrp:");
            foreach (var group in groupByMrp)
            {
                Console.WriteLine($"Rs.{group.Key}:");
                foreach (var p in group)
                    Console.WriteLine($"  {p.ProName}");
            }

            Console.ReadLine();
        }
    }
}
