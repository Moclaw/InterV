using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", ID, Name, Price);
        }
        public static List<Product> Brand
        {
            get
            {
                return new List<Product>
                {
                    new Product { ID = 1, Name = "some", Price = 5000 },
                    new Product { ID = 2, Name = "some1", Price = 6000 },
                    new Product { ID = 3, Name = "some2", Price = 8000 },
                    new Product { ID = 4, Name = "some3", Price = 5000},
                    new Product { ID = 5, Name = "some4", Price = 1000 },
                    new Product { ID = 6, Name = "some5", Price = 4000 },

                };
            }
        }

    }
    public static class Brand
    {
        public static IEnumerable<T> MyQuery<T>(this IEnumerable<T> list, Func<T, bool> myCondition)
        {
            foreach (var item in list)
            {
                if (myCondition(item)) yield return item;
            }    
        }    
    }
    class Program
    {
        static void Main()
        {
            var brand = Product.Brand;
            var list = brand.MyQuery(f => f.Price >= 6000);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}