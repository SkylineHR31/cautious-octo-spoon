using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15._1
{
    internal abstract class Product
    {
        public string Name { get; }
        private double BasePrice;
        public virtual double Price => BasePrice;

        protected Product(string name, double basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        protected double GetBasePrice() => BasePrice;

        public virtual string GetInfo()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }
}
