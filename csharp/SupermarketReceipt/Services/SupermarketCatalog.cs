using System;
using SupermarketReceipt.Interfaces;
using SupermarketReceipt.Models;
using System.Collections.Generic;

namespace SupermarketReceipt.Services
{
    public class SupermarketCatalog : ISupermarketCatalog
    {

        public List<Product> _products { get; private set; } = new();
        public IReadOnlyList<Product> Products => _products.AsReadOnly();


        public void AddProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            if (_products.Contains(product))
            {
                throw new InvalidOperationException("Ce produit existe déjà");
            }

            _products.Add(product);

        }

        public double GetUnitPrice(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            return product.Price;
        }
    }
}