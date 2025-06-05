using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Problem15
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var anyBelow30 = products.Any(p => p.ProMrp < 30);
            Console.WriteLine($"Are any products below Rs.30: {anyBelow30}");

            Console.ReadLine();
        }
    }
}
