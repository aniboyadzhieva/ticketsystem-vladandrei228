using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using StoreBaeltTicketLibrary;

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
            Car car = new Car("CM12345", DateTime.Today, true);
            string lp = car.LPCheck();
            Assert.AreEqual("CM12345", lp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLPException()
        {
            MC mtb = new MC("MD231452", DateTime.Today, false);
            string lp = mtb.LPCheck();
            Assert.Fail();
        }

        [TestMethod]
        public void TestDiscBrobizTrue()
        {
            Car car = new Car("1234567", DateTime.Today, true);
            double brochck = car.BrobizzDisc();
            Assert.AreEqual(228, brochck);
        }

        [TestMethod]
        public void TestDiscBrobizFalse()
        {
            MC mtb = new MC("1234567", DateTime.Today, false);
            double tst = mtb.BrobizzDisc();
            Assert.AreEqual(125,tst);
        }



    }
}
