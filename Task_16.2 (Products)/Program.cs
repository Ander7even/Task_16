using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Task_16._2__Products_
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../products.json"))
            {
                jsonString = sr.ReadToEnd();

            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.Price > maxProduct.Price)
                {
                    maxProduct = p;
                }

            }
            Console.WriteLine($"{maxProduct.Code} {maxProduct.Name} {maxProduct.Price}");
            Console.ReadKey();

        }
    }
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }

}
