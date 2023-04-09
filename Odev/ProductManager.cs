using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.name + " eklendi.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.name + " silindi");
        }
    }
}
