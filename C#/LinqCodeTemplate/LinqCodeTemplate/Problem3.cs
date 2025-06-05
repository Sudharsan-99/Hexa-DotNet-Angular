using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem3
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var sortedByCode = products.OrderBy(p => p.ProCode);
            Console.WriteLine("\nSorted by Product Code:");
            foreach (var p in sortedByCode)
                Console.WriteLine(p.ProName);

            Console.ReadLine();
        }
    }
}

