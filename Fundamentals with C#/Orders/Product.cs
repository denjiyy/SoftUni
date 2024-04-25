using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public void Update(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price + Quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {TotalPrice():F2}";
        }
    }
}
