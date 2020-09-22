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
        public void TestLP()
        {
            Car car = new Car();
            string lp = car.LPCheck("CM12345");
            Assert.AreEqual("CM12345", lp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLPException()
        {
            MC mtb = new MC();
            string lp = mtb.LPCheck("12345678");
            Assert.Fail();
        }

        [TestMethod]
        public void TestDiscBrobizTrue()
        {
            Car car = new Car();
            double brochck = car.BrobizzDisc(true);
            Assert.AreEqual(228, brochck);
        }

        [TestMethod]
        public void TestDiscBrobizFalse()
        {
            MC mtb = new MC();
            double tst = mtb.BrobizzDisc(false);
            Assert.AreEqual(125,tst);
        }
    }
}
