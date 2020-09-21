using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestCarClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            ClassLibrary.Car car = new ClassLibrary.Car();

            //Act
            var expectedPrice = 240;
            var actualPrice = car.Price();

            //Assert
            Assert.AreEqual(actualPrice, expectedPrice);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            Car car = new Car();

            //Act
            var expectedResult = "Car";
            var actualResult = car.VehicleType();

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
