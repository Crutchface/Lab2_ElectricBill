using Lab2_ElectricBill;

namespace ElecTest
{
    [TestClass]
    public class ElecTest
    {
        [TestMethod]
        public void TestNumberCustomer()
        {
           
            // Arrange
            string firstName = "John123";
            string lastName = "Doe";
            

            // Act
            var customer = new CustomerData(firstName, lastName, 5);

        }
        [TestMethod]
        public void TestBlankCustomer()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe456";
           

            // Act
            var customer = new CustomerData(firstName, lastName, 10);

            // Assert - We expect an exception, so we don't reach this point
        }
        [TestMethod]
        public void TestValid()
        {   
            //Arrange
            string firstName = "John";
            string lastName = "Doe";

            // Act
            var customer = new CustomerData(firstName, lastName, 50);

            // Assert
            Assert.AreEqual(firstName, customer.FirstName);
            Assert.AreEqual(lastName, customer.LastName);
            Assert.AreEqual(50, customer.KwhUsed);
            Assert.IsTrue(customer.AccountNo > 0);
        }
        [TestMethod]
      
    }
}