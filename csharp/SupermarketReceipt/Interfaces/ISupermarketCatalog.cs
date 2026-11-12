using SupermarketReceipt.Models;

namespace SupermarketReceipt.Interfaces
{
    public interface ISupermarketCatalog
    {
        void AddProduct(Product product);

        double GetUnitPrice(Product product);
    }
}