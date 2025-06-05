using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem9
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var highestFmcg = products
                .Where(p => p.ProCategory == "FMCG")
                .OrderByDescending(p => p.ProMrp)
                .FirstOrDefault();

            Console.WriteLine("\nHighest Priced FMCG Product:");
            if (highestFmcg != null)
                Console.WriteLine($"{highestFmcg.ProName} - Rs.{highestFmcg.ProMrp}");

            Console.ReadLine();
        }
    }
}

