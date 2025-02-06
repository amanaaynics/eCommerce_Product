using eCommerce_Product;
using NUnit.Framework.Legacy;

namespace ProductTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        // test product constructor
        public void ShouldInitializeProperties_WhenValidDataIsProvided()
        {
            // Arrange 
            var product = new Product(500, "Laptop", 1000, 100);

            // Assert
            ClassicAssert.AreEqual(product.ProdID, 500);
            ClassicAssert.AreEqual(product.ProdName, "Laptop");
            ClassicAssert.AreEqual(product.ItemPrice, 1000);
            ClassicAssert.AreEqual(product.StockAmount, 100);
            
        }

        [Test]
        // Increase Stock Test
        public void IncreaseStock_WhenValidDataIsGiven()
        {
            // Arrange
            var product = new Product(500, "Laptop", 1000, 100);

            //Assert
            product.IncreaseStock(500);

            //Act
            ClassicAssert.AreEqual(product.StockAmount, 600);

        }

        [Test]
        // Decrease Stock Test
        public void DecreaseStock_WhenValidDataIsGiven()
        {
            // Arrange
            var product = new Product(500, "Laptop", 1000, 1000);

            //Assert
            product.DecreaseStock(500);

            //Act
            ClassicAssert.AreEqual(product.StockAmount, 500);

        }

        [Test]
        // Increase Stock Test 
        public void IncreaseStock_ShouldNotPassIfAmountIsNegative()
        {
            // Arrange
            var product = new Product(500, "Laptop", 1000, 100);

            //Assert
            product.IncreaseStock(-50);

            //Act
            ClassicAssert.AreEqual(product.StockAmount, 100);

        }

        // Decrease Stock Test 
        [Test]
        public void DecreaseStock_ShouldNotPassIfAmountIsNegative()
        {
            // Arrange
            var product = new Product(500, "Laptop", 1000, 100);

            //Assert
            product.DecreaseStock(200);

            //Act
            ClassicAssert.AreEqual(product.StockAmount, 100);

        }
        [Test]
        //Decrease Stock Test 
        public void DecreaseStock_ShouldNotPassIfStockIsZero()
        {
            // Arrange
            var product = new Product(500, "Laptop", 1000, 0);

            //Assert
            product.DecreaseStock(5);

            //Act
            ClassicAssert.AreEqual(product.StockAmount, 0);
        }
    }
}