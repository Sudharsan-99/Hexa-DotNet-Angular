using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem2
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            Console.WriteLine("\nGrain Products:");
            foreach (var p in products.Where(p => p.ProCategory == "Grain"))
                Console.WriteLine(p.ProName);

            Console.ReadLine();
        }
    }
}

