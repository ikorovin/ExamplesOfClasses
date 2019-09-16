using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "nintendo.switch";
            product.Price = 299.99M;
            Console.WriteLine($"{product.Name} ${product.Price}");
            Console.ReadLine();
        }
    }
}
