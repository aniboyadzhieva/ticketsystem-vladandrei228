using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestCarClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceInCar()
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
        public void TestVehicleTypeInCar()
        {
            //Arrange
            Car car = new Car();

            //Act
            var expectedResult = "Car";
            var actualResult = car.VehicleType();

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestPriceInMC()
        {
            //Assert
            ClassLibrary.MC mc = new ClassLibrary.MC();

            //Act
            var expectedPRice = 125;
            var actualPrice = mc.Price();

            //Assert
            Assert.AreEqual(actualPrice, expectedPRice);
        }

        [TestMethod]
        public void TestVehicleTypeInMC()
        {
            //Arrange
            MC mc = new MC();

            //Act
            var expectedResult = "MC";
            var actualResult = mc.Vehicle();

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
