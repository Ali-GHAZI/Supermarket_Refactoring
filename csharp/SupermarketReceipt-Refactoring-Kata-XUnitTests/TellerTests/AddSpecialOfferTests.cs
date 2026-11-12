using Moq;
using SupermarketReceipt.Enums;
using SupermarketReceipt.Interfaces;
using SupermarketReceipt.Models;
using SupermarketReceipt.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketReceipt_Refactoring_Kata_XUnitTests.TellerTests
{
    public class AddSpecialOfferTests
    {
        [Fact]
        public void AddSpecialOffer_WhenProductIsValide_SpecialOfferIsAdded()
        {
            //Arrange
            var catalog = new Mock<ISupermarketCatalog>();
            var teller = new Teller(catalog.Object);
            double ricePrice = 2.49;
            var product = new Product("Rice", ProductUnit.Each, ricePrice);


            //Act
            teller.AddSpecialOffer(SpecialOfferType.TenPercentDiscount, product, 10);


            //Asert
            Assert.Contains(teller.)

        }


        [Fact]
        public void AddSpecialOffer_WhenProductIsNull_ThrowArgumentNullException()
        {
            //Arrange
            var catalog = new Mock<ISupermarketCatalog>();
            var teller = new Teller(catalog.Object);


            //Act & Asert
            Assert.Throws<ArgumentNullException>(() => teller.AddSpecialOffer(SpecialOfferType.TenPercentDiscount, null!, 10));

        }
    }
}
