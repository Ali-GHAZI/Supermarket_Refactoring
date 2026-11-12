using SupermarketReceipt;
using SupermarketReceipt.Models;
using SupermarketReceipt.Services;
using SupermarketReceipt.Enums;

namespace SupermarketReceipt_Refactoring_Kata_XUnitTests.CatalogTests
{
    public class GetUnitPriceTests
    {
        [Fact]
        public void GetUnitPrice_whenValidParameter_returnUnitPrice()
        {
            //Arrange
            var superMarketCatalog = new SupermarketCatalog();

            //Act
            var result = superMarketCatalog.GetUnitPrice(new Product("apple", ProductUnit.Kilo, 1.99));

            //Assert
            Assert.Equal(1.99, result);
        }

        [Fact]
        public void GetUnitPrice_whenProductIsNull_ThrowArgumentNullException()
        {
            //Arrange
            var supermarketCatalog = new SupermarketCatalog();

            //Act and assert 
            Assert.Throws<ArgumentNullException>(() => supermarketCatalog.GetUnitPrice(null));
        }
    }
}
