using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestCarClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceCarMethod()
        {
            
            double ActualPrice = 240;
            Car c = new Car();
            double thePrice = c.Price();
            Assert.AreEqual(240, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeCarMethod()
        {

            
            Car c = new Car();
            string theType = c.VehiculeType();
            Assert.AreEqual("Car", theType);
        }

        [TestMethod]
        public void TestPriceMCMethod()
        {
           
            MC mc = new MC();
            double thePrice = mc.Price();
            Assert.AreEqual(125, thePrice);
        }

        [TestMethod]
        public void TestVehiculeTypeMCMethod()
        {
            
            MC mc = new MC();
            string theType = mc.VehiculeType();
            Assert.AreEqual("MC", theType);

        }

        [TestMethod]
        public void LiscenePlateLenghtTest()
        {
            string liscencePlate = "ac14369";
            DateTime date = new DateTime(2020, 8, 14);
            bool BroBizz = false;
            double ActualPrice = 125;
            try
            {
                MC mc = new MC(liscencePlate, date, BroBizz, ActualPrice);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void BroBizzPriceTest()
        {
            string LiscencePlate = "Ac14369";
            DateTime Date = new DateTime(2020, 8, 22);
            bool BroBizz = true;
            double ActualPrice = 125;

            MC mc = new MC(LiscencePlate, Date, BroBizz, ActualPrice);


            double Price = mc.Price();

            Assert.AreEqual(125, Price);


        }
    }
}
