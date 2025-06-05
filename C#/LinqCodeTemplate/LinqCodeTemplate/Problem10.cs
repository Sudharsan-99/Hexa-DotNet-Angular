using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem10
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var totalCount = products.Count();
            Console.WriteLine($"\nTotal Products Count: {totalCount}");

            Console.ReadLine();
        }
    }
}


