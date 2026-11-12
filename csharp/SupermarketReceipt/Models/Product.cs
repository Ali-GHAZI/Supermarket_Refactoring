using System;
using SupermarketReceipt.Enums;
using System.Collections.Generic;

namespace SupermarketReceipt.Models
{
    public class Product
    {
        public Product(string name, ProductUnit unit, double price)
        {
            Name = name;
            Unit = unit;
            Price = price;
        }

        public string Name { get; }

        public ProductUnit Unit { get; }

        public double Price { get; }

        public int quantity { get; }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return product != null &&
                   Name == product.Name &&
                   Unit == product.Unit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Unit);
        }
    }

    public class ProductQuantity
    {
        public ProductQuantity(Product product, double weight)
        {
            Product = product;
            Quantity = weight;
        }

        public Product Product { get; }
        public double Quantity { get; }
    }
}