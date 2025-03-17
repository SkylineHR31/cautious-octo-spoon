using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15._1
{
    class Carrot : Product
    {
        public Carrot(double basePrice) : base(name: "Carrot", basePrice) { }
    }

    class Tomato : Product
    {
        public Tomato(double basePrice) : base(name: "Tomato", basePrice) { }
    }

    class Potato : Product
    {
        public double Count { get; }
        public override double Price => GetBasePrice() * Count;

        public Potato(double basePrice, double count) : base(name: "Potato", basePrice)
        {
            Count = count;
        }

        public override string GetInfo()
        {
            return $"Product: {Name}, Price per kg: {GetBasePrice()}, Count: {Count}, Total price: {Price}";
        }
    }

    class Cucumber : Product
    {
        public double Count { get; }
        public override double Price => GetBasePrice() * Count;

        public Cucumber(double basePrice, double count) : base(name: "Cucumber", basePrice)
        {
            Count = count;
        }

        public override string GetInfo()
        {
            return $"Product: {Name}, Price per kg: {GetBasePrice()}, Count: {Count}, Total price: {Price}";
        }
    }

    class VegetableShop
    {
        private List<Product> products = new List<Product>();

        public void AddProducts(List<Product> newProducts)
        {
            products.AddRange(newProducts);
        }

        public void PrintProductsInfo()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
                totalPrice += product.Price;
            }
            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}
