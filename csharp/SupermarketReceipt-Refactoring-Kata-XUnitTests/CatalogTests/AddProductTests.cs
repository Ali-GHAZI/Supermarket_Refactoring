using SupermarketReceipt;
using SupermarketReceipt.Enums;
using SupermarketReceipt.Models;
using SupermarketReceipt.Services;

namespace SupermarketReceipt_Refactoring_Kata_XUnitTests.CatalogTests
{
    public class AddProductTests
    {


        [Fact]
        public void AddProduct_ShouldAddProductToCatalog()
        {
            //Arrange
            var superMarketCatalog = new SupermarketCatalog();
            var product = new Product("apple", ProductUnit.Kilo, 1.99);

            //Act
            superMarketCatalog.AddProduct(product);

            //Assert
            Assert.Contains(product, superMarketCatalog.Products);
        }

        [Fact]
        public void AddProduct_whenProductIsNull_ThrowArgumentNullException()
        {
            //Arrange
            var supermarketCatalog = new SupermarketCatalog();

            //Act and assert 
            Assert.Throws<ArgumentNullException>(()=> supermarketCatalog.AddProduct(null));
        }

        [Fact]
        public void AddProduct_WhenAlreadyExists_ThrowArgumentException()
        {
            //Arrange
            var supermarketCatalog = new SupermarketCatalog();
            var product = new Product("apple", ProductUnit.Kilo, 1.99);
            supermarketCatalog._products.Add(product);


            //Act and Assert
            Assert.Throws<InvalidOperationException> (() => supermarketCatalog.AddProduct(new Product("apple", ProductUnit.Kilo, 1.99)));
        }


    }
}
